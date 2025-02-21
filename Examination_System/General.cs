using Examination_System.Data_Access.Models;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examination_System
{
    static class General
    {
        static public User LoggedUser { get; set; }
        public static string connectionString { get; set; } = new ConfigurationBuilder().SetBasePath(Directory.GetCurrentDirectory())
                          .AddJsonFile("appSettings.json")
                          .Build().GetSection("sqlConnection").Value;
        public static string rootPath =  Directory.GetParent(Application.StartupPath).Parent.Parent.Parent.FullName;
        public static frmLogin frmLogin { get; set; }
    }
}
