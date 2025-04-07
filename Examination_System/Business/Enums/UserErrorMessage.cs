using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examination_System.Business.Enums
{
    
    public enum UserErrorMessage
    {
        NotFound = -1,
        NotApplied = 0,
        Suceeded = 1,
        NotUniqueUsername = -2,
        NotUniqueEmail = -3,
        NotUniqueSSN = -4,
        ConstraintViolation = -5,

    }
}
