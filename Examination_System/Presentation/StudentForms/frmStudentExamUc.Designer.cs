namespace Examination_System.Presentation.StudentForms
{
    partial class frmStudentExamUc
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
            btn_back = new CustomControls.CustomButton();
            customPanel1 = new CustomControls.CustomPanel();
            dgvStudentExams = new DataGridView();
            customPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvStudentExams).BeginInit();
            SuspendLayout();
            // 
            // btn_back
            // 
            btn_back.BackColor = Color.DarkOrchid;
            btn_back.BackgroundColor = Color.DarkOrchid;
            btn_back.BorderColor = Color.Black;
            btn_back.BorderRadius = 30;
            btn_back.BorderSize = 0;
            btn_back.FlatAppearance.BorderSize = 0;
            btn_back.FlatStyle = FlatStyle.Flat;
            btn_back.ForeColor = Color.White;
            btn_back.Location = new Point(26, 19);
            btn_back.Name = "btn_back";
            btn_back.Size = new Size(150, 32);
            btn_back.TabIndex = 26;
            btn_back.Text = "Back";
            btn_back.TextColor = Color.White;
            btn_back.UseVisualStyleBackColor = false;
            btn_back.Click += btn_back_Click;
            // 
            // customPanel1
            // 
            customPanel1.AutoSize = true;
            customPanel1.BackColor = Color.Black;
            customPanel1.BorderColor = Color.Black;
            customPanel1.BorderRadius = 30;
            customPanel1.BorderSize = 2;
            customPanel1.Controls.Add(dgvStudentExams);
            customPanel1.ForeColor = Color.Black;
            customPanel1.GradientBottomColor = Color.CadetBlue;
            customPanel1.GradientTopColor = Color.DodgerBlue;
            customPanel1.GrediantAngle = 90F;
            customPanel1.Location = new Point(26, 75);
            customPanel1.Name = "customPanel1";
            customPanel1.Padding = new Padding(0, 0, 0, 10);
            customPanel1.Size = new Size(811, 462);
            customPanel1.TabIndex = 25;
            // 
            // dgvStudentExams
            // 
            dgvStudentExams.AllowUserToAddRows = false;
            dgvStudentExams.AllowUserToDeleteRows = false;
            dgvStudentExams.AllowUserToResizeColumns = false;
            dgvStudentExams.AllowUserToResizeRows = false;
            dgvStudentExams.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.ColumnHeader;
            dgvStudentExams.BackgroundColor = Color.White;
            dgvStudentExams.BorderStyle = BorderStyle.None;
            dgvStudentExams.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = Color.Black;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle4.ForeColor = Color.FromArgb(235, 230, 255);
            dataGridViewCellStyle4.Padding = new Padding(15);
            dataGridViewCellStyle4.SelectionBackColor = Color.Black;
            dataGridViewCellStyle4.SelectionForeColor = Color.FromArgb(235, 230, 255);
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            dgvStudentExams.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dgvStudentExams.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = SystemColors.Window;
            dataGridViewCellStyle5.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle5.ForeColor = Color.Black;
            dataGridViewCellStyle5.SelectionBackColor = SystemColors.GradientActiveCaption;
            dataGridViewCellStyle5.SelectionForeColor = Color.Black;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.False;
            dgvStudentExams.DefaultCellStyle = dataGridViewCellStyle5;
            dgvStudentExams.Dock = DockStyle.Fill;
            dgvStudentExams.EnableHeadersVisualStyles = false;
            dgvStudentExams.Location = new Point(0, 0);
            dgvStudentExams.Name = "dgvStudentExams";
            dgvStudentExams.ReadOnly = true;
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = SystemColors.Control;
            dataGridViewCellStyle6.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle6.ForeColor = Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.True;
            dgvStudentExams.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            dgvStudentExams.RowHeadersVisible = false;
            dgvStudentExams.RowHeadersWidth = 25;
            dgvStudentExams.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvStudentExams.Size = new Size(811, 452);
            dgvStudentExams.TabIndex = 0;
            dgvStudentExams.CellContentClick += dgvStudentExams_CellClick;
            dgvStudentExams.CellFormatting += dgvStudentExams_CellFormatting;
            // 
            // frmStudentExamUc
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(btn_back);
            Controls.Add(customPanel1);
            Margin = new Padding(2);
            MaximumSize = new Size(863, 562);
            MinimumSize = new Size(863, 562);
            Name = "frmStudentExamUc";
            Size = new Size(863, 562);
            Load += frmStudentExamUc_Load;
            customPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvStudentExams).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CustomControls.CustomButton btn_back;
        private CustomControls.CustomPanel customPanel1;
        private DataGridView dgvStudentExams;
    }
}
