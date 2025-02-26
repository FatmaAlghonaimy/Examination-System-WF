namespace Examination_System.Presentation
{
    partial class frmTeacherReports
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
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(67, 100);
            button1.Margin = new Padding(5, 6, 5, 6);
            button1.Name = "button1";
            button1.Size = new Size(129, 46);
            button1.TabIndex = 0;
            button1.Text = "report 1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(261, 100);
            button2.Margin = new Padding(5, 6, 5, 6);
            button2.Name = "button2";
            button2.Size = new Size(129, 46);
            button2.TabIndex = 1;
            button2.Text = "report 2";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button1_Click;
            // 
            // button3
            // 
            button3.Location = new Point(463, 100);
            button3.Margin = new Padding(5, 6, 5, 6);
            button3.Name = "button3";
            button3.Size = new Size(129, 46);
            button3.TabIndex = 2;
            button3.Text = "report 3";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button1_Click;
            // 
            // button4
            // 
            button4.Location = new Point(674, 100);
            button4.Margin = new Padding(5, 6, 5, 6);
            button4.Name = "button4";
            button4.Size = new Size(129, 46);
            button4.TabIndex = 3;
            button4.Text = "report 4";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button1_Click;
            // 
            // button5
            // 
            button5.Location = new Point(67, 226);
            button5.Margin = new Padding(5, 6, 5, 6);
            button5.Name = "button5";
            button5.Size = new Size(129, 46);
            button5.TabIndex = 4;
            button5.Text = "report 5";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button1_Click;
            // 
            // button6
            // 
            button6.Location = new Point(261, 226);
            button6.Margin = new Padding(5, 6, 5, 6);
            button6.Name = "button6";
            button6.Size = new Size(129, 46);
            button6.TabIndex = 5;
            button6.Text = "back";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // frmTeacherReports
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1371, 900);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Margin = new Padding(5, 6, 5, 6);
            Name = "frmTeacherReports";
            Text = "frmTeacherReports";
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
    }
}