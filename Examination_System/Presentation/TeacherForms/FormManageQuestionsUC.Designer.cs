namespace Examination_System.Presentation.TeacherForms
{
    partial class FormManageQuestionsUC
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            OneChoiceType = new CheckBox();
            label4 = new Label();
            lbl_SearchByType = new Label();
            MultiChoiceType = new CheckBox();
            TrueFalseQuestion = new CheckBox();
            customPanel1 = new CustomControls.CustomPanel();
            dgvQuestions = new DataGridView();
            label1 = new Label();
            button2 = new CustomControls.CustomButton();
            button1 = new CustomControls.CustomButton();
            cmbCourseName = new CustomControls.CustomComboBox();
            customPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvQuestions).BeginInit();
            SuspendLayout();
            // 
            // OneChoiceType
            // 
            OneChoiceType.AutoSize = true;
            OneChoiceType.Font = new Font("Segoe UI", 9.75F);
            OneChoiceType.Location = new Point(686, 98);
            OneChoiceType.Margin = new Padding(2);
            OneChoiceType.Name = "OneChoiceType";
            OneChoiceType.Size = new Size(94, 21);
            OneChoiceType.TabIndex = 35;
            OneChoiceType.Text = "One Choice";
            OneChoiceType.UseVisualStyleBackColor = true;
            OneChoiceType.CheckedChanged += OneChoiceType_CheckedChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            label4.Location = new Point(223, 63);
            label4.Name = "label4";
            label4.Size = new Size(103, 20);
            label4.TabIndex = 34;
            label4.Text = "Course Name";
            // 
            // lbl_SearchByType
            // 
            lbl_SearchByType.AutoSize = true;
            lbl_SearchByType.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            lbl_SearchByType.Location = new Point(476, 63);
            lbl_SearchByType.Margin = new Padding(2, 0, 2, 0);
            lbl_SearchByType.Name = "lbl_SearchByType";
            lbl_SearchByType.Size = new Size(114, 20);
            lbl_SearchByType.TabIndex = 32;
            lbl_SearchByType.Text = "Search By Type";
            // 
            // MultiChoiceType
            // 
            MultiChoiceType.AutoSize = true;
            MultiChoiceType.Font = new Font("Segoe UI", 9.75F);
            MultiChoiceType.Location = new Point(565, 98);
            MultiChoiceType.Margin = new Padding(2);
            MultiChoiceType.Name = "MultiChoiceType";
            MultiChoiceType.Size = new Size(117, 21);
            MultiChoiceType.TabIndex = 31;
            MultiChoiceType.Text = "Multiple Choice";
            MultiChoiceType.UseVisualStyleBackColor = true;
            MultiChoiceType.CheckedChanged += MultiChoiceType_CheckedChanged;
            // 
            // TrueFalseQuestion
            // 
            TrueFalseQuestion.AutoSize = true;
            TrueFalseQuestion.Font = new Font("Segoe UI", 9.75F);
            TrueFalseQuestion.Location = new Point(476, 98);
            TrueFalseQuestion.Margin = new Padding(2);
            TrueFalseQuestion.Name = "TrueFalseQuestion";
            TrueFalseQuestion.Size = new Size(85, 21);
            TrueFalseQuestion.TabIndex = 30;
            TrueFalseQuestion.Text = "True False";
            TrueFalseQuestion.UseVisualStyleBackColor = true;
            TrueFalseQuestion.CheckedChanged += TrueFalseQuestion_CheckedChanged;
            // 
            // customPanel1
            // 
            customPanel1.AutoSize = true;
            customPanel1.BackColor = Color.Black;
            customPanel1.BorderColor = Color.Black;
            customPanel1.BorderRadius = 30;
            customPanel1.BorderSize = 2;
            customPanel1.Controls.Add(dgvQuestions);
            customPanel1.ForeColor = Color.Black;
            customPanel1.GradientBottomColor = Color.RoyalBlue;
            customPanel1.GradientTopColor = Color.Transparent;
            customPanel1.GrediantAngle = 90F;
            customPanel1.Location = new Point(19, 146);
            customPanel1.Name = "customPanel1";
            customPanel1.Padding = new Padding(0, 0, 0, 10);
            customPanel1.Size = new Size(829, 398);
            customPanel1.TabIndex = 36;
            // 
            // dgvQuestions
            // 
            dgvQuestions.AllowUserToAddRows = false;
            dgvQuestions.AllowUserToDeleteRows = false;
            dgvQuestions.AllowUserToResizeColumns = false;
            dgvQuestions.AllowUserToResizeRows = false;
            dgvQuestions.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.ColumnHeader;
            dgvQuestions.BackgroundColor = Color.White;
            dgvQuestions.BorderStyle = BorderStyle.None;
            dgvQuestions.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = Color.Black;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.FromArgb(235, 230, 255);
            dataGridViewCellStyle1.Padding = new Padding(15);
            dataGridViewCellStyle1.SelectionBackColor = Color.Black;
            dataGridViewCellStyle1.SelectionForeColor = Color.FromArgb(235, 230, 255);
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvQuestions.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvQuestions.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.GradientActiveCaption;
            dataGridViewCellStyle2.SelectionForeColor = Color.Black;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvQuestions.DefaultCellStyle = dataGridViewCellStyle2;
            dgvQuestions.Dock = DockStyle.Fill;
            dgvQuestions.EnableHeadersVisualStyles = false;
            dgvQuestions.Location = new Point(0, 0);
            dgvQuestions.Name = "dgvQuestions";
            dgvQuestions.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Control;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dgvQuestions.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dgvQuestions.RowHeadersVisible = false;
            dgvQuestions.RowHeadersWidth = 25;
            dgvQuestions.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvQuestions.Size = new Size(829, 388);
            dgvQuestions.TabIndex = 0;
            dgvQuestions.CellContentClick += dgvQuestions_CellContentClick;
            // 
            // label1
            // 
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 17.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(3, 19);
            label1.Name = "label1";
            label1.Size = new Size(857, 38);
            label1.TabIndex = 37;
            label1.Text = "Manage Your Questions";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // button2
            // 
            button2.BackColor = Color.DarkOrchid;
            button2.BackgroundColor = Color.DarkOrchid;
            button2.BorderColor = Color.Black;
            button2.BorderRadius = 30;
            button2.BorderSize = 0;
            button2.Cursor = Cursors.Hand;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.ForeColor = Color.White;
            button2.Location = new Point(19, 25);
            button2.Name = "button2";
            button2.Size = new Size(150, 32);
            button2.TabIndex = 40;
            button2.Text = "Back";
            button2.TextColor = Color.White;
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click_1;
            // 
            // button1
            // 
            button1.BackColor = Color.DarkOrchid;
            button1.BackgroundColor = Color.DarkOrchid;
            button1.BorderColor = Color.Black;
            button1.BorderRadius = 30;
            button1.BorderSize = 0;
            button1.Cursor = Cursors.Hand;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.ForeColor = Color.White;
            button1.Location = new Point(19, 92);
            button1.Name = "button1";
            button1.Size = new Size(150, 32);
            button1.TabIndex = 41;
            button1.Text = "Add New Question";
            button1.TextColor = Color.White;
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click_1;
            // 
            // cmbCourseName
            // 
            cmbCourseName.BackColor = Color.WhiteSmoke;
            cmbCourseName.BorderColor = Color.DarkOrchid;
            cmbCourseName.BorderRadius = 0;
            cmbCourseName.BorderSize = 2;
            cmbCourseName.DropDownStyle = ComboBoxStyle.DropDown;
            cmbCourseName.Font = new Font("Segoe UI", 10F);
            cmbCourseName.ForeColor = Color.DimGray;
            cmbCourseName.IconColor = Color.MediumSlateBlue;
            cmbCourseName.ListBackColor = Color.FromArgb(230, 228, 245);
            cmbCourseName.ListTextColor = Color.DimGray;
            cmbCourseName.Location = new Point(223, 90);
            cmbCourseName.MinimumSize = new Size(200, 30);
            cmbCourseName.Name = "cmbCourseName";
            cmbCourseName.Padding = new Padding(2);
            cmbCourseName.SelectedValue = null;
            cmbCourseName.Size = new Size(200, 30);
            cmbCourseName.TabIndex = 42;
            cmbCourseName.Texts = "";
            cmbCourseName.OnSelectedIndexChanged += cmbCourseName_SelectedIndexChanged;
            // 
            // FormManageQuestionsUC
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(cmbCourseName);
            Controls.Add(button1);
            Controls.Add(button2);
            Controls.Add(label1);
            Controls.Add(customPanel1);
            Controls.Add(OneChoiceType);
            Controls.Add(label4);
            Controls.Add(lbl_SearchByType);
            Controls.Add(MultiChoiceType);
            Controls.Add(TrueFalseQuestion);
            Margin = new Padding(3, 2, 3, 2);
            MaximumSize = new Size(863, 562);
            MinimumSize = new Size(863, 562);
            Name = "FormManageQuestionsUC";
            Size = new Size(863, 562);
            customPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvQuestions).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CheckBox OneChoiceType;
        private Label label4;
        private Label lbl_SearchByType;
        private CheckBox MultiChoiceType;
        private CheckBox TrueFalseQuestion;
        private DataGridView dgvQuestions;
        private CustomControls.CustomPanel customPanel1;
        private DataGridView dataGridView1;
        private CustomControls.CustomPanel customPanel2;
        private DataGridView dgvExams;
        private Label label1;
        private CustomControls.CustomButton button2;
        private CustomControls.CustomButton button1;
        private CustomControls.CustomComboBox cmbCourseName;
    }
}
