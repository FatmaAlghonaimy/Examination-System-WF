using Examination_System;
using Examination_System.Business;
using Examination_System.Business.Enums;
using Examination_System.Presentation;
using Examination_System.Presentation.TeacherForms;
using ExaminationSystem.Business.Enums;
using ExaminationSystem.Business.QuestionAnswerService;
using ExaminationSystem.Data_Access.Models;

namespace ExaminationSystem
{
    public partial class FormAddQuestionWithAnswers : Form
    {
        private AnswerList _answers;
        private FlowLayoutPanel MCQAnswerPanel;
        private Button btnAddAnswer;

        public FormAddQuestionWithAnswers()
        {
            InitializeComponent();
            _answers = [];
            cmbQuestionTypes.DataSource = Enum.GetValues<QuestionType>();
            cmbQuestionTypes.SelectedIndex = -1;
            cmbQuestionTypes.SelectedIndexChanged += CmbQuestionTypes_SelectedIndexChanged;
            LoadCourses();
        }
        private void LoadCourses()
        {
            cmbCourseName.DataSource = CourseService.GetAllCoursesListWithTeacherID(General.LoggedUser.ID);
            cmbCourseName.DisplayMember = "Name";
            cmbCourseName.ValueMember = "ID";
            cmbCourseName.SelectedIndex = -1;
        }
        private void CmbQuestionTypes_SelectedIndexChanged(object sender, EventArgs e)
        {
            AnswerPanel.Controls.Clear();
            _answers.Clear();

            if (cmbQuestionTypes.SelectedItem is not null)
            {
                QuestionType selectedType = (QuestionType)cmbQuestionTypes.SelectedItem;

                switch (selectedType)
                {
                    case QuestionType.TrueOrFalse:
                        FlowLayoutPanel radioPanel = new FlowLayoutPanel()
                        {
                            FlowDirection = FlowDirection.TopDown,
                            AutoSize = true,
                            AutoSizeMode = AutoSizeMode.GrowAndShrink
                        };

                        RadioButton rbTrue = new RadioButton() { Text = "True", Name = "rbTrue" };
                        RadioButton rbFalse = new RadioButton() { Text = "False", Name = "rbFalse" };

                        radioPanel.Controls.Add(rbTrue);
                        radioPanel.Controls.Add(rbFalse);

                        AnswerPanel.Controls.Add(radioPanel);
                        break;

                    case QuestionType.SingleChoice:
                    case QuestionType.MultipleChoice:
                        MCQAnswerPanel = new FlowLayoutPanel()
                        {
                            FlowDirection = FlowDirection.TopDown,
                            AutoSize = true,
                            AutoSizeMode = AutoSizeMode.GrowAndShrink
                        };

                        btnAddAnswer = new Button() { Text = "Add Answer", Width = 100, Dock = DockStyle.Bottom, Height = 30 };
                        btnAddAnswer.Click += BtnAddAnswer_Click;

                        AnswerPanel.Controls.Clear();
                        AnswerPanel.Controls.Add(MCQAnswerPanel);
                        AnswerPanel.Controls.Add(btnAddAnswer);
                        break;
                }
            }
        }
        private void BtnAddAnswer_Click(object sender, EventArgs e)
        {
            QuestionType selectedType = (QuestionType)cmbQuestionTypes.SelectedItem;

            if (MCQAnswerPanel == null)
                return;

            FlowLayoutPanel answerRow = new FlowLayoutPanel()
            {
                FlowDirection = FlowDirection.LeftToRight,
                AutoSize = true,
                AutoSizeMode = AutoSizeMode.GrowAndShrink,
                Margin = new Padding(5)
            };

            TextBox txtAnswer = new TextBox() { Width = 200 };

            if (selectedType == QuestionType.SingleChoice)
            {
                RadioButton rbOption = new RadioButton();
                rbOption.Click += (s, ev) =>
                {
                    foreach (Control control in MCQAnswerPanel.Controls)
                    {
                        if (control is FlowLayoutPanel row)
                        {
                            foreach (Control innerControl in row.Controls)
                            {
                                if (innerControl is RadioButton rb && rb != rbOption)
                                {
                                    rb.Checked = false;
                                }
                            }
                        }
                    }
                };
                answerRow.Controls.Add(rbOption);
            }
            else if (selectedType == QuestionType.MultipleChoice)
            {
                CheckBox chkOption = new CheckBox();
                answerRow.Controls.Add(chkOption);
            }

            answerRow.Controls.Add(txtAnswer);


            Button btnDelete = new Button() { Text = "X", Width = 30, BackColor = Color.Red, ForeColor = Color.White, Height = 30 };
            btnDelete.Click += (s, ev) =>
            {
                MCQAnswerPanel.Controls.Remove(answerRow);
                answerRow.Dispose();
            };

            answerRow.Controls.Add(btnDelete);

            MCQAnswerPanel.Controls.Add(answerRow);
            MCQAnswerPanel.PerformLayout();

            AnswerPanel.Controls.SetChildIndex(btnAddAnswer, AnswerPanel.Controls.Count - 1);
        }
        private void BtnSave_Click(object sender, EventArgs e)
        {
            Question question = GetQuestionFromUI();

            if (question == null || question.AnswerList.Count == 0)
            {
                //MessageBox.Show("Please enter a valid question and at least one answer.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            bool success = QuestionAnswerService.AddQuestionWithAnswers(question, question.AnswerList);

            if (success)
            {
                MessageBox.Show("Question saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ResetForm();
            }
            else
            {
                MessageBox.Show("Failed to save question.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void ResetForm()
        {
            txtQuestionBody.Text = "";
            cmbQuestionTypes.SelectedIndex = -1;
            cmbCourseName.SelectedIndex = -1;
            MarksUpDown.Value = 1;
            AnswerPanel.Controls.Clear();
            _answers.Clear();
        }
        private AnswerList GetAnswersFromUI()
        {
            AnswerList answers = [];

            QuestionType selectedType = (QuestionType)cmbQuestionTypes.SelectedItem;
            switch (selectedType)
            {
                case QuestionType.TrueOrFalse:
                    FlowLayoutPanel trueFalsePanel = AnswerPanel.Controls.OfType<FlowLayoutPanel>().FirstOrDefault();
                    if (trueFalsePanel != null)
                    {
                        RadioButton rbTrue = trueFalsePanel.Controls.OfType<RadioButton>().FirstOrDefault(rb => rb.Text == "True");
                        RadioButton rbFalse = trueFalsePanel.Controls.OfType<RadioButton>().FirstOrDefault(rb => rb.Text == "False");
                        if (rbTrue != null && rbTrue.Checked)
                        {
                            answers.Add(new Answer { AnswerText = "True", IsAnswerCorrect = true });
                            answers.Add(new Answer { AnswerText = "False", IsAnswerCorrect = false });
                        }
                        else if (rbFalse != null && rbFalse.Checked)
                        {
                            answers.Add(new Answer { AnswerText = "True", IsAnswerCorrect = false });
                            answers.Add(new Answer { AnswerText = "False", IsAnswerCorrect = true });
                        }
                        else
                        {
                            MessageBox.Show("Please select True or False.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return [];
                        }
                    }
                    break;
                case QuestionType.SingleChoice:
                case QuestionType.MultipleChoice:
                    if (MCQAnswerPanel != null)
                    {
                        bool hasCorrectAnswer = false;
                        foreach (Control control in MCQAnswerPanel.Controls)
                        {
                            if (control is FlowLayoutPanel answerRow)
                            {
                                TextBox txtAnswer = answerRow.Controls.OfType<TextBox>().FirstOrDefault();
                                if (txtAnswer == null || string.IsNullOrWhiteSpace(txtAnswer.Text))
                                    continue;
                                bool isCorrect = false;
                                if (selectedType == QuestionType.SingleChoice)
                                {
                                    RadioButton rbOption = answerRow.Controls.OfType<RadioButton>().FirstOrDefault();
                                    if (rbOption != null && rbOption.Checked)
                                    {
                                        isCorrect = true;
                                        hasCorrectAnswer = true;
                                    }
                                }
                                else if (selectedType == QuestionType.MultipleChoice)
                                {
                                    CheckBox chkOption = answerRow.Controls.OfType<CheckBox>().FirstOrDefault();
                                    if (chkOption != null && chkOption.Checked)
                                    {
                                        isCorrect = true;
                                        hasCorrectAnswer = true;
                                    }
                                }
                                answers.Add(new Answer { AnswerText = txtAnswer.Text, IsAnswerCorrect = isCorrect });
                            }
                        }
                        // Ensure at least two answers are provided
                        if (answers.Count < 2)
                        {
                            MessageBox.Show("Please add at least two answers.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return [];
                        }
                        // Ensure at least one correct answer is selected
                        if (!hasCorrectAnswer)
                        {
                            MessageBox.Show("Please select at least one correct answer.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return [];
                        }
                    }
                    break;
            }
            return answers;
        }
        private Question GetQuestionFromUI()
        {
            if (cmbQuestionTypes.SelectedItem is null)
            {
                MessageBox.Show("Please select a question type.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return null;
            }
            QuestionType selectedType = (QuestionType)cmbQuestionTypes.SelectedItem;

            if (cmbCourseName.SelectedItem is not Course selectedCourse)
            {
                MessageBox.Show("Please select a course.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return null;
            }
            if (string.IsNullOrWhiteSpace(txtQuestionBody.Text))
            {
                MessageBox.Show("Please enter a question.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return null;
            }

            AnswerList answers = GetAnswersFromUI(); ;

            return new Question
            {
                Body = txtQuestionBody.Text,
                Type = selectedType,
                AnswerList = answers,
                Marks = (int)MarksUpDown.Value,
                CourseID = selectedCourse.ID
            };
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            new FormManageQuestions().Show();
        }
    }
}