using Examination_System.Business;
using Examination_System.Business.Enums;
using iTextSharp.text.pdf;
using iTextSharp.text;
using System.Data;



namespace Examination_System.Presentation.AdminForms
{
    public partial class frmShowStudentExam : Form
    {
        private int studentId;
        private int examId;
        public frmShowStudentExam(int _studentId, int _examId)
        {
            InitializeComponent();
            studentId = _studentId;
            examId = _examId;
            LoadQuestions();
        }

        private void LoadQuestions()
        {
            DataTable dtQuestions = UserService.GetStudentExamQuestions(studentId, examId);
            foreach (DataRow row in dtQuestions.Rows)
            {
                int questionId = Convert.ToInt32(row["Id"]);
                string questionText = row["Body"].ToString();
                QuestionType questionType = (QuestionType)(Byte)row["QuestionType"];

                Label lblQuestion = new Label();
                lblQuestion.Text = questionText;
                lblQuestion.AutoSize = true;
                lblQuestion.Margin = new Padding(10);

                FlowLayoutPanel panel = new FlowLayoutPanel();
                panel.FlowDirection = FlowDirection.TopDown;
                panel.AutoSize = true;
                panel.Width = flowLayoutPanelQuestions.Width - 20;
                panel.Controls.Add(lblQuestion);

                LoadAnswers(questionId, questionType, panel);

                flowLayoutPanelQuestions.Controls.Add(panel);

                // Add a horizontal separator
                Label separator = new Label();
                separator.BorderStyle = BorderStyle.Fixed3D;
                separator.Height = 2;
                separator.Width = flowLayoutPanelQuestions.Width - 20;
                separator.Margin = new Padding(0, 10, 0, 10);
                flowLayoutPanelQuestions.Controls.Add(separator);
            }
        }


        private void LoadAnswers(int questionId, QuestionType questionType, FlowLayoutPanel panel)
        {
            DataTable dtAnswers = UserService.GetStudentExamQuestionAnswers(questionId);

            if (questionType == QuestionType.SingleChoice)
            {
                RadioButton[] radioButtons = new RadioButton[dtAnswers.Rows.Count];
                for (int i = 0; i < dtAnswers.Rows.Count; i++)
                {
                    radioButtons[i] = new RadioButton
                    {
                        Text = dtAnswers.Rows[i]["AnswerText"].ToString(),
                        AutoSize = true
                    };
                    panel.Controls.Add(radioButtons[i]);
                }
            }
            else if (questionType == QuestionType.MultipleChoice)
            {
                CheckBox[] checkBoxes = new CheckBox[dtAnswers.Rows.Count];
                for (int i = 0; i < dtAnswers.Rows.Count; i++)
                {
                    checkBoxes[i] = new CheckBox
                    {
                        Text = dtAnswers.Rows[i]["AnswerText"].ToString(),
                        AutoSize = true
                    };
                    panel.Controls.Add(checkBoxes[i]);
                }
            }
            else if (questionType == QuestionType.TrueOrFalse)
            {
                RadioButton rbTrue = new RadioButton { Text = "True", AutoSize = true };
                RadioButton rbFalse = new RadioButton { Text = "False", AutoSize = true };
                panel.Controls.Add(rbTrue);
                panel.Controls.Add(rbFalse);
            }

        }

        

private void btnExportPDF_Click(object sender, EventArgs e)
    {
        SaveFileDialog saveFileDialog = new SaveFileDialog();
        saveFileDialog.Filter = "PDF Files|*.pdf";
        saveFileDialog.Title = "Save Exam as PDF";
        saveFileDialog.FileName = "Exam.pdf";

        if (saveFileDialog.ShowDialog() == DialogResult.OK)
        {
            try
            {
                using (FileStream stream = new FileStream(saveFileDialog.FileName, FileMode.Create))
                {
                    Document pdfDoc = new Document(PageSize.A4);
                    PdfWriter writer = PdfWriter.GetInstance(pdfDoc, stream);
                    pdfDoc.Open();

                    // Add Title
                    iTextSharp.text.Font titleFont = FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 18);
                    Paragraph title = new Paragraph("Student Exam", titleFont);
                    title.Alignment = Element.ALIGN_CENTER;
                    pdfDoc.Add(title);

                    pdfDoc.Add(new Paragraph("\n"));

                    // Loop through the questions
                    foreach (Control control in flowLayoutPanelQuestions.Controls)
                    {
                        if (control is FlowLayoutPanel panel)
                        {
                            foreach (Control innerControl in panel.Controls)
                            {
                                if (innerControl is Label lblQuestion)
                                {
                                        iTextSharp.text.Font questionFont = FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 14);
                                    pdfDoc.Add(new Paragraph(lblQuestion.Text, questionFont));
                                }
                                else if (innerControl is RadioButton radio)
                                {
                                    pdfDoc.Add(new Paragraph("  ○ " + radio.Text));
                                }
                                else if (innerControl is CheckBox checkBox)
                                {
                                    pdfDoc.Add(new Paragraph("  ☑ " + checkBox.Text));
                                }
                            }
                            pdfDoc.Add(new Paragraph("\n"));
                        }
                    }

                    pdfDoc.Close();
                }

                MessageBox.Show("Exam exported successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Export Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }

}
}
