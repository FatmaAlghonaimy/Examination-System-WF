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
            panel1 = new Panel();
            SuspendLayout();
            // 
            // leftPanel1
            // 
            leftPanel1.BackColor = Color.WhiteSmoke;
            leftPanel1.Location = new Point(23, 45);
            leftPanel1.Name = "leftPanel1";
            leftPanel1.Size = new Size(241, 495);
            leftPanel1.TabIndex = 0;
            //leftPanel1.Load += leftPanel1_Load_1;
            // 
            // panel1
            // 
            panel1.Location = new Point(281, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(1061, 734);
            panel1.TabIndex = 1;
            //panel1.Paint += panel1_Paint;
            // 
            // UserControlTryForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1346, 750);
            Controls.Add(panel1);
            Controls.Add(leftPanel1);
            Name = "UserControlTryForm";
            Text = "UserControlTryForm";
            ResumeLayout(false);
        }

        #endregion

        private leftPanel leftPanel1;
        private Panel panel1;
    }
}