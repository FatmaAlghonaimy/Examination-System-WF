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
    public partial class frmTeacherManageStudents : Form
    {
        public frmTeacherManageStudents()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            frmTeacherDashboard frmTeacherDashboard = new frmTeacherDashboard();
            frmTeacherDashboard.Show();
        }
    }
}
