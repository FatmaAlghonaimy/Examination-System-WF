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
    public partial class frmStudentProfile : Form
    {
        public frmLogin frmLogin;
        public frmStudentProfile()
        {
            InitializeComponent();
            frmLogin = new frmLogin();

        }
        public frmStudentProfile(frmLogin _frmLogin)
        {
            InitializeComponent();
            frmLogin = _frmLogin;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            frmLogin?.Show();
        }

        private void btn_history_Click(object sender, EventArgs e)
        {
            this.Close();
            frmStudentExamsHistory frmStudentExamsHistory = new frmStudentExamsHistory();
            frmStudentExamsHistory.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
            frmLogin.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            new frmStudentCourses().Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
            new frmStudentExam().Show();
        }
    }
}
