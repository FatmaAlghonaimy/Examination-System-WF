using Examination_System.Business;
using Examination_System.Business.Enums;
using Examination_System.Data_Access.Models;
using Examination_System.Presentation;

namespace Examination_System
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmStudentProfile s = new frmStudentProfile(this);
            s.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmTeacherProfile t = new frmTeacherProfile();

            t.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmAdminProfile a = new frmAdminProfile();
            a.Show();
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
                Tuple<string, User> result = UserService.Login(tx_username.Text.Trim(), tx_pass.Text.Trim());
                MessageBox.Show(result.Item1);
                General.LoggedUser = result.Item2;
                if (result.Item2.Username != null && result.Item2.ID != 0)
                {
                    this.Hide();
                    tx_pass.Text = string.Empty;
                    tx_username.Text = string.Empty;
                    if (result.Item2.UserRole == UserRole.Admin)
                    {

                        frmAdminProfile frmAdminProfile = new frmAdminProfile();
                        frmAdminProfile.Show();
                    }
                    else if (result.Item2.UserRole == UserRole.Teacher)
                    {
                        frmTeacherProfile frmTeacherProfile = new frmTeacherProfile();
                        frmTeacherProfile.Show();
                    }
                    else if (result.Item2.UserRole == UserRole.Student)
                    {
                        frmStudentProfile frmStudentProfile = new frmStudentProfile();
                        frmStudentProfile.Show();
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
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }
    }
}
