using Examination_System.Business.Enums;
using Examination_System.Data_Access.Models;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examination_System.Data_Access
{
    public static class UserRepository
    {
        private static readonly string connectionString = new ConfigurationBuilder().SetBasePath(Directory.GetCurrentDirectory())
                          .AddJsonFile("appSettings.json")
                          .Build().GetSection("sqlConnection").Value;
        public static Tuple<int, User> GetLogin(string emailOrUsernamr, string userPassword)
        {
            User user = new User();
            int status = -1;
            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    using (SqlCommand cmd = new SqlCommand("getLogin", con))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        //input params
                        cmd.Parameters.AddWithValue("usernameOrEmail", emailOrUsernamr);
                        cmd.Parameters.AddWithValue("pass", userPassword);

                        //output params
                        SqlParameter userID = new SqlParameter("userID", SqlDbType.Int) { Direction = ParameterDirection.Output };
                        SqlParameter userRole = new SqlParameter("userRole", SqlDbType.Int) { Direction = ParameterDirection.Output };
                        SqlParameter firstName = new SqlParameter("firstName", SqlDbType.NVarChar, 100) { Direction = ParameterDirection.Output };
                        SqlParameter lastName = new SqlParameter("lastName", SqlDbType.NVarChar, 100) { Direction = ParameterDirection.Output };
                        SqlParameter username = new SqlParameter("username", SqlDbType.NVarChar, 50) { Direction = ParameterDirection.Output };
                        SqlParameter email = new SqlParameter("email", SqlDbType.NVarChar, 100) { Direction = ParameterDirection.Output };
                        SqlParameter UserImg = new SqlParameter("UserImg", SqlDbType.VarBinary, -1) { Direction = ParameterDirection.Output };
                        SqlParameter SSN = new SqlParameter("SSN", SqlDbType.NVarChar, 15) { Direction = ParameterDirection.Output };
                        SqlParameter password = new SqlParameter("password", SqlDbType.NVarChar, 255) { Direction = ParameterDirection.Output };
                        SqlParameter statusCode = new SqlParameter("status", SqlDbType.Int) { Direction = ParameterDirection.Output };

                        cmd.Parameters.AddRange(new SqlParameter[]
                        {
                        userID,
                        userRole,
                        firstName,
                        lastName,
                        username,
                        email,
                        UserImg,
                        SSN,
                        password,
                        statusCode
                        });
                        con.Open();

                        cmd.ExecuteNonQuery();
                        con.Close();
                        status = (int) statusCode.Value ;
                        if (status == 0)
                        {
                            user.Email = email.Value.ToString();
                            user.UserRole = (UserRole)(int)userRole.Value;
                            user.PasswordHash = password.Value.ToString();
                            user.SSN = SSN.Value.ToString();
                            user.FirstName = firstName.Value.ToString();
                            user.LastName = lastName.Value.ToString();
                            user.Username = username.Value.ToString();
                            user.UserImg = UserImg.Value as byte[];
                            user.ID = (int)userID.Value;

                        }
                    }
                }

                Tuple<int, User> result = new Tuple<int, User>(status, user);
                
                return result;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
