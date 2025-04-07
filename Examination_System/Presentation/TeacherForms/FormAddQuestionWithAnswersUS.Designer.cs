namespace Examination_System.Presentation.TeacherForms
{
    partial class FormAddQuestionWithAnswersUS
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAddQuestionWithAnswersUS));
            AnswerPanel = new Panel();
            customPanel1 = new CustomControls.CustomPanel();
            label1 = new Label();
            btn_back = new Button();
            Add = new Label();
            btn_save = new Button();
            pictureBox1 = new PictureBox();
            label2 = new Label();
            cmbQuestionTypes = new ComboBox();
            MarksUpDown = new NumericUpDown();
            txtQuestionBody = new RichTextBox();
            cmbCourseName = new ComboBox();
            label4 = new Label();
            label6 = new Label();
            label8 = new Label();
            customPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)MarksUpDown).BeginInit();
            SuspendLayout();
            // 
            // AnswerPanel
            // 
            AnswerPanel.AutoScroll = true;
            AnswerPanel.AutoSize = true;
            AnswerPanel.BackColor = Color.Transparent;
            AnswerPanel.Location = new Point(444, 205);
            AnswerPanel.Margin = new Padding(3, 2, 3, 2);
            AnswerPanel.Name = "AnswerPanel";
            AnswerPanel.Size = new Size(383, 232);
            AnswerPanel.TabIndex = 25;
            AnswerPanel.Paint += AnswerPanel_Paint;
            // 
            // customPanel1
            // 
            customPanel1.BackColor = Color.Black;
            customPanel1.BorderColor = Color.Black;
            customPanel1.BorderRadius = 30;
            customPanel1.BorderSize = 2;
            customPanel1.Controls.Add(label2);
            customPanel1.Controls.Add(cmbQuestionTypes);
            customPanel1.Controls.Add(MarksUpDown);
            customPanel1.Controls.Add(txtQuestionBody);
            customPanel1.Controls.Add(cmbCourseName);
            customPanel1.Controls.Add(label4);
            customPanel1.Controls.Add(label6);
            customPanel1.Controls.Add(label8);
            customPanel1.Controls.Add(btn_back);
            customPanel1.Controls.Add(pictureBox1);
            customPanel1.ForeColor = Color.White;
            customPanel1.GradientBottomColor = Color.LightCyan;
            customPanel1.GradientTopColor = Color.SlateGray;
            customPanel1.GrediantAngle = 90F;
            customPanel1.Location = new Point(18, 10);
            customPanel1.Name = "customPanel1";
            customPanel1.Size = new Size(400, 533);
            customPanel1.TabIndex = 30;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(524, 163);
            label1.Name = "label1";
            label1.Size = new Size(182, 25);
            label1.TabIndex = 29;
            label1.Text = "Select Your Answer";
            // 
            // btn_back
            // 
            btn_back.BackColor = Color.Black;
            btn_back.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_back.ForeColor = Color.White;
            btn_back.Location = new Point(68, 458);
            btn_back.Name = "btn_back";
            btn_back.Size = new Size(271, 40);
            btn_back.TabIndex = 3;
            btn_back.Text = "Back";
            btn_back.UseVisualStyleBackColor = false;
            btn_back.Click += btn_back_Click;
            // 
            // Add
            // 
            Add.AutoSize = true;
            Add.BackColor = Color.Transparent;
            Add.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Add.Location = new Point(444, 47);
            Add.Name = "Add";
            Add.Size = new Size(303, 45);
            Add.TabIndex = 26;
            Add.Text = "Add New Question";
            Add.Click += Add_Click;
            // 
            // btn_save
            // 
            btn_save.BackColor = Color.Black;
            btn_save.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_save.ForeColor = Color.White;
            btn_save.Location = new Point(488, 468);
            btn_save.Name = "btn_save";
            btn_save.Size = new Size(259, 40);
            btn_save.TabIndex = 2;
            btn_save.Text = "Save";
            btn_save.UseVisualStyleBackColor = false;
            btn_save.Click += BtnSave_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(84, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(239, 180);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(40, 381);
            label2.Name = "label2";
            label2.Size = new Size(99, 17);
            label2.TabIndex = 37;
            label2.Text = "Question Body";
            // 
            // cmbQuestionTypes
            // 
            cmbQuestionTypes.FormattingEnabled = true;
            cmbQuestionTypes.Location = new Point(157, 327);
            cmbQuestionTypes.Margin = new Padding(3, 2, 3, 2);
            cmbQuestionTypes.Name = "cmbQuestionTypes";
            cmbQuestionTypes.Size = new Size(182, 23);
            cmbQuestionTypes.TabIndex = 33;
            cmbQuestionTypes.SelectedIndexChanged += CmbQuestionTypes_SelectedIndexChanged;
            // 
            // MarksUpDown
            // 
            MarksUpDown.Location = new Point(157, 272);
            MarksUpDown.Margin = new Padding(3, 2, 3, 2);
            MarksUpDown.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            MarksUpDown.Name = "MarksUpDown";
            MarksUpDown.Size = new Size(181, 23);
            MarksUpDown.TabIndex = 34;
            MarksUpDown.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // txtQuestionBody
            // 
            txtQuestionBody.Location = new Point(157, 378);
            txtQuestionBody.Margin = new Padding(3, 2, 3, 2);
            txtQuestionBody.Name = "txtQuestionBody";
            txtQuestionBody.Size = new Size(182, 39);
            txtQuestionBody.TabIndex = 32;
            txtQuestionBody.Text = "";
            // 
            // cmbCourseName
            // 
            cmbCourseName.FormattingEnabled = true;
            cmbCourseName.Location = new Point(157, 220);
            cmbCourseName.Margin = new Padding(3, 2, 3, 2);
            cmbCourseName.Name = "cmbCourseName";
            cmbCourseName.Size = new Size(182, 23);
            cmbCourseName.TabIndex = 35;
            cmbCourseName.SelectedIndexChanged += cmbCourseName_SelectedIndexChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(43, 327);
            label4.Name = "label4";
            label4.Size = new Size(97, 17);
            label4.TabIndex = 36;
            label4.Text = "Question Type";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            label6.ForeColor = Color.Black;
            label6.Location = new Point(48, 274);
            label6.Name = "label6";
            label6.Size = new Size(45, 17);
            label6.TabIndex = 31;
            label6.Text = "Marks";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.Transparent;
            label8.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            label8.ForeColor = Color.Black;
            label8.Location = new Point(43, 221);
            label8.Name = "label8";
            label8.Size = new Size(90, 17);
            label8.TabIndex = 30;
            label8.Text = "Course Name";
            // 
            // FormAddQuestionWithAnswersUS
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(customPanel1);
            Controls.Add(label1);
            Controls.Add(AnswerPanel);
            Controls.Add(btn_save);
            Controls.Add(Add);
            Margin = new Padding(3, 2, 3, 2);
            MaximumSize = new Size(863, 562);
            MinimumSize = new Size(863, 562);
            Name = "FormAddQuestionWithAnswersUS";
            Size = new Size(863, 562);
            customPanel1.ResumeLayout(false);
            customPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)MarksUpDown).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Panel AnswerPanel;
        private CustomControls.CustomPanel customPanel1;
        private Button btn_back;
        private Button btn_save;
        private PictureBox pictureBox1;
        private Label Add;
        private Label label1;
        private Label label2;
        private ComboBox cmbQuestionTypes;
        private NumericUpDown MarksUpDown;
        private RichTextBox txtQuestionBody;
        private ComboBox cmbCourseName;
        private Label label4;
        private Label label6;
        private Label label8;
    }
}
