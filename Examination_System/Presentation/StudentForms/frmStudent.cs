﻿using Examination_System.Business;
using Examination_System.Presentation.AdminForms;
using Examination_System.Presentation.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Examination_System.Presentation.StudentForms
{
    public partial class frmStudent : Form
    {
        public frmStudent()
        {
            InitializeComponent();
            UserService.SetUserImage(pic_userImg, General.LoggedUser);
            lb_name.Text = General.LoggedUser.Username;
            frmAdminProfileUc.UserDataChanged += FrmAdminProfileUc_UserDataChanged;
            General.pl_mainContent = pl_content;
            General.LoadUserControl(new frmStudentHomeUc(General.LoggedUser));
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
            General.LoadUserControl(new frmStudentHomeUc(General.LoggedUser));
        }



        private void LoadAdminProfile(object sender, EventArgs e)
        {
            General.LoadUserControl(new frmAdminProfileUc(General.LoggedUser));
        }

        private void button3_Click(object sender, EventArgs e)
        {
            General.LoadUserControl(new frmStudentExamsHistoryUc());
        }

        private void button4_Click(object sender, EventArgs e)
        {
            General.LoadUserControl(new frmAdminManageTeachersUc());
        }

        private void button7_Click(object sender, EventArgs e)
        {
            General.LoadUserControl(new frmAdminStudentsReportUc());

        }

        private void button6_Click(object sender, EventArgs e)
        {
            General.LoadUserControl(new frmStudentCourcesUc(General.LoggedUser.ID));
        }

        private void button5_Click(object sender, EventArgs e)
        {
            General.LoadUserControl(new frmStudentExamUc(General.LoggedUser.ID));
        }

        private void button8_Click(object sender, EventArgs e)
        {
            UserService.Logout();
            this.Close();
            new ToastForm(Business.Enums.ToastType.Success, "Logged out Successfully").Show();
            General.frmLogin.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            General.LoadUserControl(new frmAdminActivityUc());
        }
    }
}
