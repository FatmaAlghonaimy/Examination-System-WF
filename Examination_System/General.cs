using Examination_System.Data_Access.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examination_System
{
    static class General
    {
       static public User LoggedUser { get; set; } = new User() { Id = 1 };
    }
}
