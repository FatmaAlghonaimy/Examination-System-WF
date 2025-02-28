using System;
using System.Data;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using ComboBox = System.Windows.Forms.ComboBox;
using ProgressBar = System.Windows.Forms.ProgressBar;
using TextBox = System.Windows.Forms.TextBox;
using Timer = System.Windows.Forms.Timer;

namespace Examination_System.Presentation.StudentForms
{
    public partial class frmExam : Form
    {
        private int examDuration = 3600;
        private int timeRemaining;
        private Timer examTimer;
        private ProgressBar progressBar;

        public frmExam()
        {
            InitializeComponent();
            InitializeProgressBar();
            timeRemaining = examDuration;
            examTimer = new Timer { Interval = 1000 };
            examTimer.Tick += async (s, e) => await UpdateTimer();
        }

        private void InitializeProgressBar()
        {
            progressBar = new ProgressBar
            {
                Minimum = 0,
                Maximum = 100,
                Value = 100,
                Dock = DockStyle.Top,
                Height = 20
            };
            Controls.Add(progressBar);
        }

        private async void frmExam_Load(object sender, EventArgs e)
        {
            await LoadExamQuestionsAsync();
            examTimer.Start();
        }

        private async Task UpdateTimer()
        {
            timeRemaining--;
            lblTime.Text = $"Time Remaining: {TimeSpan.FromSeconds(timeRemaining)}";
            progressBar.Value = (int)((double)timeRemaining / examDuration * 100);

            if (timeRemaining <= 0)
            {
                examTimer.Stop();
                await AutoSubmitExamAsync();
            }
        }

        private async Task AutoSubmitExamAsync()
        {
            await SaveAllAnswersAsync();
            MessageBox.Show("Time finished! Exam submitted.");
            Close();
        }

        private async void btnSubmit_Click(object sender, EventArgs e)
        {
            examTimer.Stop();
            await SaveAllAnswersAsync();
            MessageBox.Show("Exam submitted successfully!");
            Close();
        }

        private async void txtAnswer_Leave(object sender, EventArgs e)
        {
            if (sender is TextBox txt && txt.Parent is Panel panel && panel.Controls["lblQuestionId"] is Label lblQuestionId)
            {
                int questionId = int.Parse(lblQuestionId.Text);
                string answer = txt.Text;
                await SaveAnswerToDatabaseAsync(questionId, answer);
            }
        }

        private async Task SaveAnswerToDatabaseAsync(int questionId, string answer)
        {
            string connString = "Data Source=.;Initial Catalog=FatmaLast;Integrated Security=True;Encrypt=True;Trust Server Certificate=True";
            string query = @"MERGE INTO submit AS target
                             USING (SELECT @StudentId AS StudentId, @ID AS ID) AS source
                             ON target.StudentId = source.StudentId AND target.ID = source.ID
                             WHEN MATCHED THEN UPDATE SET Answer = @Answer
                             WHEN NOT MATCHED THEN INSERT (StudentId, ID, Answer) VALUES (@StudentId, @ID, @Answer);";

            using (SqlConnection conn = new SqlConnection(connString))
            {
                await conn.OpenAsync();
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@StudentId", General.LoggedUser.ID);
                    cmd.Parameters.AddWithValue("@ID", questionId);
                    cmd.Parameters.AddWithValue("@Answer", answer);
                    await cmd.ExecuteNonQueryAsync();
                }
            }
        }

        private async Task SaveAllAnswersAsync()
        {
            foreach (Control ctrl in panelQuestions.Controls)
            {
                if (ctrl is Panel questionPanel && questionPanel.Controls["txtAnswer"] is TextBox txtAnswer && questionPanel.Controls["lblQuestionId"] is Label lblQuestionId)
                {
                    int questionId = int.Parse(lblQuestionId.Text);
                    string answer = txtAnswer.Text;
                    await SaveAnswerToDatabaseAsync(questionId, answer);
                }
            }
        }

        private async Task<DataTable> GetExamQuestionsFromDBAsync()
        {
            DataTable dtQuestions = new DataTable();
            string connString = "Data Source=.;Initial Catalog=FatmaLast;Integrated Security=True;Encrypt=True;Trust Server Certificate=True";
            string sql = "SELECT q.ID, q.Body, q.Type, a.AnswerText FROM Questions q LEFT JOIN Answers a ON q.ID = a.QuestionID;";

            using (SqlConnection conn = new SqlConnection(connString))
            {
                await conn.OpenAsync();
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                {
                    da.Fill(dtQuestions);
                }
            }
            return dtQuestions;
        }

        private async Task LoadExamQuestionsAsync()
        {
            DataTable dtQuestions = await GetExamQuestionsFromDBAsync();
            panelQuestions.Controls.Clear();
            int yPos = 10;

            foreach (DataRow row in dtQuestions.Rows)
            {
                Panel questionPanel = new Panel { BorderStyle = BorderStyle.FixedSingle, Width = panelQuestions.Width - 20, Height = 100, Location = new Point(10, yPos) };
                Label lblQuestion = new Label { Text = row["Body"].ToString(), Location = new Point(10, 10), AutoSize = true };
                Label lblQuestionId = new Label { Text = row["ID"].ToString(), Name = "lblQuestionId", Visible = false };
                questionPanel.Controls.Add(lblQuestion);
                questionPanel.Controls.Add(lblQuestionId);

                if (row["Type"].ToString() == "MultipleChoice")
                {
                    ComboBox cmbAnswers = new ComboBox { Width = questionPanel.Width - 20, Location = new Point(10, 40) };
                    cmbAnswers.Items.Add(row["AnswerText"].ToString());
                    cmbAnswers.SelectedIndexChanged += async (s, e) => await SaveAnswerToDatabaseAsync(int.Parse(lblQuestionId.Text), cmbAnswers.SelectedItem.ToString());
                    questionPanel.Controls.Add(cmbAnswers);
                }
                else
                {
                    TextBox txtAnswer = new TextBox { Name = "txtAnswer", Width = questionPanel.Width - 20, Location = new Point(10, 40) };
                    txtAnswer.Leave += txtAnswer_Leave;
                    questionPanel.Controls.Add(txtAnswer);
                }

                panelQuestions.Controls.Add(questionPanel);
                yPos += questionPanel.Height + 10;
            }
        }
    }
}
 