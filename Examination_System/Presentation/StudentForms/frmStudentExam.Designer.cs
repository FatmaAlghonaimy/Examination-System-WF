namespace Examination_System.Presentation
{
    partial class frmStudentExam
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
            dgvStudentExams = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvStudentExams).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(21, 24);
            button1.Margin = new Padding(5, 6, 5, 6);
            button1.Name = "button1";
            button1.Size = new Size(129, 46);
            button1.TabIndex = 0;
            button1.Text = "back";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // dgvStudentExams
            // 
            dgvStudentExams.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvStudentExams.Location = new Point(21, 104);
            dgvStudentExams.Margin = new Padding(5, 6, 5, 6);
            dgvStudentExams.Name = "dgvStudentExams";
            dgvStudentExams.RowHeadersWidth = 72;
            dgvStudentExams.Size = new Size(1330, 488);
            dgvStudentExams.TabIndex = 1;
            // 
            // frmStudentExam
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1371, 900);
            Controls.Add(dgvStudentExams);
            Controls.Add(button1);
            Margin = new Padding(5, 6, 5, 6);
            Name = "frmStudentExam";
            Text = "frmStudentExam";
            Load += frmStudentExam_Load_1;
            ((System.ComponentModel.ISupportInitialize)dgvStudentExams).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private DataGridView dgvStudentExams;
    }
}