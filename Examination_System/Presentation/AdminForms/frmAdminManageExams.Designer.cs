namespace Examination_System.Presentation.AdminForms
{
    partial class frmAdminManageExams
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
            button2 = new Button();
            dgv_Exam = new DataGridView();
            cmb_SearchByCourse = new ComboBox();
            chb_Final = new CheckBox();
            chb_Parctical = new CheckBox();
            lbl_SearchByType = new Label();
            dtp_FilterByStartTime = new DateTimePicker();
            dtp_FilterByEndTime = new DateTimePicker();
            btn_SearchByName = new Button();
            lbl_NoStud = new Label();
            lbl_ExamTeacher = new Label();
            btn_Report = new Button();
            ((System.ComponentModel.ISupportInitialize)dgv_Exam).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(13, 14);
            button1.Margin = new Padding(4, 5, 4, 5);
            button1.Name = "button1";
            button1.Size = new Size(163, 38);
            button1.TabIndex = 0;
            button1.Text = "create new exam";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(22, 275);
            button2.Margin = new Padding(4, 5, 4, 5);
            button2.Name = "button2";
            button2.Size = new Size(107, 38);
            button2.TabIndex = 1;
            button2.Text = "back";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // dgv_Exam
            // 
            dgv_Exam.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_Exam.Location = new Point(1, 337);
            dgv_Exam.Margin = new Padding(4, 5, 4, 5);
            dgv_Exam.Name = "dgv_Exam";
            dgv_Exam.RowHeadersWidth = 62;
            dgv_Exam.Size = new Size(1139, 412);
            dgv_Exam.TabIndex = 2;
            dgv_Exam.CellClick += dgv_Exam_CellClick;
            dgv_Exam.CellContentClick += dgv_Exam_CellContentClick;
            // 
            // cmb_SearchByCourse
            // 
            cmb_SearchByCourse.DropDownStyle = ComboBoxStyle.DropDownList;
            cmb_SearchByCourse.FormattingEnabled = true;
            cmb_SearchByCourse.Location = new Point(862, 18);
            cmb_SearchByCourse.Name = "cmb_SearchByCourse";
            cmb_SearchByCourse.Size = new Size(269, 33);
            cmb_SearchByCourse.TabIndex = 3;
            cmb_SearchByCourse.SelectedIndexChanged += cmb_SearchByCourse_SelectedIndexChanged;
            // 
            // chb_Final
            // 
            chb_Final.AutoSize = true;
            chb_Final.Location = new Point(340, 84);
            chb_Final.Name = "chb_Final";
            chb_Final.Size = new Size(121, 29);
            chb_Final.TabIndex = 4;
            chb_Final.Text = "Final Exam";
            chb_Final.UseVisualStyleBackColor = true;
            chb_Final.CheckedChanged += chb_Final_CheckedChanged;
            // 
            // chb_Parctical
            // 
            chb_Parctical.AutoSize = true;
            chb_Parctical.Location = new Point(340, 132);
            chb_Parctical.Name = "chb_Parctical";
            chb_Parctical.Size = new Size(102, 29);
            chb_Parctical.TabIndex = 5;
            chb_Parctical.Text = "Practical";
            chb_Parctical.UseVisualStyleBackColor = true;
            chb_Parctical.CheckedChanged += chb_Parctical_CheckedChanged;
            // 
            // lbl_SearchByType
            // 
            lbl_SearchByType.AutoSize = true;
            lbl_SearchByType.Location = new Point(340, 44);
            lbl_SearchByType.Name = "lbl_SearchByType";
            lbl_SearchByType.Size = new Size(130, 25);
            lbl_SearchByType.TabIndex = 6;
            lbl_SearchByType.Text = "Search By Type";
            // 
            // dtp_FilterByStartTime
            // 
            dtp_FilterByStartTime.Location = new Point(590, 82);
            dtp_FilterByStartTime.Name = "dtp_FilterByStartTime";
            dtp_FilterByStartTime.ShowCheckBox = true;
            dtp_FilterByStartTime.Size = new Size(300, 31);
            dtp_FilterByStartTime.TabIndex = 7;
            // 
            // dtp_FilterByEndTime
            // 
            dtp_FilterByEndTime.Location = new Point(590, 132);
            dtp_FilterByEndTime.Name = "dtp_FilterByEndTime";
            dtp_FilterByEndTime.ShowCheckBox = true;
            dtp_FilterByEndTime.Size = new Size(300, 31);
            dtp_FilterByEndTime.TabIndex = 8;
            // 
            // btn_SearchByName
            // 
            btn_SearchByName.Location = new Point(928, 97);
            btn_SearchByName.Name = "btn_SearchByName";
            btn_SearchByName.Size = new Size(181, 34);
            btn_SearchByName.TabIndex = 9;
            btn_SearchByName.Text = "Search By Date";
            btn_SearchByName.UseVisualStyleBackColor = true;
            btn_SearchByName.Click += btn_SearchByName_Click;
            // 
            // lbl_NoStud
            // 
            lbl_NoStud.AutoSize = true;
            lbl_NoStud.Location = new Point(32, 82);
            lbl_NoStud.Name = "lbl_NoStud";
            lbl_NoStud.Size = new Size(165, 25);
            lbl_NoStud.TabIndex = 10;
            lbl_NoStud.Text = "Number of Student";
            lbl_NoStud.Click += lbl_NoStud_Click;
            // 
            // lbl_ExamTeacher
            // 
            lbl_ExamTeacher.AutoSize = true;
            lbl_ExamTeacher.Location = new Point(32, 122);
            lbl_ExamTeacher.Name = "lbl_ExamTeacher";
            lbl_ExamTeacher.Size = new Size(70, 25);
            lbl_ExamTeacher.TabIndex = 13;
            lbl_ExamTeacher.Text = "Teacher";
            // 
            // btn_Report
            // 
            btn_Report.Location = new Point(584, 218);
            btn_Report.Name = "btn_Report";
            btn_Report.Size = new Size(277, 34);
            btn_Report.TabIndex = 14;
            btn_Report.Text = "Report";
            btn_Report.UseVisualStyleBackColor = true;
            btn_Report.Click += btn_Report_Click;
            // 
            // frmAdminManageExams
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1143, 750);
            Controls.Add(btn_Report);
            Controls.Add(lbl_ExamTeacher);
            Controls.Add(lbl_NoStud);
            Controls.Add(btn_SearchByName);
            Controls.Add(dtp_FilterByEndTime);
            Controls.Add(dtp_FilterByStartTime);
            Controls.Add(lbl_SearchByType);
            Controls.Add(chb_Parctical);
            Controls.Add(chb_Final);
            Controls.Add(cmb_SearchByCourse);
            Controls.Add(dgv_Exam);
            Controls.Add(button2);
            Controls.Add(button1);
            Margin = new Padding(4, 5, 4, 5);
            Name = "frmAdminManageExams";
            Text = "frmAdminManageExams";
            Load += frmAdminManageExams_Load;
            ((System.ComponentModel.ISupportInitialize)dgv_Exam).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private DataGridView dgv_Exam;
        private ComboBox cmb_SearchByCourse;
        private CheckBox chb_Final;
        private CheckBox chb_Parctical;
        private Label lbl_SearchByType;
        private DateTimePicker dtp_FilterByStartTime;
        private DateTimePicker dtp_FilterByEndTime;
        private Button btn_SearchByName;
        private Label lbl_NoStud;
        private Label lbl_ExamTeacher;
        private Button btn_Report;
    }
}