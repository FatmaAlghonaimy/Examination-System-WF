using Examination_System.Business.Enums;
using Examination_System.Business;
using Examination_System.Data_Access.Models;
using Examination_System.Presentation.Common;

namespace Examination_System.Presentation.AdminForms
{
    public partial class frmAdminProfileUc : UserControl
    {
        public static event EventHandler UserDataChanged;
        private readonly ReturnForm returnForm;
        private readonly User user = new User();

        public frmAdminProfileUc()
        {
            InitializeComponent();
            btn_save.Enabled = false;
            
            com_gender.DataSource = Enum.GetValues(typeof(Gender));
        }

        public frmAdminProfileUc(User _user) : this()
        {
            tx_email.IsPlaceHolder = false;
            tx_firstname.IsPlaceHolder = false;
            tx_lastname.IsPlaceHolder = false;
            tx_username.IsPlaceHolder = false;
            tx_password.IsPlaceHolder = false;
            tx_ssn.IsPlaceHolder = false;
            user = _user;
            UserService.SetUserImage(pic_userImg, user);
            tx_username.Text = user.Username;
            tx_email.Text = user.Email;
            tx_firstname.Text = user.FirstName;
            tx_lastname.Text = user.LastName;
            tx_password.Text = user.PasswordHash;
            tx_ssn.Text = user.SSN;
            tx_username.Text = user.Username;
            com_gender.DataSource = Enum.GetValues(typeof(Gender));
            com_gender.SelectedItem = user.Gender;
            UpdateSaveButtonState();
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            User updatedUser = new User()
            {
                ID = user.ID,
                Email = tx_email.Text.Trim(),
                FirstName = tx_firstname.Text.Trim(),
                Gender = (Gender)com_gender.SelectedItem,
                LastName = tx_lastname.Text.Trim(),
                PasswordHash = tx_password.Text.Trim(),
                SSN = tx_ssn.Text.Trim(),
                Username = tx_username.Text.Trim(),
                UserRole = user.ID == General.LoggedUser.ID ? UserRole.Admin : user.UserRole,
            };
            if (pic_userImg.Image != null)
            {
                MemoryStream stream = new MemoryStream();
                pic_userImg.Image.Save(stream, pic_userImg.Image.RawFormat);
                updatedUser.UserImg = stream.GetBuffer();
            }
            //not fount
            Tuple<string, int> result = new Tuple<string, int>("User not found", -1);
            try
            {
                result = UserService.UpdateUserData(updatedUser);
                if (result.Item2 == ((int)UserErrorMessage.Suceeded))
                {
                    if (user.ID == General.LoggedUser.ID)
                    {
                        General.LoggedUser = updatedUser;
                    }
                    new ToastForm(ToastType.Success, result.Item1).Show();
                    // Fire the static event after successfully saving user data
                    UserDataChanged?.Invoke(this, EventArgs.Empty);

                }
                else
                {
                    new ToastForm(ToastType.Error, result.Item1).Show();

                    //this.Close();
                    //if(returnForm == ReturnForm.frmAdminProfile)
                    //{
                    //    new frmAdminProfile().Show();
                    //} else if(returnForm == ReturnForm.frmAdminManageStudents)
                    //{
                    //    new frmAdminManageStudents().Show();
                    //}
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }


        private void UpdateeStudent()
        {
            User updatedUser = new User()
            {
                ID = user.ID,
                Email = tx_email.Text.Trim(),
                FirstName = tx_firstname.Text.Trim(),
                Gender = (Gender)com_gender.SelectedItem,
                LastName = tx_lastname.Text.Trim(),
                PasswordHash = tx_password.Text.Trim(),
                SSN = tx_ssn.Text.Trim(),
                Username = tx_username.Text.Trim(),
                UserRole = UserRole.Student,
            };
            if (pic_userImg.Image != null)
            {
                MemoryStream stream = new MemoryStream();
                pic_userImg.Image.Save(stream, pic_userImg.Image.RawFormat);
                updatedUser.UserImg = stream.GetBuffer();
            }
            List<int> selectedCourses = new();

            int result = UserService.CreateUpdateUser(updatedUser, selectedCourses, OperationMode.Edit);
            if (result == 1)
            {
                MessageBox.Show("Student was created successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (returnForm == ReturnForm.frmAdminManageStudents)
                {
                    //new frmAdminManageStudents().Show();
                }
            }
            else
            {

                MessageBox.Show("Student was", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btn_browse_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.Filter = ".png|*.png|.jpg|*.jpg|.jpeg|*.jpeg";

            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                pic_userImg.Image = new Bitmap(fileDialog.FileName);
            }
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            General.LoadUserControl(new WelcomeAdminControl(General.LoggedUser));
        }

        private bool AreRequiredFieldsFilled()
        {
            if (string.IsNullOrWhiteSpace(tx_username.Text.Trim()))
            {
                lb_username.Text = "Username is required *";

            }
            else
            {
                lb_username.Text = "";
            }

            if (string.IsNullOrWhiteSpace(tx_firstname.Text.Trim()))
            {
                lb_firstname.Text = "Firstname is required *";

            }
            else
            {
                lb_firstname.Text = "";
            }

            if (string.IsNullOrWhiteSpace(tx_lastname.Text.Trim()))
            {
                lb_lastname.Text = "Lastname is required *";

            }
            else
            {
                lb_lastname.Text = "";
            }

            if (string.IsNullOrWhiteSpace(tx_email.Text.Trim()))
            {
                lb_email.Text = "Email is required *";

            }
            else
            {
                lb_email.Text = "";
            }

            if (string.IsNullOrWhiteSpace(tx_password.Text.Trim()))
            {
                lb_password.Text = "Password is required *";

            }
            else
            {
                lb_password.Text = "";
            }
            if (!Utility.IsValidEmail(tx_email.Text.Trim()))
            {
                lb_email.Text = "Invalid Email";
            }
            else
            {
                lb_email.Text = "";
            }

            return !string.IsNullOrWhiteSpace(tx_username.Text.Trim()) &&
                   Utility.IsValidEmail(tx_email.Text.Trim()) &&
                   !string.IsNullOrWhiteSpace(tx_password.Text.Trim()) &&
                   !string.IsNullOrWhiteSpace(tx_firstname.Text.Trim()) &&
                   !string.IsNullOrWhiteSpace(tx_lastname.Text.Trim());
        }
        private void OnTextChanged(object sender, EventArgs e)
        {
            UpdateSaveButtonState();
        }
        private void UpdateSaveButtonState()
        {
            btn_save.Enabled = AreRequiredFieldsFilled();
        }
        private void frmAdminCreateUserUc_Load(object sender, EventArgs e)
        {
            btn_save.Enabled = AreRequiredFieldsFilled();

        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (tx_password.PasswordChar)
            {
                tx_password.PasswordChar = false;
                // change the pic to put the hide from resourses
                pic_eye.Image = Properties.Resources.hide;
            }
            else
            {
                tx_password.PasswordChar = true;
                // change the pic to put the show from resourses
                pic_eye.Image = Properties.Resources.show;
            }
        }

        private void frmAdminProfileUc_Load(object sender, EventArgs e)
        {
            //btn_save.Enabled = AreRequiredFieldsFilled();

        }
    }
}
