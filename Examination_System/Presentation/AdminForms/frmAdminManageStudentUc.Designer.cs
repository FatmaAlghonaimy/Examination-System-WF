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
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            label1 = new Label();
            com_courses = new ComboBox();
            label2 = new Label();
            com_teachers = new ComboBox();
            dgv_students = new DataGridView();
            customPanel1 = new CustomControls.CustomPanel();
            btn_newstudent = new Button();
            ((System.ComponentModel.ISupportInitialize)dgv_students).BeginInit();
            customPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(92, 21);
            label1.Name = "label1";
            label1.Size = new Size(69, 21);
            label1.TabIndex = 11;
            label1.Text = "Teachers";
            // 
            // com_courses
            // 
            com_courses.FormattingEnabled = true;
            com_courses.Location = new Point(361, 19);
            com_courses.Name = "com_courses";
            com_courses.Size = new Size(126, 23);
            com_courses.TabIndex = 9;
            com_courses.SelectedIndexChanged += com_teachers_course_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(294, 21);
            label2.Name = "label2";
            label2.Size = new Size(66, 21);
            label2.TabIndex = 12;
            label2.Text = "Courses";
            // 
            // com_teachers
            // 
            com_teachers.FormattingEnabled = true;
            com_teachers.Location = new Point(167, 19);
            com_teachers.Name = "com_teachers";
            com_teachers.Size = new Size(121, 23);
            com_teachers.TabIndex = 15;
            com_teachers.SelectedIndexChanged += com_teachers_course_SelectedIndexChanged;
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
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = Color.Black;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle4.ForeColor = Color.FromArgb(235, 230, 255);
            dataGridViewCellStyle4.Padding = new Padding(15);
            dataGridViewCellStyle4.SelectionBackColor = Color.Black;
            dataGridViewCellStyle4.SelectionForeColor = Color.FromArgb(235, 230, 255);
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            dgv_students.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dgv_students.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = SystemColors.Window;
            dataGridViewCellStyle5.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle5.ForeColor = Color.Black;
            dataGridViewCellStyle5.SelectionBackColor = SystemColors.GradientActiveCaption;
            dataGridViewCellStyle5.SelectionForeColor = Color.Black;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.False;
            dgv_students.DefaultCellStyle = dataGridViewCellStyle5;
            dgv_students.Dock = DockStyle.Fill;
            dgv_students.EnableHeadersVisualStyles = false;
            dgv_students.Location = new Point(0, 0);
            dgv_students.Name = "dgv_students";
            dgv_students.ReadOnly = true;
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = SystemColors.Control;
            dataGridViewCellStyle6.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle6.ForeColor = Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.True;
            dgv_students.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            dgv_students.RowHeadersVisible = false;
            dgv_students.RowHeadersWidth = 25;
            dgv_students.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv_students.Size = new Size(802, 452);
            dgv_students.TabIndex = 0;
            dgv_students.CellClick += HandleEDD_Buttons_Click;
            // 
            // customPanel1
            // 
            customPanel1.AutoSize = true;
            customPanel1.BackColor = Color.Black;
            customPanel1.BorderRadius = 30;
            customPanel1.Controls.Add(dgv_students);
            customPanel1.ForeColor = Color.Black;
            customPanel1.GradientBottomColor = Color.CadetBlue;
            customPanel1.GradientTopColor = Color.DodgerBlue;
            customPanel1.GrediantAngle = 90F;
            customPanel1.Location = new Point(29, 65);
            customPanel1.Name = "customPanel1";
            customPanel1.Padding = new Padding(0, 0, 0, 10);
            customPanel1.Size = new Size(802, 462);
            customPanel1.TabIndex = 16;
            // 
            // btn_newstudent
            // 
            btn_newstudent.Location = new Point(521, 19);
            btn_newstudent.Name = "btn_newstudent";
            btn_newstudent.Size = new Size(186, 23);
            btn_newstudent.TabIndex = 13;
            btn_newstudent.Text = "create new student";
            btn_newstudent.UseVisualStyleBackColor = true;
            btn_newstudent.Click += btn_newstudent_Click;
            // 
            // frmAdminManageStudentUc
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(customPanel1);
            Controls.Add(com_teachers);
            Controls.Add(btn_newstudent);
            Controls.Add(label1);
            Controls.Add(com_courses);
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
        private ComboBox com_courses;
        private Label label2;
        private ComboBox com_teachers;
        private DataGridView dgv_students;
        private CustomControls.CustomPanel customPanel1;
        private Button btn_newstudent;
    }
}
