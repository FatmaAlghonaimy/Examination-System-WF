namespace Examination_System.Presentation
{
    partial class frmStudentCourses
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
            dgvStudentCourses = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvStudentCourses).BeginInit();
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
            // dgvStudentCourses
            // 
            dgvStudentCourses.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvStudentCourses.Location = new Point(159, 24);
            dgvStudentCourses.Margin = new Padding(5, 6, 5, 6);
            dgvStudentCourses.Name = "dgvStudentCourses";
            dgvStudentCourses.RowHeadersWidth = 72;
            dgvStudentCourses.Size = new Size(1191, 572);
            dgvStudentCourses.TabIndex = 1;
            dgvStudentCourses.CellContentClick += dgvStudentCourses_CellContentClick;
            // 
            // frmStudentCourses
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1371, 900);
            Controls.Add(dgvStudentCourses);
            Controls.Add(button1);
            Margin = new Padding(5, 6, 5, 6);
            Name = "frmStudentCourses";
            Text = "frmStudentCourses";
            Load += frmStudentCourses_Load;
            ((System.ComponentModel.ISupportInitialize)dgvStudentCourses).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private DataGridView dgvStudentCourses;
    }
}