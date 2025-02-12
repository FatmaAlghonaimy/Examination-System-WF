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
        public frmLogin frmLogin;
        public frmTeacherProfile()
        {
            InitializeComponent();
            frmLogin = new();
        }
        public frmTeacherProfile(frmLogin _frmLogin)
        {
            InitializeComponent();
            frmLogin = _frmLogin;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            frmLogin?.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            frmTeacherDashboard frmTeacherDashboard = new();
            frmTeacherDashboard.Show();
        }
    }
}
