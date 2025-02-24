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

        private void LoadUserControl(UserControl userControl)
        {
            pl_content.Controls.Clear(); // Clear previous control
            userControl.Dock = DockStyle.Fill; // Fit the panel
            pl_content.Controls.Add(userControl); // Add new control
        }

        private void LoadAdminProfile(object sender, EventArgs e)
        {
            LoadUserControl(new frmAdminProfileUc(General.LoggedUser));
        }
    }
}
