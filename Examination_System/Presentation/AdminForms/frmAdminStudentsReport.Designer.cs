namespace Examination_System.Presentation.AdminForms
{
    partial class frmAdminStudentsReport
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
            dgv_students = new DataGridView();
            com_courses = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            com_teachers = new ComboBox();
            btn_back = new Button();
            button1 = new Button();
            button2 = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_students).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.AutoScroll = true;
            panel1.AutoSize = true;
            panel1.Controls.Add(dgv_students);
            panel1.Location = new Point(-65, 87);
            panel1.Name = "panel1";
            panel1.Size = new Size(1150, 506);
            panel1.TabIndex = 0;
            // 
            // dgv_students
            // 
            dgv_students.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_students.Dock = DockStyle.Fill;
            dgv_students.Location = new Point(0, 0);
            dgv_students.Name = "dgv_students";
            dgv_students.Size = new Size(1150, 506);
            dgv_students.TabIndex = 0;
            dgv_students.CellClick += Handle_View_Courses;
            // 
            // com_courses
            // 
            com_courses.FormattingEnabled = true;
            com_courses.Location = new Point(208, 31);
            com_courses.Name = "com_courses";
            com_courses.Size = new Size(121, 23);
            com_courses.TabIndex = 1;
            com_courses.SelectedIndexChanged += FiltersChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Sitka Text", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(117, 31);
            label1.Name = "label1";
            label1.Size = new Size(68, 23);
            label1.TabIndex = 2;
            label1.Text = "Courses";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Sitka Text", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(349, 34);
            label2.Name = "label2";
            label2.Size = new Size(76, 23);
            label2.TabIndex = 4;
            label2.Text = "Teachers";
            // 
            // com_teachers
            // 
            com_teachers.FormattingEnabled = true;
            com_teachers.Location = new Point(440, 34);
            com_teachers.Name = "com_teachers";
            com_teachers.Size = new Size(121, 23);
            com_teachers.TabIndex = 3;
            com_teachers.SelectedIndexChanged += FiltersChanged;
            // 
            // btn_back
            // 
            btn_back.Location = new Point(12, 30);
            btn_back.Name = "btn_back";
            btn_back.Size = new Size(75, 23);
            btn_back.TabIndex = 5;
            btn_back.Text = "Back";
            btn_back.UseVisualStyleBackColor = true;
            btn_back.Click += btn_back_Click;
            // 
            // button1
            // 
            button1.Location = new Point(614, 34);
            button1.Name = "button1";
            button1.Size = new Size(177, 23);
            button1.TabIndex = 6;
            button1.Text = "Generate Excel File";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(853, 36);
            button2.Name = "button2";
            button2.Size = new Size(147, 23);
            button2.TabIndex = 7;
            button2.Text = "Generate PDF";
            button2.UseVisualStyleBackColor = true;
            // 
            // frmAdminStudentsReport
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1097, 605);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(btn_back);
            Controls.Add(label2);
            Controls.Add(com_teachers);
            Controls.Add(label1);
            Controls.Add(com_courses);
            Controls.Add(panel1);
            MaximizeBox = false;
            MaximumSize = new Size(1113, 644);
            MinimumSize = new Size(1113, 644);
            Name = "frmAdminStudentsReport";
            Text = "frmAdminStudentsReport";
            Load += frmAdminStudentsReport_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgv_students).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private DataGridView dgv_students;
        private ComboBox com_courses;
        private Label label1;
        private Label label2;
        private ComboBox com_teachers;
        private Button btn_back;
        private Button button1;
        private Button button2;
    }
}