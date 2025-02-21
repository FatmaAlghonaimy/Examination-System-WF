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
using Examination_System.Business.Enums;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using Examination_System.Business;

namespace Examination_System.Presentation
{
    public partial class frmAdminManageTeachers : Form
    {
        //string connection_string = new ConfigurationBuilder().AddJsonFile("appSettings.json").Build().GetSection("sqlConnection1").Value;
        //SqlConnection con;
        //SqlCommand cmd;
        //SqlDataAdapter adapter;
        //DataTable table=new DataTable();

        DataTable dt = AdminManageTeacherService.GetAllTeachers((int)UserRole.Teacher);
        //BindingSource binding_source;
        //BindingNavigator binding_navigator;






        public frmAdminManageTeachers()
        {
            InitializeComponent();

            //con = new SqlConnection(connection_string);
            //cmd = new SqlCommand("SELECT * FROM Users WHERE UserRole = 1");
            //cmd.Connection = con;
            //table = new DataTable();
            //adapter = new SqlDataAdapter(cmd);
            //SqlCommandBuilder builder = new SqlCommandBuilder(adapter);
            //adapter.UpdateCommand = builder.GetUpdateCommand();
            //adapter.DeleteCommand = builder.GetDeleteCommand();
            //adapter.InsertCommand = builder.GetInsertCommand();
            //adapter.Fill(table);
            //binding_source = new BindingSource();
            //binding_source.DataSource = dt;
            //binding_navigator = new BindingNavigator(true);
            //binding_navigator.BindingSource = binding_source;



        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            new frmAdminDashboard().Show();
        }

        private void frmAdminManageTeachers_Load(object sender, EventArgs e)
        {


            dgv_Teacher.DataSource = dt;
            //Controls.Add(binding_navigator);
            //binding_navigator.Dock = DockStyle.Bottom;
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
                //DataTable dt = Business.AdminManageTeacherService.AdminManageTeacherService.GetAllTeachers((int)UserRole.Teacher);
                dgv_Teacher.DataSource = dt;
                return;
            }
            string _id = txb_search_Id.Text.Trim();
            int id;
            if (int.TryParse(_id, out id))
            {
                dgv_Teacher.DataSource = AdminManageTeacherService.Search_ById(id);
            }
            else
            {
                MessageBox.Show("No Recored is Found.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                //DataTable dt = Business.AdminManageTeacherService.AdminManageTeacherService.GetAllTeachers((int)UserRole.Teacher);
                dgv_Teacher.DataSource = dt;
            }
        }
        //public bool IsAlpha(string input)
        //{
        //    return Regex.IsMatch(input, @"^([a-zA-Z\s]*)$");
        //}
        private void SearchByName(object sender, KeyEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txb_SearchByName.Text))
            {
                //DataTable dt = Business.AdminManageTeacherService.AdminManageTeacherService.GetAllTeachers((int)UserRole.Teacher);
                dgv_Teacher.DataSource = dt;
                return;
            }
            try
            {

                string name = txb_SearchByName.Text.Trim();
                dgv_Teacher.DataSource = AdminManageTeacherService.Search_ByName(name);
            }
            catch
            {
                //DataTable dt = Business.AdminManageTeacherService.AdminManageTeacherService.GetAllTeachers((int)UserRole.Teacher);
                dgv_Teacher.DataSource = dt;
                MessageBox.Show("No Recored is Found.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }

        }

        private void txb_SearchByName_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != ' ')
            {
                e.Handled = true;
                //DataTable dt = Business.AdminManageTeacherService.AdminManageTeacherService.GetAllTeachers((int)UserRole.Teacher);
                dgv_Teacher.DataSource = dt;
                MessageBox.Show("Please enter a valid Name.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void txb_search_Id_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Please enter a valid Number.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                //DataTable dt = Business.AdminManageTeacherService.AdminManageTeacherService.GetAllTeachers((int)UserRole.Teacher);
                dgv_Teacher.DataSource = dt;
            }
        }
        private void LoadComboBoxData()
        {
            try
            {

                DataTable dt;
                dt = AdminManageTeacherService.GetAll_Courses();
                DataRow allCoursesRow = dt.NewRow();
                allCoursesRow["CourseName"] = "All Courses";
                allCoursesRow["ID"] = 0;
                dt.Rows.InsertAt(allCoursesRow, 0);
                cmb_Cources.DataSource = dt;
                cmb_Cources.DisplayMember = "CourseName";
                cmb_Cources.ValueMember = "ID";
                cmb_Cources.SelectedIndex = 0;
               

                //if (
                //cmb_Cources == null) 
                //{
                //    throw new NullReferenceException("comboBox1 is not initialized.");
                //}

                //cmb_Cources.DataSource = dt;
                //cmb_Cources.DisplayMember = "CourseName";  
                //cmb_Cources.ValueMember = "ID";   
                //cmb_Cources.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading courses: " + ex.Message);
            }
        }


        private void FilterByCources(int id)
        {
            
            try
            {

               DataTable dt = AdminManageTeacherService.Search_ByCourse(id);
                dgv_Teacher.DataSource = dt; 
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }


        private void cmb_Cources_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmb_Cources.SelectedValue == null || cmb_Cources.SelectedIndex == 0)
            {
                DataTable dt = AdminManageTeacherService.GetAllTeachers((int)UserRole.Teacher);
                dgv_Teacher.DataSource = dt;
                return;
            }
            int selectedCategory;
            if (int.TryParse(cmb_Cources.SelectedValue.ToString(), out selectedCategory))
            {
                FilterByCources(selectedCategory);
                txb_SearchByName.Clear();
                txb_search_Id.Clear();
            }
            else
            {
                return;
            }

        }

        private void txb_SearchByName_TextChanged(object sender, EventArgs e)
        {
            txb_search_Id.Clear();
            cmb_Cources.SelectedIndex = 0;
        }

        private void txb_search_Id_TextChanged(object sender, EventArgs e)
        {
            txb_SearchByName.Clear();
            cmb_Cources.SelectedIndex = 0;
        }

        private void btn_report_Click(object sender, EventArgs e)
        {
            AdminManageTeacherService.ExportToExcel(dgv_Teacher);
        }
    }
}
