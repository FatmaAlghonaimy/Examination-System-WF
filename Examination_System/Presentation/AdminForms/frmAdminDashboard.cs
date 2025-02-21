using Examination_System.Presentation.AdminForms;
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
    public partial class frmAdminDashboard : Form
    {
        public frmAdminDashboard()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            new frmAdminProfile().Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            new frmAdminReports().Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
            new frmAdminManageStudents().Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();
            new frmAdminManageTeachers().Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
            new frmAdminManageExams().Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
            new frmLogin().Show();
        }
    }
}
