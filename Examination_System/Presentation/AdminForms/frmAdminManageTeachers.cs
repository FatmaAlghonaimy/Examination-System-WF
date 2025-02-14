using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration.Json;
using Microsoft.Extensions.Configuration;
using Examination_System.Presentation.AdminForms;
using System.Text.RegularExpressions;
using System.Security.Cryptography;

namespace Examination_System.Presentation
{
    public partial class frmAdminManageTeachers : Form
    {
        string connection_string = new ConfigurationBuilder().AddJsonFile("appSettings.json").Build().GetSection("sqlConnection").Value;
        SqlConnection con;
        SqlCommand cmd;
        SqlDataAdapter adapter;
        DataTable table;
        BindingSource binding_source;
        BindingNavigator binding_navigator;






        public frmAdminManageTeachers()
        {
            InitializeComponent();

            con = new SqlConnection(connection_string);
            cmd = new SqlCommand("SELECT * FROM Users WHERE UserRole = 1");
            cmd.Connection = con;
            table = new DataTable();
            adapter = new SqlDataAdapter(cmd);
            SqlCommandBuilder builder = new SqlCommandBuilder(adapter);
            adapter.UpdateCommand = builder.GetUpdateCommand();
            adapter.DeleteCommand = builder.GetDeleteCommand();
            adapter.InsertCommand = builder.GetInsertCommand();
            adapter.Fill(table);
            binding_source = new BindingSource();
            binding_source.DataSource = table;
            binding_navigator = new BindingNavigator(true);
            binding_navigator.BindingSource = binding_source;
           


        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            new frmAdminDashboard().Show();
        }

        private void frmAdminManageTeachers_Load(object sender, EventArgs e)
        {


            dgv_Teacher.DataSource = binding_source;
            Controls.Add(binding_navigator);
            binding_navigator.Dock = DockStyle.Bottom;
            LoadComboBoxData();





        }

        private void pnl_nav_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnNew_Click(object sender, EventArgs e)
        {

            new CreateNewTheacher().Show();
        }

        private void Teacher_Info_Report(object sender, DataGridViewCellEventArgs e)
        {
            new Teacher_Info_Report().Show();
        }

        private void dgv_Teacher_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void lbl_Search_Id_Click(object sender, EventArgs e)
        {

        }

        private void SearchById(object sender, KeyEventArgs e)
        {

            if (string.IsNullOrWhiteSpace(txb_search_Id.Text))
            {
                dgv_Teacher.DataSource = table;
                return;
            }

            int _id;
            if (int.TryParse(txb_search_Id.Text, out _id))
            {
                string q = $"SearchByID {11}";
                ViewData vd = new ViewData();
                dgv_Teacher.DataSource = vd.showRecord(q);
            }
            else
            {
                MessageBox.Show("Please enter a valid numeric ID.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
        }
        public bool IsAlpha(string input)
        {
            return Regex.IsMatch(input, @"^([a-zA-Z\s]*)$");
        }
        private void SearchByName(object sender, KeyEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txb_SearchByName.Text))
            {
                dgv_Teacher.DataSource = table;
                return;
            }

            string q = $"SearchByName {txb_SearchByName.Text}";
            ViewData vd = new ViewData();
            dgv_Teacher.DataSource = vd.showRecord(q);

        }

        private void txb_SearchByName_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != ' ')
            {
                e.Handled = true;
                MessageBox.Show("Please enter a valid Name.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                dgv_Teacher.DataSource = table;
            }
        }

        private void txb_search_Id_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Please enter a valid Name.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                dgv_Teacher.DataSource = table;
            }
        }
        private void LoadComboBoxData()
        {
            //try
            //{

            using (con)
            {

                string query = "SearchByCourses";
                using (cmd = new SqlCommand(query, con))
                {

                    using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);
                        cmb_Cources.DataSource = dt;
                        cmb_Cources.DisplayMember = "CourseName";

                    }
                }
            }
            // }
            //catch (Exception ex)
            //{
            //   MessageBox.Show("Error loading courses: " + ex.Message);
            //}
        }


        private void cmb_Cources_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txb_SearchByName_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
