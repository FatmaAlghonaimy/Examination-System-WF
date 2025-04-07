using Examination_System.Business;
using Examination_System.Business.Enums;
using Examination_System.Business.StudentExamService;
using ExaminationSystem.Business.ExamService;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Timer = System.Windows.Forms.Timer;

namespace Examination_System.Presentation.StudentForms
{
    public partial class frmShowStudentExam : Form
    {
        private int studentId;
        private int examId;
        private DataTable dtQuestions;
        private int currentQuestionIndex = 0;
        private Timer examTimer;
        private DateTime examEndTime;
        // لتخزين الإجابات المُختارة لكل سؤال
        private Dictionary<int, List<int>> submittedAnswers;

        public frmShowStudentExam(int _studentId, int _examId)
        {
            InitializeComponent();
            studentId = _studentId;
            examId = _examId;
            submittedAnswers = new Dictionary<int, List<int>>();

            // تعديل التصميم العام للنموذج
            this.BackColor = Color.WhiteSmoke;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.StartPosition = FormStartPosition.CenterScreen;

            try
            {
                // تحميل تفاصيل الامتحان والتحقق من وقت البدء
                LoadExamDetails();

                dtQuestions = UserService.GetStudentExamQuestions(studentId, examId);
                if (dtQuestions == null || dtQuestions.Rows.Count == 0)
                {
                    MessageBox.Show("No questions found for this exam.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                    return;
                }

                LoadQuestion(currentQuestionIndex);
                InitializeTimer();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while loading exam data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }

        private void LoadExamDetails()
        {
            try
            {
                DataTable exam = ExamService.GetExamById(examId);
                if (exam != null && exam.Rows.Count > 0)
                {
                    // عرض عنوان الامتحان مع تنسيق محسّن
                    lb_examtitle.Text = $"Exam: {exam.Rows[0]["ExamType"]}";
                    lb_examtitle.Font = new Font("Segoe UI", 16, FontStyle.Bold);
                    lb_examtitle.ForeColor = Color.FromArgb(0, 120, 215);

                    // الحصول على وقت بدء الامتحان من قاعدة البيانات (يفترض أنه موجود بالحقل "StartTime")
                    DateTime examStartTime = Convert.ToDateTime(exam.Rows[0]["StartTime"]);

                    // التأكد من أن الامتحان بدأ بالفعل
                    if (DateTime.Now < examStartTime)
                    {
                        MessageBox.Show("The exam has not started yet. Please start at " + examStartTime.ToString("T"),
                                        "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                        return;
                    }

                    // حساب وقت انتهاء الامتحان بناءً على وقت البدء
                    int duration;
                    if (int.TryParse(exam.Rows[0]["Duration"].ToString(), out duration))
                    {
                        examEndTime = examStartTime.AddMinutes(duration);
                    }
                    else
                    {
                        examEndTime = examStartTime.AddMinutes(60); // مدة افتراضية 60 دقيقة
                    }
                    lb_result.Text = $"Time Remaining: {examEndTime.Subtract(DateTime.Now):hh\\:mm\\:ss}";
                    lb_result.Font = new Font("Segoe UI", 14, FontStyle.Regular);
                    lb_result.ForeColor = Color.DarkRed;
                }
                else
                {
                    MessageBox.Show("Exam details not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while loading exam details: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }

        private void InitializeTimer()
        {
            examTimer = new Timer();
            examTimer.Interval = 1000; // 1 ثانية
            examTimer.Tick += ExamTimer_Tick;
            examTimer.Start();
        }

        private void ExamTimer_Tick(object sender, EventArgs e)
        {
            TimeSpan remainingTime = examEndTime.Subtract(DateTime.Now);
            lb_result.Text = $"Time Remaining: {remainingTime:hh\\:mm\\:ss}";

            if (remainingTime.TotalSeconds <= 0)
            {
                examTimer.Stop();
                MessageBox.Show("Time's up! The exam has ended.", "Time Up", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
        }

        private void LoadQuestion(int questionIndex)
        {
            if (questionIndex < 0 || questionIndex >= dtQuestions.Rows.Count)
            {
                MessageBox.Show("Invalid question index.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            flowLayoutPanelQuestions.Controls.Clear();

            try
            {
                DataRow questionRow = dtQuestions.Rows[questionIndex];
                int questionId = Convert.ToInt32(questionRow["Id"]);
                string questionText = questionRow["Body"].ToString();
                QuestionType questionType = (QuestionType)Convert.ToByte(questionRow["QuestionType"]);

                // Display the question with improved formatting
                Label lblQuestion = new Label
                {
                    Text = questionText,
                    AutoSize = true, // Allow the label to grow vertically
                    MaximumSize = new Size(flowLayoutPanelQuestions.Width - 20, 0), // Set maximum width to panel width minus padding
                    Font = new Font("Segoe UI", 14, FontStyle.Bold),
                    ForeColor = Color.FromArgb(0, 120, 215),
                    TextAlign = ContentAlignment.MiddleLeft, // Align text to the left
                    Dock = DockStyle.Top,
                    Padding = new Padding(10),
                    BackColor = Color.White
                };
                flowLayoutPanelQuestions.Controls.Add(lblQuestion);

                // Load answers for the question and restore the answer state if it exists
                LoadAnswers(questionId, questionType);

                // Create navigation and submit buttons with improved formatting
                FlowLayoutPanel navigationPanel = new FlowLayoutPanel
                {
                    FlowDirection = FlowDirection.LeftToRight,
                    AutoSize = true,
                    Margin = new Padding(10)
                };

                Button btnPrevious = new Button
                {
                    Text = "Previous",
                    Enabled = (currentQuestionIndex > 0),
                    FlatStyle = FlatStyle.Flat,
                    BackColor = Color.FromArgb(240, 240, 240),
                    ForeColor = Color.Black,
                    Font = new Font("Segoe UI", 10, FontStyle.Bold),
                    Margin = new Padding(5),
                    Width = 100,
                    Height = 40
                };
                Button btnNext = new Button
                {
                    Text = "Next",
                    Enabled = (currentQuestionIndex < dtQuestions.Rows.Count - 1),
                    FlatStyle = FlatStyle.Flat,
                    BackColor = Color.FromArgb(240, 240, 240),
                    ForeColor = Color.Black,
                    Font = new Font("Segoe UI", 10, FontStyle.Bold),
                    Margin = new Padding(5),
                    Width = 100,
                    Height = 40
                };

                // Add the Submit button only for the last question
                if (currentQuestionIndex == dtQuestions.Rows.Count - 1)
                {
                    Button btnSubmitAnswer = new Button
                    {
                        Text = "Submit Exam",
                        FlatStyle = FlatStyle.Flat,
                        BackColor = Color.FromArgb(0, 120, 215),
                        ForeColor = Color.White,
                        Font = new Font("Segoe UI", 10, FontStyle.Bold),
                        Margin = new Padding(5),
                        Width = 140,
                        Height = 40
                    };

                    btnSubmitAnswer.Click += (s, e) =>
                    {
                        SubmitAnswer(questionId, btnSubmitAnswer);
                    };

                    navigationPanel.Controls.Add(btnSubmitAnswer);
                }

                btnPrevious.Click += (s, e) =>
                {
                    SaveCurrentAnswer(questionId);
                    currentQuestionIndex--;
                    LoadQuestion(currentQuestionIndex);
                };

                btnNext.Click += (s, e) =>
                {
                    SaveCurrentAnswer(questionId);
                    currentQuestionIndex++;
                    LoadQuestion(currentQuestionIndex);
                };

                navigationPanel.Controls.Add(btnPrevious);
                navigationPanel.Controls.Add(btnNext);

                flowLayoutPanelQuestions.Controls.Add(navigationPanel);

                // Update the progress indicator with improved formatting
                lb_examtitle.Text = $"Question {currentQuestionIndex + 1} of {dtQuestions.Rows.Count}";
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while loading the question: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void LoadAnswers(int questionId, QuestionType questionType)
        {
            try
            {
                DataTable dtAnswers = UserService.GetStudentExamQuestionAnswers(questionId);
                if (dtAnswers == null || dtAnswers.Rows.Count == 0)
                {
                    MessageBox.Show("No answers found for this question.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                // التحقق مما إذا كانت الإجابة للسؤال قد تم تقديمها مسبقًا
                bool isSubmitted = submittedAnswers.ContainsKey(questionId);
                List<int> savedAnswers = isSubmitted ? submittedAnswers[questionId] : new List<int>();

                if (questionType == QuestionType.SingleChoice || questionType == QuestionType.TrueOrFalse)
                {
                    foreach (DataRow answerRow in dtAnswers.Rows)
                    {
                        RadioButton radio = new RadioButton
                        {
                            Text = answerRow["AnswerText"].ToString(),
                            Tag = answerRow["Id"],
                            AutoSize = true, // Allow the radio button to grow vertically
                            MaximumSize = new Size(flowLayoutPanelQuestions.Width - 20, 0), // Set maximum width to panel width minus padding
                            Margin = new Padding(10),
                            Enabled = !isSubmitted,
                            Font = new Font("Segoe UI", 12, FontStyle.Regular),
                            ForeColor = Color.Black
                        };
                        int answerId = Convert.ToInt32(answerRow["Id"]);
                        if (savedAnswers.Contains(answerId))
                        {
                            radio.Checked = true;
                        }
                        flowLayoutPanelQuestions.Controls.Add(radio);
                    }
                }
                else if (questionType == QuestionType.MultipleChoice)
                {
                    foreach (DataRow answerRow in dtAnswers.Rows)
                    {
                        CheckBox checkBox = new CheckBox
                        {
                            Text = answerRow["AnswerText"].ToString(),
                            Tag = answerRow["Id"],
                            AutoSize = true, // Allow the checkbox to grow vertically
                            MaximumSize = new Size(flowLayoutPanelQuestions.Width - 20, 0), // Set maximum width to panel width minus padding
                            Margin = new Padding(10),
                            Enabled = !isSubmitted,
                            Font = new Font("Segoe UI", 12, FontStyle.Regular),
                            ForeColor = Color.Black
                        };
                        int answerId = Convert.ToInt32(answerRow["Id"]);
                        if (savedAnswers.Contains(answerId))
                        {
                            checkBox.Checked = true;
                        }
                        flowLayoutPanelQuestions.Controls.Add(checkBox);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while loading answers: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SaveCurrentAnswer(int questionId)
        {
            // Save the currently selected answers to memory
            var selectedAnswers = flowLayoutPanelQuestions.Controls
                .OfType<RadioButton>()
                .Where(r => r.Checked)
                .Select(r => Convert.ToInt32(r.Tag))
                .Union(
                    flowLayoutPanelQuestions.Controls
                        .OfType<CheckBox>()
                        .Where(c => c.Checked)
                        .Select(c => Convert.ToInt32(c.Tag))
                ).ToList();

            if (submittedAnswers.ContainsKey(questionId))
            {
                submittedAnswers[questionId] = selectedAnswers;
            }
            else
            {
                submittedAnswers.Add(questionId, selectedAnswers);
            }
        }

        private void SubmitAnswer(int questionId, Button submitButton)
        {
            try
            {
                // Save the current question's answers before submitting
                SaveCurrentAnswer(questionId);

                // Submit all saved answers
                foreach (var kvp in submittedAnswers)
                {
                    int currentQuestionId = kvp.Key;
                    List<int> selectedAnswers = kvp.Value;

                    // Retrieve the question type for the current question
                    QuestionType questionType = (QuestionType)Convert.ToByte(
                        dtQuestions.Rows.Cast<DataRow>()
                            .FirstOrDefault(row => Convert.ToInt32(row["Id"]) == currentQuestionId)?["QuestionType"]);

                    // Submit the answers for the current question
                    UserService.SubmitAnswer(studentId, examId, currentQuestionId, selectedAnswers, questionType);
                }

                MessageBox.Show("All answers submitted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Disable answer controls to prevent further modifications
                foreach (var control in flowLayoutPanelQuestions.Controls)
                {
                    if (control is RadioButton rb)
                        rb.Enabled = false;
                    else if (control is CheckBox cb)
                        cb.Enabled = false;
                }

                // Disable the submit button
                submitButton.Enabled = false;

                // Close the form or show a completion message
                MessageBox.Show("You have answered all questions.", "Exam Completed", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while submitting your answers: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


    }
}
