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
            frmTeacherProfile t = new frmTeacherProfile(this);

            t.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmAdminProfile a = new frmAdminProfile(this);
            a.Show();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }
    }
}
