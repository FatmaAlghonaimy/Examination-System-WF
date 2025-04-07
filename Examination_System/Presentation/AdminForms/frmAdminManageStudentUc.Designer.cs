namespace Examination_System.Presentation.AdminForms
{
    partial class frmAdminManageStudentUc
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle9 = new DataGridViewCellStyle();
            label1 = new Label();
            label2 = new Label();
            dgv_students = new DataGridView();
            customPanel1 = new CustomControls.CustomPanel();
            btn_newstudent = new CustomControls.CustomButton();
            com_teachers = new CustomControls.CustomComboBox();
            com_courses = new CustomControls.CustomComboBox();
            ((System.ComponentModel.ISupportInitialize)dgv_students).BeginInit();
            customPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(26, 25);
            label1.Name = "label1";
            label1.Size = new Size(69, 21);
            label1.TabIndex = 11;
            label1.Text = "Teachers";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(343, 26);
            label2.Name = "label2";
            label2.Size = new Size(66, 21);
            label2.TabIndex = 12;
            label2.Text = "Courses";
            // 
            // dgv_students
            // 
            dgv_students.AllowUserToAddRows = false;
            dgv_students.AllowUserToDeleteRows = false;
            dgv_students.AllowUserToResizeColumns = false;
            dgv_students.AllowUserToResizeRows = false;
            dgv_students.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.ColumnHeader;
            dgv_students.BackgroundColor = Color.White;
            dgv_students.BorderStyle = BorderStyle.None;
            dgv_students.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = Color.Black;
            dataGridViewCellStyle7.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle7.ForeColor = Color.FromArgb(235, 230, 255);
            dataGridViewCellStyle7.Padding = new Padding(15);
            dataGridViewCellStyle7.SelectionBackColor = Color.Black;
            dataGridViewCellStyle7.SelectionForeColor = Color.FromArgb(235, 230, 255);
            dataGridViewCellStyle7.WrapMode = DataGridViewTriState.True;
            dgv_students.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            dgv_students.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.BackColor = SystemColors.Window;
            dataGridViewCellStyle8.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle8.ForeColor = Color.Black;
            dataGridViewCellStyle8.SelectionBackColor = SystemColors.GradientActiveCaption;
            dataGridViewCellStyle8.SelectionForeColor = Color.Black;
            dataGridViewCellStyle8.WrapMode = DataGridViewTriState.False;
            dgv_students.DefaultCellStyle = dataGridViewCellStyle8;
            dgv_students.Dock = DockStyle.Fill;
            dgv_students.EnableHeadersVisualStyles = false;
            dgv_students.Location = new Point(0, 0);
            dgv_students.Name = "dgv_students";
            dgv_students.ReadOnly = true;
            dataGridViewCellStyle9.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = SystemColors.Control;
            dataGridViewCellStyle9.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle9.ForeColor = Color.Black;
            dataGridViewCellStyle9.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = DataGridViewTriState.True;
            dgv_students.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            dgv_students.RowHeadersVisible = false;
            dgv_students.RowHeadersWidth = 25;
            dgv_students.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv_students.Size = new Size(807, 455);
            dgv_students.TabIndex = 0;
            dgv_students.CellClick += HandleEDD_Buttons_Click;
            dgv_students.CellContentClick += dgv_students_CellContentClick;
            // 
            // customPanel1
            // 
            customPanel1.AutoSize = true;
            customPanel1.BackColor = Color.Black;
            customPanel1.BorderColor = Color.Black;
            customPanel1.BorderRadius = 30;
            customPanel1.BorderSize = 2;
            customPanel1.Controls.Add(dgv_students);
            customPanel1.ForeColor = Color.Black;
            customPanel1.GradientBottomColor = Color.CadetBlue;
            customPanel1.GradientTopColor = Color.DodgerBlue;
            customPanel1.GrediantAngle = 90F;
            customPanel1.Location = new Point(28, 65);
            customPanel1.Name = "customPanel1";
            customPanel1.Padding = new Padding(0, 0, 0, 10);
            customPanel1.Size = new Size(807, 465);
            customPanel1.TabIndex = 16;
            // 
            // btn_newstudent
            // 
            btn_newstudent.BackColor = Color.Transparent;
            btn_newstudent.BackgroundColor = Color.Transparent;
            btn_newstudent.BorderColor = Color.DarkOrchid;
            btn_newstudent.BorderRadius = 30;
            btn_newstudent.BorderSize = 2;
            btn_newstudent.Cursor = Cursors.Hand;
            btn_newstudent.FlatAppearance.BorderSize = 0;
            btn_newstudent.FlatStyle = FlatStyle.Flat;
            btn_newstudent.ForeColor = Color.Black;
            btn_newstudent.Location = new Point(663, 21);
            btn_newstudent.Name = "btn_newstudent";
            btn_newstudent.Size = new Size(150, 31);
            btn_newstudent.TabIndex = 17;
            btn_newstudent.Text = "Create new Student";
            btn_newstudent.TextColor = Color.Black;
            btn_newstudent.UseVisualStyleBackColor = false;
            btn_newstudent.Click += btn_newstudent_Click;
            btn_newstudent.MouseEnter += btn_newstudent_MouseEnter;
            btn_newstudent.MouseLeave += btn_newstudent_MouseLeave;
            // 
            // com_teachers
            // 
            com_teachers.BackColor = Color.WhiteSmoke;
            com_teachers.BorderColor = Color.DarkOrchid;
            com_teachers.BorderRadius = 0;
            com_teachers.BorderSize = 2;
            com_teachers.DropDownStyle = ComboBoxStyle.DropDown;
            com_teachers.Font = new Font("Segoe UI", 10F);
            com_teachers.ForeColor = Color.DimGray;
            com_teachers.IconColor = Color.MediumSlateBlue;
            com_teachers.ListBackColor = Color.FromArgb(230, 228, 245);
            com_teachers.ListTextColor = Color.DimGray;
            com_teachers.Location = new Point(106, 22);
            com_teachers.MinimumSize = new Size(200, 30);
            com_teachers.Name = "com_teachers";
            com_teachers.Padding = new Padding(2);
            com_teachers.SelectedValue = null;
            com_teachers.Size = new Size(200, 30);
            com_teachers.TabIndex = 19;
            com_teachers.Texts = "";
            com_teachers.OnSelectedIndexChanged += com_teachers_course_SelectedIndexChanged;
            // 
            // com_courses
            // 
            com_courses.BackColor = Color.WhiteSmoke;
            com_courses.BorderColor = Color.DarkOrchid;
            com_courses.BorderRadius = 0;
            com_courses.BorderSize = 2;
            com_courses.DropDownStyle = ComboBoxStyle.DropDown;
            com_courses.Font = new Font("Segoe UI", 10F);
            com_courses.ForeColor = Color.DimGray;
            com_courses.IconColor = Color.MediumSlateBlue;
            com_courses.ListBackColor = Color.FromArgb(230, 228, 245);
            com_courses.ListTextColor = Color.DimGray;
            com_courses.Location = new Point(411, 22);
            com_courses.MinimumSize = new Size(200, 30);
            com_courses.Name = "com_courses";
            com_courses.Padding = new Padding(2);
            com_courses.SelectedValue = null;
            com_courses.Size = new Size(200, 30);
            com_courses.TabIndex = 20;
            com_courses.Texts = "";
            com_courses.OnSelectedIndexChanged += com_teachers_course_SelectedIndexChanged;
            // 
            // frmAdminManageStudentUc
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(com_courses);
            Controls.Add(com_teachers);
            Controls.Add(btn_newstudent);
            Controls.Add(customPanel1);
            Controls.Add(label1);
            Controls.Add(label2);
            MaximumSize = new Size(863, 562);
            MinimumSize = new Size(863, 562);
            Name = "frmAdminManageStudentUc";
            Size = new Size(863, 562);
            ((System.ComponentModel.ISupportInitialize)dgv_students).EndInit();
            customPanel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private Label label2;
        private DataGridView dgv_students;
        private CustomControls.CustomPanel customPanel1;
        private CustomControls.CustomButton btn_newstudent;
        private CustomControls.CustomComboBox com_teachers;
        private CustomControls.CustomComboBox com_courses;
    }
}
