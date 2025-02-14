using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Examination_System.Presentation.AdminForms
{
    public partial class CreateNewTheacher : Form
    {
        public CreateNewTheacher()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void lbl_ID_Click(object sender, EventArgs e)
        {

        }

        private void lbl_ssn_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            txb_email.Enabled = true;
        }

        private void CreateNewTheacher_Load(object sender, EventArgs e)
        {

            txb_name.Enabled = false;
            txb_email.Enabled = false;
            txb_pass.Enabled = false;
            txb_ssn.Enabled = false;
            txb_Fname.Enabled = false;
            txb_Lname.Enabled = false;
            btn_Add.Enabled = false;


        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp;*.gif";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = Image.FromFile(ofd.FileName);
            }
        }

        private void tbx_ID_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbx_ID_Click(object sender, EventArgs e)
        {
            txb_name.Enabled = true;
        }

        private void txb_email_TextChanged(object sender, EventArgs e)
        {
            txb_pass.Enabled = true;
        }

        private void txb_pass_TextChanged(object sender, EventArgs e)
        {
            txb_ssn.Enabled = true;
        }

        private void txb_ssn_TextChanged(object sender, EventArgs e)
        {
            txb_Fname.Enabled = true;
        }

        private void txb_Fname_TextChanged(object sender, EventArgs e)
        {
            txb_Lname.Enabled = true;
        }

        private void txb_Lname_TextChanged(object sender, EventArgs e)
        {
            btn_Add.Enabled = true;
        }
    }
}
