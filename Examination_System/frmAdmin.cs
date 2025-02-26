using Examination_System.Business;
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

namespace Examination_System
{
    public partial class frmAdmin : Form
    {
        public frmAdmin()
        {
            InitializeComponent();
            UserService.SetUserImage(pic_userImg, General.LoggedUser);
            lb_name.Text = General.LoggedUser.Username;
            frmAdminProfileUc.UserDataChanged += FrmAdminProfileUc_UserDataChanged;
            General.pl_mainContent = pl_content;
        }
        private void FrmAdminProfileUc_UserDataChanged(object sender, EventArgs e)
        {
            // Refresh the sidebar UI when user data is changed
            UserService.SetUserImage(pic_userImg, General.LoggedUser);
            lb_name.Text = General.LoggedUser.Username;

        }
        private void frmAdmin_Load(object sender, EventArgs e)
        {
            pl_sidebar.BackColor = General.primarycolor;
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }



        private void LoadAdminProfile(object sender, EventArgs e)
        {
            General.LoadUserControl(new frmAdminProfileUc(General.LoggedUser));
        }

        private void button3_Click(object sender, EventArgs e)
        {
            General.LoadUserControl(new frmAdminManageStudentUc());
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //General.LoadUserControl(new frmAdminManageTeachersUc());
        }

        private void button7_Click(object sender, EventArgs e)
        {
            General.LoadUserControl(new frmAdminReportsUc());

        }
    }
}
