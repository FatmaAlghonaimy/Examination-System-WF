

using Examination_System.Business.Enums;

namespace Examination_System.Presentation.Common
{
    public partial class ToastForm : Form
    {
        int toastX;
        int toastY;
        //private  System.Windows.Forms.Timer closeTimer;

        public ToastForm(ToastType toastType, string message)
        {
            InitializeComponent();
            //InitializeTimer();
                    lb_toastMessage.Text = message;
            switch (toastType)
            {

                case ToastType.Success:
                    lb_typr.Text = "Success";
                    pl_toastcolor.BackColor = Color.FromArgb(57, 155, 53);
                    pic_toasticon.Image = Properties.Resources.check;
                   break;
                case ToastType.Error:
                    lb_toastMessage.Text = message;
                    lb_typr.Text = "Error";

                    pic_toasticon.Image = Properties.Resources.cross;
                    pl_toastcolor.BackColor = Color.FromArgb(227, 50, 45);
                    break;
                case ToastType.Warning:
                    pic_toasticon.Image = Properties.Resources.exclamation_mark;
                    pl_toastcolor.BackColor = Color.FromArgb(255, 193, 7);
                    lb_typr.Text = "Warning";
                    lb_toastMessage.Text = message;

                    break;

                case ToastType.Info:
                    lb_toastMessage.Text = message;
                    lb_typr.Text = "Info";
                    pl_toastcolor.BackColor = Color.FromArgb(91, 155, 213);
                    pic_toasticon.Image = Properties.Resources.info;


                    break;
                default:
                    break;
            }

        }

       
        private void ToastForm_Load(object sender, EventArgs e)
        {
            Position();

        }

        private void Position()
        {
            int screenWidth = Screen.PrimaryScreen.WorkingArea.Width;
            int screenHeight = Screen.PrimaryScreen.WorkingArea.Height;
            toastX = screenWidth - this.Width;
            toastY = screenHeight - this.Height + 80;

            this.Location = new Point(toastX, toastY);

        }

        private void toast_timer_Tick(object sender, EventArgs e)
        {
            toastY -= 10;
            this.Location = new Point(toastX, toastY);
            if (toastY <= Screen.PrimaryScreen.WorkingArea.Height - this.Height - 20)
            {
                toast_timer.Stop();
                toast_hide_timer.Start();

            }
        }
        int y = 100;
        private void toast_hide_timer_Tick(object sender, EventArgs e)
        {
            y--;
            if(y <= 0)
            {
                toastY += 1;
                this.Location = new Point(toastX, toastY);
                if(toastY > Screen.PrimaryScreen.WorkingArea.Height + 40)
                {
                    toast_hide_timer.Stop();
                    y = 100;
                    this.Close();
                }
            }
        }
    }
}
