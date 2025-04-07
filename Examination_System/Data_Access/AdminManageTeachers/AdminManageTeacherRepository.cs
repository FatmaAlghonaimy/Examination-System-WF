using System.Data;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;

namespace Examination_System.Data_Access
{
    internal class AdminManageTeacherRepository
    {
        static string connection_string = General.connectionString;
        static SqlConnection con = new SqlConnection(connection_string);
        public static DataTable select(SqlCommand _cmd)
        {
            DataTable dt =new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(_cmd);
            _cmd.Connection= con;
            adapter.Fill(dt);
            return dt;
        }
     
        public static int DML(SqlCommand _cmd)
        {
            int result = 0;
            _cmd.Connection = con;
            con.Open();
            result = _cmd.ExecuteNonQuery();
            con.Close();
            return result;
        }
    }
}
