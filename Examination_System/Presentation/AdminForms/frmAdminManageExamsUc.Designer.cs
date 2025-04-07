namespace Examination_System.Presentation.AdminForms
{
    partial class frmAdminManageExamsUc
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
            lbl_ExamTeacher = new Label();
            lbl_NoStud = new Label();
            dtp_FilterByEndTime = new DateTimePicker();
            dtp_FilterByStartTime = new DateTimePicker();
            lbl_SearchByType = new Label();
            chb_Parctical = new CheckBox();
            chb_Final = new CheckBox();
            customPanel1 = new CustomControls.CustomPanel();
            dgv_Exam = new DataGridView();
            button1 = new CustomControls.CustomButton();
            btn_Multi_Filters = new CustomControls.CustomButton();
            btn_SearchByName = new CustomControls.CustomButton();
            btn_Report = new CustomControls.CustomButton();
            cmb_SearchByCourse = new CustomControls.CustomComboBox();
            customPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_Exam).BeginInit();
            SuspendLayout();
            // 
            // lbl_ExamTeacher
            // 
            lbl_ExamTeacher.AutoSize = true;
            lbl_ExamTeacher.Location = new Point(25, 120);
            lbl_ExamTeacher.Margin = new Padding(2, 0, 2, 0);
            lbl_ExamTeacher.Name = "lbl_ExamTeacher";
            lbl_ExamTeacher.Size = new Size(47, 15);
            lbl_ExamTeacher.TabIndex = 26;
            lbl_ExamTeacher.Text = "Teacher";
            // 
            // lbl_NoStud
            // 
            lbl_NoStud.AutoSize = true;
            lbl_NoStud.Location = new Point(25, 90);
            lbl_NoStud.Margin = new Padding(2, 0, 2, 0);
            lbl_NoStud.Name = "lbl_NoStud";
            lbl_NoStud.Size = new Size(109, 15);
            lbl_NoStud.TabIndex = 25;
            lbl_NoStud.Text = "Number of Student";
            // 
            // dtp_FilterByEndTime
            // 
            dtp_FilterByEndTime.Location = new Point(217, 126);
            dtp_FilterByEndTime.Margin = new Padding(2);
            dtp_FilterByEndTime.Name = "dtp_FilterByEndTime";
            dtp_FilterByEndTime.ShowCheckBox = true;
            dtp_FilterByEndTime.Size = new Size(211, 23);
            dtp_FilterByEndTime.TabIndex = 23;
            // 
            // dtp_FilterByStartTime
            // 
            dtp_FilterByStartTime.Location = new Point(217, 90);
            dtp_FilterByStartTime.Margin = new Padding(2);
            dtp_FilterByStartTime.Name = "dtp_FilterByStartTime";
            dtp_FilterByStartTime.ShowCheckBox = true;
            dtp_FilterByStartTime.Size = new Size(211, 23);
            dtp_FilterByStartTime.TabIndex = 22;
            // 
            // lbl_SearchByType
            // 
            lbl_SearchByType.AutoSize = true;
            lbl_SearchByType.Location = new Point(456, 90);
            lbl_SearchByType.Margin = new Padding(2, 0, 2, 0);
            lbl_SearchByType.Name = "lbl_SearchByType";
            lbl_SearchByType.Size = new Size(85, 15);
            lbl_SearchByType.TabIndex = 21;
            lbl_SearchByType.Text = "Search By Type";
            // 
            // chb_Parctical
            // 
            chb_Parctical.AutoSize = true;
            chb_Parctical.Location = new Point(545, 121);
            chb_Parctical.Margin = new Padding(2);
            chb_Parctical.Name = "chb_Parctical";
            chb_Parctical.Size = new Size(71, 19);
            chb_Parctical.TabIndex = 20;
            chb_Parctical.Text = "Practical";
            chb_Parctical.UseVisualStyleBackColor = true;
            chb_Parctical.CheckedChanged += chb_Parctical_CheckedChanged;
            // 
            // chb_Final
            // 
            chb_Final.AutoSize = true;
            chb_Final.Location = new Point(458, 121);
            chb_Final.Margin = new Padding(2);
            chb_Final.Name = "chb_Final";
            chb_Final.Size = new Size(83, 19);
            chb_Final.TabIndex = 19;
            chb_Final.Text = "Final Exam";
            chb_Final.UseVisualStyleBackColor = true;
            chb_Final.CheckedChanged += chb_Final_CheckedChanged;
            // 
            // customPanel1
            // 
            customPanel1.AutoSize = true;
            customPanel1.BackColor = Color.Black;
            customPanel1.BorderColor = Color.Black;
            customPanel1.BorderRadius = 30;
            customPanel1.BorderSize = 2;
            customPanel1.Controls.Add(dgv_Exam);
            customPanel1.ForeColor = Color.Black;
            customPanel1.GradientBottomColor = Color.CadetBlue;
            customPanel1.GradientTopColor = Color.DodgerBlue;
            customPanel1.GrediantAngle = 90F;
            customPanel1.Location = new Point(25, 175);
            customPanel1.Name = "customPanel1";
            customPanel1.Padding = new Padding(0, 0, 0, 10);
            customPanel1.Size = new Size(813, 325);
            customPanel1.TabIndex = 29;
            // 
            // dgv_Exam
            // 
            dgv_Exam.AllowUserToAddRows = false;
            dgv_Exam.AllowUserToDeleteRows = false;
            dgv_Exam.AllowUserToResizeColumns = false;
            dgv_Exam.AllowUserToResizeRows = false;
            dgv_Exam.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.ColumnHeader;
            dgv_Exam.BackgroundColor = Color.White;
            dgv_Exam.BorderStyle = BorderStyle.None;
            dgv_Exam.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = Color.Black;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle4.ForeColor = Color.FromArgb(235, 230, 255);
            dataGridViewCellStyle4.Padding = new Padding(15);
            dataGridViewCellStyle4.SelectionBackColor = Color.Black;
            dataGridViewCellStyle4.SelectionForeColor = Color.FromArgb(235, 230, 255);
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            dgv_Exam.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dgv_Exam.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = SystemColors.Window;
            dataGridViewCellStyle5.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle5.ForeColor = Color.Black;
            dataGridViewCellStyle5.SelectionBackColor = SystemColors.GradientActiveCaption;
            dataGridViewCellStyle5.SelectionForeColor = Color.Black;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.False;
            dgv_Exam.DefaultCellStyle = dataGridViewCellStyle5;
            dgv_Exam.Dock = DockStyle.Fill;
            dgv_Exam.EnableHeadersVisualStyles = false;
            dgv_Exam.Location = new Point(0, 0);
            dgv_Exam.Name = "dgv_Exam";
            dgv_Exam.ReadOnly = true;
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = SystemColors.Control;
            dataGridViewCellStyle6.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle6.ForeColor = Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.True;
            dgv_Exam.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            dgv_Exam.RowHeadersVisible = false;
            dgv_Exam.RowHeadersWidth = 25;
            dgv_Exam.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv_Exam.Size = new Size(813, 315);
            dgv_Exam.TabIndex = 0;
            dgv_Exam.CellClick += dgv_Exam_CellClick;
            // 
            // button1
            // 
            button1.BackColor = Color.DarkOrchid;
            button1.BackgroundColor = Color.DarkOrchid;
            button1.BorderColor = Color.Black;
            button1.BorderRadius = 30;
            button1.BorderSize = 0;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.ForeColor = Color.White;
            button1.Location = new Point(14, 37);
            button1.Name = "button1";
            button1.Size = new Size(187, 32);
            button1.TabIndex = 30;
            button1.Text = "Create New Exam";
            button1.TextColor = Color.White;
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // btn_Multi_Filters
            // 
            btn_Multi_Filters.BackColor = Color.DarkOrchid;
            btn_Multi_Filters.BackgroundColor = Color.DarkOrchid;
            btn_Multi_Filters.BorderColor = Color.Black;
            btn_Multi_Filters.BorderRadius = 30;
            btn_Multi_Filters.BorderSize = 0;
            btn_Multi_Filters.FlatAppearance.BorderSize = 0;
            btn_Multi_Filters.FlatStyle = FlatStyle.Flat;
            btn_Multi_Filters.ForeColor = Color.White;
            btn_Multi_Filters.Location = new Point(456, 37);
            btn_Multi_Filters.Name = "btn_Multi_Filters";
            btn_Multi_Filters.Size = new Size(150, 32);
            btn_Multi_Filters.TabIndex = 31;
            btn_Multi_Filters.Text = "Select and Filter";
            btn_Multi_Filters.TextColor = Color.White;
            btn_Multi_Filters.UseVisualStyleBackColor = false;
            btn_Multi_Filters.Click += btn_Multi_Filters_Click;
            // 
            // btn_SearchByName
            // 
            btn_SearchByName.BackColor = Color.DarkOrchid;
            btn_SearchByName.BackgroundColor = Color.DarkOrchid;
            btn_SearchByName.BorderColor = Color.Black;
            btn_SearchByName.BorderRadius = 30;
            btn_SearchByName.BorderSize = 0;
            btn_SearchByName.FlatAppearance.BorderSize = 0;
            btn_SearchByName.FlatStyle = FlatStyle.Flat;
            btn_SearchByName.ForeColor = Color.White;
            btn_SearchByName.Location = new Point(217, 37);
            btn_SearchByName.Name = "btn_SearchByName";
            btn_SearchByName.Size = new Size(211, 32);
            btn_SearchByName.TabIndex = 32;
            btn_SearchByName.Text = "Search By Date";
            btn_SearchByName.TextColor = Color.White;
            btn_SearchByName.UseVisualStyleBackColor = false;
            btn_SearchByName.Click += btn_SearchByName_Click;
            // 
            // btn_Report
            // 
            btn_Report.BackColor = Color.DarkOrchid;
            btn_Report.BackgroundColor = Color.DarkOrchid;
            btn_Report.BorderColor = Color.Black;
            btn_Report.BorderRadius = 30;
            btn_Report.BorderSize = 0;
            btn_Report.FlatAppearance.BorderSize = 0;
            btn_Report.FlatStyle = FlatStyle.Flat;
            btn_Report.ForeColor = Color.White;
            btn_Report.Location = new Point(632, 37);
            btn_Report.Name = "btn_Report";
            btn_Report.Size = new Size(206, 32);
            btn_Report.TabIndex = 33;
            btn_Report.Text = "Report";
            btn_Report.TextColor = Color.White;
            btn_Report.UseVisualStyleBackColor = false;
            btn_Report.Click += btn_Report_Click;
            // 
            // cmb_SearchByCourse
            // 
            cmb_SearchByCourse.BackColor = Color.WhiteSmoke;
            cmb_SearchByCourse.BorderColor = Color.DarkOrchid;
            cmb_SearchByCourse.BorderRadius = 0;
            cmb_SearchByCourse.BorderSize = 2;
            cmb_SearchByCourse.DropDownStyle = ComboBoxStyle.DropDown;
            cmb_SearchByCourse.Font = new Font("Segoe UI", 10F);
            cmb_SearchByCourse.ForeColor = Color.DimGray;
            cmb_SearchByCourse.IconColor = Color.MediumSlateBlue;
            cmb_SearchByCourse.ListBackColor = Color.FromArgb(230, 228, 245);
            cmb_SearchByCourse.ListTextColor = Color.DimGray;
            cmb_SearchByCourse.Location = new Point(632, 105);
            cmb_SearchByCourse.MinimumSize = new Size(200, 30);
            cmb_SearchByCourse.Name = "cmb_SearchByCourse";
            cmb_SearchByCourse.Padding = new Padding(2);
            cmb_SearchByCourse.SelectedValue = null;
            cmb_SearchByCourse.Size = new Size(204, 30);
            cmb_SearchByCourse.TabIndex = 34;
            cmb_SearchByCourse.Texts = "";
            cmb_SearchByCourse.OnSelectedIndexChanged += this.cmb_SearchByCourse_SelectedIndexChanged;
            // 
            // frmAdminManageExamsUc
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(cmb_SearchByCourse);
            Controls.Add(btn_Report);
            Controls.Add(btn_SearchByName);
            Controls.Add(btn_Multi_Filters);
            Controls.Add(button1);
            Controls.Add(customPanel1);
            Controls.Add(lbl_ExamTeacher);
            Controls.Add(lbl_NoStud);
            Controls.Add(dtp_FilterByEndTime);
            Controls.Add(dtp_FilterByStartTime);
            Controls.Add(lbl_SearchByType);
            Controls.Add(chb_Parctical);
            Controls.Add(chb_Final);
            MaximumSize = new Size(863, 562);
            MinimumSize = new Size(863, 562);
            Name = "frmAdminManageExamsUc";
            Size = new Size(863, 562);
            Load += frmAdminManageExams_Load;
            customPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgv_Exam).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lbl_ExamTeacher;
        private Label lbl_NoStud;
        private DateTimePicker dtp_FilterByEndTime;
        private DateTimePicker dtp_FilterByStartTime;
        private Label lbl_SearchByType;
        private CheckBox chb_Parctical;
        private CheckBox chb_Final;
        private CustomControls.CustomPanel customPanel1;
        private DataGridView dgv_Exam;
        private CustomControls.CustomButton button1;
        private CustomControls.CustomButton btn_Multi_Filters;
        private CustomControls.CustomButton btn_SearchByName;
        private CustomControls.CustomButton btn_Report;
        private CustomControls.CustomComboBox cmb_SearchByCourse;
    }
}
