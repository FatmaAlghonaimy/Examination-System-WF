namespace Examination_System.Presentation.TeacherForms
{
    partial class UserControlTryForm
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
            leftPanel1 = new leftPanel();
            SuspendLayout();
            // 
            // leftPanel1
            // 
            leftPanel1.Location = new Point(55, 36);
            leftPanel1.Name = "leftPanel1";
            leftPanel1.Size = new Size(411, 536);
            leftPanel1.TabIndex = 0;
            // 
            // UserControlTryForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1019, 596);
            Controls.Add(leftPanel1);
            Name = "UserControlTryForm";
            Text = "UserControlTryForm";
            ResumeLayout(false);
        }

        #endregion

        private leftPanel leftPanel1;
    }
}