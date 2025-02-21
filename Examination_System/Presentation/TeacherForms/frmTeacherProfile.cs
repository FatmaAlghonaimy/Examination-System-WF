using Examination_System.Business;
using ExaminationSystem;
using ExaminationSystem.Presentation;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Examination_System.Presentation
{
    public partial class frmTeacherProfile : Form
    {
        public frmTeacherProfile()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            General.frmLogin.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            frmTeacherDashboard frmTeacherDashboard = new();
            frmTeacherDashboard.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
            UserService.Logout();
            General.frmLogin.Show();
        }

        private void btn_addexam_Click(object sender, EventArgs e)
        {
            this.Close();
            new FormAddExam().Show();
        }

        private void btn_addquestion_Click(object sender, EventArgs e)
        {
            this.Close();
            new FormAddQuestionWithAnswers().Show();
        }

        private void btn_studentsreport_Click(object sender, EventArgs e)
        {
            this.Close();
            new Form1().Show();
        }

        private void btn_mngstudents_Click(object sender, EventArgs e)
        {
            this.Close();
            new Form2().Show();
        }
    }
}
