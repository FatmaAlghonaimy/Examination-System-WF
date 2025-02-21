using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration.Json;
using Examination_System.Presentation.AdminForms;
using System.Data;
using System.Text.RegularExpressions;




namespace Examination_System.Presentation.AdminForms
{
    internal class ViewData
    {
        string connection_string = new ConfigurationBuilder().AddJsonFile("appSettings.json").Build().GetSection("sqlConnection").Value;
        

        public ViewData()
        {
            
        }

        
        
        
        public DataTable showRecord(string query, int id)
        {

            DataTable dt = new DataTable();
            SqlConnection con = new SqlConnection(connection_string);
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("id", id);
            try
            {     
                SqlDataAdapter adapter = new(cmd);
                adapter.Fill(dt);
                
            }
            catch (Exception)
            {
                MessageBox.Show("No Recored is Found!", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return new DataTable();
            }

            return dt;
        }

        public DataTable showRecord(string query, string name)
        {

            DataTable dt = new DataTable();
            SqlConnection con = new SqlConnection(connection_string);
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("name", name);
            try
            {
                SqlDataAdapter adapter = new(cmd);
                adapter.Fill(dt);

            }
            catch (Exception)
            {
                MessageBox.Show("No Recored is Found!", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return new DataTable();
            }

            return dt;
        }

    }
}
