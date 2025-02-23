namespace Examination_System
{
    partial class leftPanel
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
            btn_mngstudents = new Button();
            btn_examsreport = new Button();
            btn_addquestion = new Button();
            btn_logout = new Button();
            btn_addexam = new Button();
            btn_back = new Button();
            SuspendLayout();
            // 
            // btn_mngstudents
            // 
            btn_mngstudents.BackColor = Color.SteelBlue;
            btn_mngstudents.FlatAppearance.BorderSize = 0;
            btn_mngstudents.FlatStyle = FlatStyle.Flat;
            btn_mngstudents.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btn_mngstudents.ForeColor = Color.White;
            btn_mngstudents.Location = new Point(20, 20);
            btn_mngstudents.Name = "btn_mngstudents";
            btn_mngstudents.Size = new Size(200, 40);
            btn_mngstudents.TabIndex = 11;
            btn_mngstudents.Text = "Manage Students";
            btn_mngstudents.UseVisualStyleBackColor = false;
            btn_mngstudents.MouseEnter += Button_MouseEnter;
            btn_mngstudents.MouseLeave += Button_MouseLeave;
            // 
            // btn_examsreport
            // 
            btn_examsreport.BackColor = Color.SteelBlue;
            btn_examsreport.FlatAppearance.BorderSize = 0;
            btn_examsreport.FlatStyle = FlatStyle.Flat;
            btn_examsreport.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btn_examsreport.ForeColor = Color.White;
            btn_examsreport.Location = new Point(20, 280);
            btn_examsreport.Name = "btn_examsreport";
            btn_examsreport.Size = new Size(200, 40);
            btn_examsreport.TabIndex = 10;
            btn_examsreport.Text = "Exams Report";
            btn_examsreport.UseVisualStyleBackColor = false;
            btn_examsreport.MouseEnter += Button_MouseEnter;
            btn_examsreport.MouseLeave += Button_MouseLeave;
            // 
            // btn_addquestion
            // 
            btn_addquestion.BackColor = Color.SteelBlue;
            btn_addquestion.FlatAppearance.BorderSize = 0;
            btn_addquestion.FlatStyle = FlatStyle.Flat;
            btn_addquestion.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btn_addquestion.ForeColor = Color.White;
            btn_addquestion.Location = new Point(20, 206);
            btn_addquestion.Name = "btn_addquestion";
            btn_addquestion.Size = new Size(200, 40);
            btn_addquestion.TabIndex = 9;
            btn_addquestion.Text = "Add Question";
            btn_addquestion.UseVisualStyleBackColor = false;
            btn_addquestion.MouseEnter += Button_MouseEnter;
            btn_addquestion.MouseLeave += Button_MouseLeave;
            // 
            // btn_logout
            // 
            btn_logout.BackColor = Color.Crimson;
            btn_logout.FlatAppearance.BorderSize = 0;
            btn_logout.FlatStyle = FlatStyle.Flat;
            btn_logout.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btn_logout.ForeColor = Color.White;
            btn_logout.Location = new Point(20, 340);
            btn_logout.Name = "btn_logout";
            btn_logout.Size = new Size(200, 40);
            btn_logout.TabIndex = 8;
            btn_logout.Text = "Logout";
            btn_logout.UseVisualStyleBackColor = false;
            btn_logout.MouseEnter += Button_MouseEnter;
            btn_logout.MouseLeave += Button_MouseLeave;
            // 
            // btn_addexam
            // 
            btn_addexam.BackColor = Color.SteelBlue;
            btn_addexam.FlatAppearance.BorderSize = 0;
            btn_addexam.FlatStyle = FlatStyle.Flat;
            btn_addexam.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btn_addexam.ForeColor = Color.White;
            btn_addexam.Location = new Point(20, 144);
            btn_addexam.Name = "btn_addexam";
            btn_addexam.Size = new Size(200, 40);
            btn_addexam.TabIndex = 7;
            btn_addexam.Text = "Add Exam";
            btn_addexam.UseVisualStyleBackColor = false;
            btn_addexam.MouseEnter += Button_MouseEnter;
            btn_addexam.MouseLeave += Button_MouseLeave;
            // 
            // btn_back
            // 
            btn_back.BackColor = Color.SteelBlue;
            btn_back.FlatAppearance.BorderSize = 0;
            btn_back.FlatStyle = FlatStyle.Flat;
            btn_back.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btn_back.ForeColor = Color.White;
            btn_back.Location = new Point(20, 80);
            btn_back.Name = "btn_back";
            btn_back.Size = new Size(200, 40);
            btn_back.TabIndex = 6;
            btn_back.Text = "Back";
            btn_back.UseVisualStyleBackColor = false;
            btn_back.MouseEnter += Button_MouseEnter;
            btn_back.MouseLeave += Button_MouseLeave;
            // 
            // leftPanel
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            Controls.Add(btn_mngstudents);
            Controls.Add(btn_examsreport);
            Controls.Add(btn_addquestion);
            Controls.Add(btn_logout);
            Controls.Add(btn_addexam);
            Controls.Add(btn_back);
            Name = "leftPanel";
            Size = new Size(240, 400);
            ResumeLayout(false);
        }

        #endregion

        private Button btn_mngstudents;
        private Button btn_examsreport;
        private Button btn_addquestion;
        private Button btn_logout;
        private Button btn_addexam;
        private Button btn_back;

        // Hover effect for buttons
        private void Button_MouseEnter(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            button.BackColor = Color.LightSkyBlue;
        }

        private void Button_MouseLeave(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            if (button == btn_logout)
                button.BackColor = Color.Crimson;
            else
                button.BackColor = Color.SteelBlue;
        }
    }
}