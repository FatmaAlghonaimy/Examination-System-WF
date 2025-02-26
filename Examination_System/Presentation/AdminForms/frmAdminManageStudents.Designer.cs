namespace Examination_System.Presentation
{
    partial class frmAdminManageStudents
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
            label2 = new Label();
            com_courses = new ComboBox();
            dgv_students = new DataGridView();
            button1 = new Button();
            flowLayoutPanel1 = new FlowLayoutPanel();
            btn_newstudent = new Button();
            label1 = new Label();
            com_teachers = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dgv_students).BeginInit();
            flowLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(291, 9);
            label2.Name = "label2";
            label2.Size = new Size(66, 21);
            label2.TabIndex = 5;
            label2.Text = "Courses";
            // 
            // com_courses
            // 
            com_courses.FormattingEnabled = true;
            com_courses.Location = new Point(363, 12);
            com_courses.Name = "com_courses";
            com_courses.Size = new Size(121, 23);
            com_courses.TabIndex = 2;
            com_courses.SelectedIndexChanged += FilterStudents;
            // 
            // dgv_students
            // 
            dgv_students.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_students.Location = new Point(3, 3);
            dgv_students.Name = "dgv_students";
            dgv_students.RowHeadersWidth = 51;
            dgv_students.Size = new Size(1222, 628);
            dgv_students.TabIndex = 1;
            dgv_students.CellClick += HandleEDD_Buttons_Click;
            dgv_students.CellContentClick += dataGridView1_CellContentClick;
            // 
            // button1
            // 
            button1.Location = new Point(8, 12);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 0;
            button1.Text = "back";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.AutoScroll = true;
            flowLayoutPanel1.Controls.Add(dgv_students);
            flowLayoutPanel1.Location = new Point(1, 67);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(1225, 683);
            flowLayoutPanel1.TabIndex = 6;
            // 
            // btn_newstudent
            // 
            btn_newstudent.Location = new Point(512, 11);
            btn_newstudent.Name = "btn_newstudent";
            btn_newstudent.Size = new Size(181, 23);
            btn_newstudent.TabIndex = 7;
            btn_newstudent.Text = "create new student";
            btn_newstudent.UseVisualStyleBackColor = true;
            btn_newstudent.Click += btn_newstudent_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(89, 9);
            label1.Name = "label1";
            label1.Size = new Size(69, 21);
            label1.TabIndex = 4;
            label1.Text = "Teachers";
            // 
            // com_teachers
            // 
            com_teachers.FormattingEnabled = true;
            com_teachers.Location = new Point(164, 12);
            com_teachers.Name = "com_teachers";
            com_teachers.Size = new Size(121, 23);
            com_teachers.TabIndex = 3;
            com_teachers.SelectedIndexChanged += FilterStudents;
            // 
            // frmAdminManageStudents
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1124, 526);
            Controls.Add(btn_newstudent);
            Controls.Add(button1);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(label1);
            Controls.Add(com_courses);
            Controls.Add(com_teachers);
            Controls.Add(label2);
            Name = "frmAdminManageStudents";
            Text = "frmAdminManageStudents";
            ((System.ComponentModel.ISupportInitialize)dgv_students).EndInit();
            flowLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private ComboBox com_courses;
        private DataGridView dgv_students;
        private Button button1;
        private FlowLayoutPanel flowLayoutPanel1;
        private Button btn_newstudent;
        private Label label1;
        private ComboBox com_teachers;
    }
}