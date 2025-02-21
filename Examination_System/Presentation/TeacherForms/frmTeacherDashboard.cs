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
    public partial class frmTeacherDashboard : Form
    {
        public frmTeacherDashboard()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            frmTeacherReports frmTeacherReports = new();
            frmTeacherReports.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
            new frmTeacherManageStudents().Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
            frmLogin frmLogin = new();
            frmLogin.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            new frmTeacherProfile().Show();
        }
    }
}
