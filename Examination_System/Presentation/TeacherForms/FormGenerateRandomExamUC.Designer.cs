namespace Examination_System.Presentation.TeacherForms
{
    partial class FormGenerateRandomExamUC
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
            label1 = new Label();
            NumTFQuestions = new NumericUpDown();
            label3 = new Label();
            NumChooseOneQuestion = new NumericUpDown();
            label2 = new Label();
            NumChooseMultipleQuestion = new NumericUpDown();
            label4 = new Label();
            customPanel2 = new CustomControls.CustomPanel();
            pictureBox1 = new PictureBox();
            lb_coursegrade = new Label();
            lb_courseduration = new Label();
            lb_coursename = new Label();
            btnContinue = new CustomControls.CustomButton();
            btn_back = new CustomControls.CustomButton();
            ((System.ComponentModel.ISupportInitialize)NumTFQuestions).BeginInit();
            ((System.ComponentModel.ISupportInitialize)NumChooseOneQuestion).BeginInit();
            ((System.ComponentModel.ISupportInitialize)NumChooseMultipleQuestion).BeginInit();
            customPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Times New Roman", 10.2F, FontStyle.Bold);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(28, 109);
            label1.Name = "label1";
            label1.Size = new Size(76, 17);
            label1.TabIndex = 3;
            label1.Text = "True False ";
            // 
            // NumTFQuestions
            // 
            NumTFQuestions.Location = new Point(146, 103);
            NumTFQuestions.Margin = new Padding(3, 2, 3, 2);
            NumTFQuestions.Name = "NumTFQuestions";
            NumTFQuestions.Size = new Size(173, 23);
            NumTFQuestions.TabIndex = 0;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Times New Roman", 10.2F, FontStyle.Bold);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(28, 226);
            label3.Name = "label3";
            label3.Size = new Size(112, 17);
            label3.TabIndex = 5;
            label3.Text = "Choose Multiple ";
            // 
            // NumChooseOneQuestion
            // 
            NumChooseOneQuestion.Location = new Point(146, 155);
            NumChooseOneQuestion.Margin = new Padding(3, 2, 3, 2);
            NumChooseOneQuestion.Name = "NumChooseOneQuestion";
            NumChooseOneQuestion.Size = new Size(173, 23);
            NumChooseOneQuestion.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Times New Roman", 10.2F, FontStyle.Bold);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(28, 161);
            label2.Name = "label2";
            label2.Size = new Size(83, 17);
            label2.TabIndex = 4;
            label2.Text = "Choose One";
            // 
            // NumChooseMultipleQuestion
            // 
            NumChooseMultipleQuestion.Location = new Point(146, 220);
            NumChooseMultipleQuestion.Margin = new Padding(3, 2, 3, 2);
            NumChooseMultipleQuestion.Name = "NumChooseMultipleQuestion";
            NumChooseMultipleQuestion.Size = new Size(173, 23);
            NumChooseMultipleQuestion.TabIndex = 2;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(65, 30);
            label4.Name = "label4";
            label4.Size = new Size(707, 37);
            label4.TabIndex = 27;
            label4.Text = "Select How Many Questions Per Type to be Generated";
            // 
            // customPanel2
            // 
            customPanel2.BackColor = Color.Transparent;
            customPanel2.BorderColor = Color.Transparent;
            customPanel2.BorderRadius = 60;
            customPanel2.BorderSize = 0;
            customPanel2.Controls.Add(label3);
            customPanel2.Controls.Add(pictureBox1);
            customPanel2.Controls.Add(NumChooseOneQuestion);
            customPanel2.Controls.Add(label1);
            customPanel2.Controls.Add(label2);
            customPanel2.Controls.Add(lb_coursegrade);
            customPanel2.Controls.Add(NumChooseMultipleQuestion);
            customPanel2.Controls.Add(NumTFQuestions);
            customPanel2.Controls.Add(lb_courseduration);
            customPanel2.Controls.Add(lb_coursename);
            customPanel2.Controls.Add(btnContinue);
            customPanel2.Controls.Add(btn_back);
            customPanel2.ForeColor = Color.White;
            customPanel2.GradientBottomColor = Color.FromArgb(238, 238, 238);
            customPanel2.GradientTopColor = Color.FromArgb(238, 238, 238);
            customPanel2.GrediantAngle = 90F;
            customPanel2.Location = new Point(124, 98);
            customPanel2.Name = "customPanel2";
            customPanel2.Size = new Size(629, 369);
            customPanel2.TabIndex = 64;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.random;
            pictureBox1.Location = new Point(345, 97);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(214, 180);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 66;
            pictureBox1.TabStop = false;
            // 
            // lb_coursegrade
            // 
            lb_coursegrade.AutoSize = true;
            lb_coursegrade.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lb_coursegrade.ForeColor = Color.Red;
            lb_coursegrade.Location = new Point(30, 70);
            lb_coursegrade.Name = "lb_coursegrade";
            lb_coursegrade.Size = new Size(10, 15);
            lb_coursegrade.TabIndex = 65;
            lb_coursegrade.Text = " ";
            // 
            // lb_courseduration
            // 
            lb_courseduration.AutoSize = true;
            lb_courseduration.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lb_courseduration.ForeColor = Color.Red;
            lb_courseduration.Location = new Point(30, 44);
            lb_courseduration.Name = "lb_courseduration";
            lb_courseduration.Size = new Size(10, 15);
            lb_courseduration.TabIndex = 64;
            lb_courseduration.Text = " ";
            // 
            // lb_coursename
            // 
            lb_coursename.AutoSize = true;
            lb_coursename.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lb_coursename.ForeColor = Color.Red;
            lb_coursename.Location = new Point(30, 17);
            lb_coursename.Name = "lb_coursename";
            lb_coursename.Size = new Size(10, 15);
            lb_coursename.TabIndex = 63;
            lb_coursename.Text = " ";
            // 
            // btnContinue
            // 
            btnContinue.BackColor = Color.MediumSlateBlue;
            btnContinue.BackgroundColor = Color.MediumSlateBlue;
            btnContinue.BorderColor = Color.Black;
            btnContinue.BorderRadius = 30;
            btnContinue.BorderSize = 0;
            btnContinue.FlatAppearance.BorderSize = 0;
            btnContinue.FlatStyle = FlatStyle.Flat;
            btnContinue.ForeColor = Color.White;
            btnContinue.Location = new Point(380, 298);
            btnContinue.Name = "btnContinue";
            btnContinue.Size = new Size(179, 29);
            btnContinue.TabIndex = 60;
            btnContinue.Text = "Continue";
            btnContinue.TextColor = Color.White;
            btnContinue.UseVisualStyleBackColor = false;
            btnContinue.Click += btnContinue_Click;
            // 
            // btn_back
            // 
            btn_back.BackColor = Color.MediumSlateBlue;
            btn_back.BackgroundColor = Color.MediumSlateBlue;
            btn_back.BorderColor = Color.Black;
            btn_back.BorderRadius = 30;
            btn_back.BorderSize = 0;
            btn_back.FlatAppearance.BorderSize = 0;
            btn_back.FlatStyle = FlatStyle.Flat;
            btn_back.ForeColor = Color.White;
            btn_back.Location = new Point(117, 298);
            btn_back.Name = "btn_back";
            btn_back.Size = new Size(179, 29);
            btn_back.TabIndex = 61;
            btn_back.Text = "Back";
            btn_back.TextColor = Color.White;
            btn_back.UseVisualStyleBackColor = false;
            btn_back.Click += btn_back_Click;
            // 
            // FormGenerateRandomExamUC
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(customPanel2);
            Controls.Add(label4);
            Margin = new Padding(3, 2, 3, 2);
            Name = "FormGenerateRandomExamUC";
            Size = new Size(806, 501);
            ((System.ComponentModel.ISupportInitialize)NumTFQuestions).EndInit();
            ((System.ComponentModel.ISupportInitialize)NumChooseOneQuestion).EndInit();
            ((System.ComponentModel.ISupportInitialize)NumChooseMultipleQuestion).EndInit();
            customPanel2.ResumeLayout(false);
            customPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private NumericUpDown NumTFQuestions;
        private Label label3;
        private NumericUpDown NumChooseOneQuestion;
        private Label label2;
        private NumericUpDown NumChooseMultipleQuestion;
        private Label label4;
        private CustomControls.CustomPanel customPanel2;
        private PictureBox pictureBox1;
        private CustomControls.CustomComboBox com_courseteacher;
        private CustomControls.CustomButton btnContinue;
        private Label label5;
        private Label label7;
        private CustomControls.CustomButton btn_back;
        private Label lb_coursegrade;
        private Label lb_courseduration;
        private Label lb_coursename;
        private CustomControls.CustomTextBox n_coursegrade;
        private CustomControls.CustomTextBox tx_coursename;
        private Label label9;
        private CustomControls.CustomTextBox n_courseduration;
        private Label label11;
    }
}
