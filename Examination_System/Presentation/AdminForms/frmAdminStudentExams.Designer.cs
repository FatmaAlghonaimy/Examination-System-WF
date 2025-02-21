﻿namespace Examination_System.Presentation.AdminForms
{
    partial class frmAdminStudentExams
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
            panel1 = new Panel();
            dgv_student_exams = new DataGridView();
            button2 = new Button();
            button1 = new Button();
            btn_back = new Button();
            label2 = new Label();
            com_teachers = new ComboBox();
            label1 = new Label();
            com_courses = new ComboBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_student_exams).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.AutoScroll = true;
            panel1.AutoSize = true;
            panel1.Controls.Add(dgv_student_exams);
            panel1.Location = new Point(12, 72);
            panel1.Name = "panel1";
            panel1.Size = new Size(1073, 516);
            panel1.TabIndex = 16;
            // 
            // dgv_student_exams
            // 
            dgv_student_exams.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_student_exams.Dock = DockStyle.Fill;
            dgv_student_exams.Location = new Point(0, 0);
            dgv_student_exams.Name = "dgv_student_exams";
            dgv_student_exams.Size = new Size(1073, 516);
            dgv_student_exams.TabIndex = 0;
            dgv_student_exams.CellClick += Handle_Show_Exam;
            // 
            // button2
            // 
            button2.Location = new Point(891, 22);
            button2.Name = "button2";
            button2.Size = new Size(147, 23);
            button2.TabIndex = 23;
            button2.Text = "Generate PDF";
            button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(652, 20);
            button1.Name = "button1";
            button1.Size = new Size(177, 23);
            button1.TabIndex = 22;
            button1.Text = "Generate Excel File";
            button1.UseVisualStyleBackColor = true;
            // 
            // btn_back
            // 
            btn_back.Location = new Point(50, 16);
            btn_back.Name = "btn_back";
            btn_back.Size = new Size(75, 23);
            btn_back.TabIndex = 21;
            btn_back.Text = "Back";
            btn_back.UseVisualStyleBackColor = true;
            btn_back.Click += btn_back_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Sitka Text", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(387, 20);
            label2.Name = "label2";
            label2.Size = new Size(76, 23);
            label2.TabIndex = 20;
            label2.Text = "Teachers";
            // 
            // com_teachers
            // 
            com_teachers.FormattingEnabled = true;
            com_teachers.Location = new Point(478, 20);
            com_teachers.Name = "com_teachers";
            com_teachers.Size = new Size(121, 23);
            com_teachers.TabIndex = 19;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Sitka Text", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(155, 17);
            label1.Name = "label1";
            label1.Size = new Size(68, 23);
            label1.TabIndex = 18;
            label1.Text = "Courses";
            // 
            // com_courses
            // 
            com_courses.FormattingEnabled = true;
            com_courses.Location = new Point(246, 17);
            com_courses.Name = "com_courses";
            com_courses.Size = new Size(121, 23);
            com_courses.TabIndex = 17;
            // 
            // frmAdminStudentExams
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1097, 605);
            Controls.Add(panel1);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(btn_back);
            Controls.Add(label2);
            Controls.Add(com_teachers);
            Controls.Add(label1);
            Controls.Add(com_courses);
            MaximizeBox = false;
            MaximumSize = new Size(1113, 644);
            MinimumSize = new Size(1113, 644);
            Name = "frmAdminStudentExams";
            Text = "frmAdminStudentExams";
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgv_student_exams).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private DataGridView dgv_student_exams;
        private Button button2;
        private Button button1;
        private Button btn_back;
        private Label label2;
        private ComboBox com_teachers;
        private Label label1;
        private ComboBox com_courses;
    }
}