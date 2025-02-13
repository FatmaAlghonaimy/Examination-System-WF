using Examination_System.Data_Access;
using Examination_System.Data_Access.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examination_System.Business
{
    public static class UserService
    {
        public static Tuple<string, User> Login(string usernameOrEmail, string password)
        {
			try
			{
                Tuple<int, User> result = UserRepository.GetLogin(usernameOrEmail, password);
                switch (result.Item1)
                {
                    case 0:
                        return (new Tuple<string, User>("Login successful.", result.Item2));
                    case 1:
                        return (new Tuple<string, User>("Invalid username or email.", result.Item2));
                    case 2:
                        return (new Tuple<string, User>("Incorrect password.", result.Item2));
                    default:
                        return (new Tuple<string, User>("Unknown error.", result.Item2));
                }
            }
			catch (Exception ex)
			{

				throw ex;
			}
        }

        public static void Logout()
        {
            General.LoggedUser = null;
        }
    }
}
