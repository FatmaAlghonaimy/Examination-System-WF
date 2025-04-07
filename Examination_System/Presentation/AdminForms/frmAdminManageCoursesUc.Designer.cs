namespace Examination_System.Presentation.AdminForms
{
    partial class frmAdminManageCoursesUc
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
            dgv_courses = new DataGridView();
            customPanel1 = new CustomControls.CustomPanel();
            label1 = new Label();
            label2 = new Label();
            tx_coursename = new CustomControls.CustomTextBox();
            btn_newstudent = new CustomControls.CustomButton();
            com_teachers = new CustomControls.CustomComboBox();
            ((System.ComponentModel.ISupportInitialize)dgv_courses).BeginInit();
            customPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // dgv_courses
            // 
            dgv_courses.AllowUserToAddRows = false;
            dgv_courses.AllowUserToDeleteRows = false;
            dgv_courses.AllowUserToResizeColumns = false;
            dgv_courses.AllowUserToResizeRows = false;
            dgv_courses.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.ColumnHeader;
            dgv_courses.BackgroundColor = Color.White;
            dgv_courses.BorderStyle = BorderStyle.None;
            dgv_courses.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = Color.Black;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle4.ForeColor = Color.FromArgb(235, 230, 255);
            dataGridViewCellStyle4.Padding = new Padding(15);
            dataGridViewCellStyle4.SelectionBackColor = Color.Black;
            dataGridViewCellStyle4.SelectionForeColor = Color.FromArgb(235, 230, 255);
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            dgv_courses.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dgv_courses.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = SystemColors.Window;
            dataGridViewCellStyle5.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle5.ForeColor = Color.Black;
            dataGridViewCellStyle5.SelectionBackColor = SystemColors.GradientActiveCaption;
            dataGridViewCellStyle5.SelectionForeColor = Color.Black;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.False;
            dgv_courses.DefaultCellStyle = dataGridViewCellStyle5;
            dgv_courses.Dock = DockStyle.Fill;
            dgv_courses.EnableHeadersVisualStyles = false;
            dgv_courses.Location = new Point(0, 0);
            dgv_courses.Name = "dgv_courses";
            dgv_courses.ReadOnly = true;
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = SystemColors.Control;
            dataGridViewCellStyle6.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle6.ForeColor = Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.True;
            dgv_courses.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            dgv_courses.RowHeadersVisible = false;
            dgv_courses.RowHeadersWidth = 25;
            dgv_courses.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv_courses.Size = new Size(813, 455);
            dgv_courses.TabIndex = 0;
            dgv_courses.CellClick += dgv_courses_CellContentClick;
            // 
            // customPanel1
            // 
            customPanel1.AutoSize = true;
            customPanel1.BackColor = Color.Black;
            customPanel1.BorderColor = Color.Black;
            customPanel1.BorderRadius = 30;
            customPanel1.BorderSize = 2;
            customPanel1.Controls.Add(dgv_courses);
            customPanel1.ForeColor = Color.Black;
            customPanel1.GradientBottomColor = Color.CadetBlue;
            customPanel1.GradientTopColor = Color.DodgerBlue;
            customPanel1.GrediantAngle = 90F;
            customPanel1.Location = new Point(20, 65);
            customPanel1.Name = "customPanel1";
            customPanel1.Padding = new Padding(0, 0, 0, 10);
            customPanel1.Size = new Size(813, 465);
            customPanel1.TabIndex = 16;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(20, 29);
            label1.Name = "label1";
            label1.Size = new Size(59, 21);
            label1.TabIndex = 18;
            label1.Text = "Course";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(338, 30);
            label2.Name = "label2";
            label2.Size = new Size(69, 21);
            label2.TabIndex = 19;
            label2.Text = "Teachers";
            // 
            // tx_coursename
            // 
            tx_coursename.BackColor = SystemColors.Window;
            tx_coursename.BorderColor = Color.MediumSlateBlue;
            tx_coursename.BorderFocusColor = Color.HotPink;
            tx_coursename.BorderRadius = 25;
            tx_coursename.BorderSize = 2;
            tx_coursename.Font = new Font("Segoe UI", 9.5F);
            tx_coursename.ForeColor = Color.DimGray;
            tx_coursename.IsFocus = false;
            tx_coursename.IsPlaceHolder = false;
            tx_coursename.Location = new Point(95, 23);
            tx_coursename.Multiline = false;
            tx_coursename.Name = "tx_coursename";
            tx_coursename.Padding = new Padding(12, 7, 12, 7);
            tx_coursename.PasswordChar = false;
            tx_coursename.PlaceHolderColor = Color.DarkGray;
            tx_coursename.PlaceHolderText = "";
            tx_coursename.Size = new Size(204, 32);
            tx_coursename.TabIndex = 21;
            tx_coursename.UnderLine = false;
            tx_coursename._TextChanged += this.tx_coursename_TextChanged;
            // 
            // btn_newstudent
            // 
            btn_newstudent.BackColor = Color.MediumSlateBlue;
            btn_newstudent.BackgroundColor = Color.MediumSlateBlue;
            btn_newstudent.BorderColor = Color.Black;
            btn_newstudent.BorderRadius = 30;
            btn_newstudent.BorderSize = 0;
            btn_newstudent.FlatAppearance.BorderSize = 0;
            btn_newstudent.FlatStyle = FlatStyle.Flat;
            btn_newstudent.ForeColor = Color.White;
            btn_newstudent.Location = new Point(683, 25);
            btn_newstudent.Name = "btn_newstudent";
            btn_newstudent.Size = new Size(150, 32);
            btn_newstudent.TabIndex = 22;
            btn_newstudent.Text = "Create New Course";
            btn_newstudent.TextColor = Color.White;
            btn_newstudent.UseVisualStyleBackColor = false;
            btn_newstudent.Click += this.btn_newstudent_Click;
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
            com_teachers.Location = new Point(413, 23);
            com_teachers.MinimumSize = new Size(200, 30);
            com_teachers.Name = "com_teachers";
            com_teachers.Padding = new Padding(2);
            com_teachers.SelectedValue = null;
            com_teachers.Size = new Size(200, 30);
            com_teachers.TabIndex = 23;
            com_teachers.Texts = "";
            com_teachers.OnSelectedIndexChanged += this.com_teachers_SelectedIndexChanged;
            // 
            // frmAdminManageCoursesUc
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(com_teachers);
            Controls.Add(btn_newstudent);
            Controls.Add(tx_coursename);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(customPanel1);
            Cursor = Cursors.Hand;
            MaximumSize = new Size(863, 562);
            MinimumSize = new Size(863, 562);
            Name = "frmAdminManageCoursesUc";
            Size = new Size(863, 562);
            ((System.ComponentModel.ISupportInitialize)dgv_courses).EndInit();
            customPanel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private DataGridView dgv_courses;
        private CustomControls.CustomPanel customPanel1;
        private Label label1;
        private Label label2;
        private CustomControls.CustomTextBox tx_coursename;
        private CustomControls.CustomButton btn_newstudent;
        private CustomControls.CustomComboBox com_teachers;
    }
}
