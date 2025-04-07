using Examination_System.Business;
using Examination_System.Business.Enums;
using Examination_System.Data_Access.Models;
using Examination_System.Presentation;
using Examination_System.Presentation.StudentForms;
using Examination_System.Presentation.AdminForms;
using Examination_System.Presentation.Common;

namespace Examination_System
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
            tx_pass.PasswordChar = true;
        }

       
        private void frmLogin_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void btn_login_click(object sender, EventArgs e)
        {
            try
            {
                Tuple<int, User> result = UserService.Login(tx_username.Text.Trim(), tx_pass.Text.Trim());
                switch (result.Item1)
                {
                    case 0:
                        new ToastForm(ToastType.Success, "Login successful.").Show();
                        break;
                    case 1:
                        new ToastForm(ToastType.Error, "Invalid username or email.").Show();
                        break;
                    case 2:
                        new ToastForm(ToastType.Error, "Incorrect password.").Show();
                        break;
                    default:
                        new ToastForm(ToastType.Error, "Unknown error.").Show();
                        break;
                }

                General.LoggedUser = result.Item2;
                if (result.Item2.Username != null && result.Item2.ID != 0)
                {
                    this.Hide();
                    tx_pass.Text = string.Empty;
                    tx_username.Text = string.Empty;
                    if (result.Item2.UserRole == UserRole.Admin)
                    {

                        frmAdmin frmAdmin = new frmAdmin();
                        frmAdmin.Show();
                    }
                    else if (result.Item2.UserRole == UserRole.Teacher)
                    {
                        frmTeacher frmTeacher = new frmTeacher();
                        frmTeacher.Show();
                    }
                    else if (result.Item2.UserRole == UserRole.Student)
                    {
                        frmStudent frmStudent = new frmStudent();
                        frmStudent.Show();
                    }
                }
                else
                {
                    tx_pass.Text = string.Empty;
                    tx_username.Text = string.Empty;
                }
            }
            catch (Exception ex)
            {
                new ToastForm(ToastType.Error, ex.Message).Show();
                throw;
            }
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void btn_login_MouseEnter(object sender, EventArgs e)
        {
            btn_login.BackColor = Color.FromArgb(219, 68, 68);
            btn_login.ForeColor = Color.White;
        }

        private void btn_login_MouseLeave(object sender, EventArgs e)
        {
            btn_login.ForeColor = Color.FromArgb(219, 68, 68);
            btn_login.BackColor = Color.Transparent;

        }

        
    }
}
