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
    public partial class frmAdminReports : Form
    {
        public frmAdminReports()
        {
            InitializeComponent();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();
            new frmAdminDashboard().Show();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            new frmAdminReport1().Show();
        }

        
    }
}
