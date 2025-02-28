namespace Examination_System.Presentation
{
    partial class frmTeacherProfile
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            button1 = new Button();
            btn_addexam = new Button();
            button3 = new Button();
            btn_addquestion = new Button();
            btn_examsreport = new Button();
            btn_mngstudents = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(12, 12);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 0;
            button1.Text = "back";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // btn_addexam
            // 
            btn_addexam.Location = new Point(12, 58);
            btn_addexam.Name = "btn_addexam";
            btn_addexam.Size = new Size(110, 23);
            btn_addexam.TabIndex = 1;
            btn_addexam.Text = "Add Exam";
            btn_addexam.UseVisualStyleBackColor = true;
            btn_addexam.Click += btn_addexam_Click;
            // 
            // button3
            // 
            button3.Location = new Point(12, 168);
            button3.Name = "button3";
            button3.Size = new Size(75, 23);
            button3.TabIndex = 2;
            button3.Text = "logout";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // btn_addquestion
            // 
            btn_addquestion.Location = new Point(12, 116);
            btn_addquestion.Name = "btn_addquestion";
            btn_addquestion.Size = new Size(110, 23);
            btn_addquestion.TabIndex = 3;
            btn_addquestion.Text = "Add Question";
            btn_addquestion.UseVisualStyleBackColor = true;
            btn_addquestion.Click += btn_addquestion_Click;
            // 
            // btn_examsreport
            // 
            btn_examsreport.Location = new Point(147, 58);
            btn_examsreport.Name = "btn_examsreport";
            btn_examsreport.Size = new Size(157, 23);
            btn_examsreport.TabIndex = 4;
            btn_examsreport.Text = "Exams Report";
            btn_examsreport.UseVisualStyleBackColor = true;
            btn_examsreport.Click += btn_studentsreport_Click;
            // 
            // btn_mngstudents
            // 
            btn_mngstudents.Location = new Point(147, 116);
            btn_mngstudents.Name = "btn_mngstudents";
            btn_mngstudents.Size = new Size(157, 23);
            btn_mngstudents.TabIndex = 5;
            btn_mngstudents.Text = "Manage Students";
            btn_mngstudents.UseVisualStyleBackColor = true;
            btn_mngstudents.Click += btn_mngstudents_Click;
            // 
            // frmTeacherProfile
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btn_mngstudents);
            Controls.Add(btn_examsreport);
            Controls.Add(btn_addquestion);
            Controls.Add(button3);
            Controls.Add(btn_addexam);
            Controls.Add(button1);
            Name = "frmTeacherProfile";
            Text = "frmTeacherProfile";
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private Button btn_addexam;
        private Button button3;
        private Button btn_addquestion;
        private Button btn_examsreport;
        private Button btn_mngstudents;
    }
}