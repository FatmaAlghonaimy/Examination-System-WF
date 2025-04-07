namespace Examination_System.Presentation.AdminForms
{
    partial class frmAdminStudentsReportUc
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
            dgv_students = new DataGridView();
            customPanel1 = new CustomControls.CustomPanel();
            label2 = new Label();
            label1 = new Label();
            com_courses = new CustomControls.CustomComboBox();
            com_teachers = new CustomControls.CustomComboBox();
            ((System.ComponentModel.ISupportInitialize)dgv_students).BeginInit();
            customPanel1.SuspendLayout();
            SuspendLayout();
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
            dgv_students.CellClick += Handle_View_Courses;
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
            customPanel1.Location = new Point(30, 73);
            customPanel1.Name = "customPanel1";
            customPanel1.Padding = new Padding(0, 0, 0, 10);
            customPanel1.Size = new Size(802, 462);
            customPanel1.TabIndex = 22;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Sitka Text", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(451, 21);
            label2.Name = "label2";
            label2.Size = new Size(76, 23);
            label2.TabIndex = 28;
            label2.Text = "Teachers";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Sitka Text", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(30, 24);
            label1.Name = "label1";
            label1.Size = new Size(68, 23);
            label1.TabIndex = 26;
            label1.Text = "Courses";
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
            com_courses.Location = new Point(128, 20);
            com_courses.MinimumSize = new Size(200, 30);
            com_courses.Name = "com_courses";
            com_courses.Padding = new Padding(2);
            com_courses.SelectedValue = null;
            com_courses.Size = new Size(235, 30);
            com_courses.TabIndex = 29;
            com_courses.Texts = "";
            com_courses.OnSelectedIndexChanged += this.FiltersChanged;
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
            com_teachers.Location = new Point(550, 17);
            com_teachers.MinimumSize = new Size(200, 30);
            com_teachers.Name = "com_teachers";
            com_teachers.Padding = new Padding(2);
            com_teachers.SelectedValue = null;
            com_teachers.Size = new Size(235, 30);
            com_teachers.TabIndex = 30;
            com_teachers.Texts = "";
            com_teachers.OnSelectedIndexChanged += this.FiltersChanged;
            // 
            // frmAdminStudentsReportUc
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(com_teachers);
            Controls.Add(com_courses);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(customPanel1);
            MaximumSize = new Size(863, 562);
            MinimumSize = new Size(863, 562);
            Name = "frmAdminStudentsReportUc";
            Size = new Size(863, 562);
            Load += frmAdminStudentsReport_Load;
            ((System.ComponentModel.ISupportInitialize)dgv_students).EndInit();
            customPanel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private DataGridView dgv_students;
        private CustomControls.CustomPanel customPanel1;
        private Label label2;
        private Label label1;
        private CustomControls.CustomComboBox com_courses;
        private CustomControls.CustomComboBox com_teachers;
    }
}
