using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace winForm
{
    internal class RegisterClass
    {
        public int UserID { get; set; }
        public string LoginName { get; set; }
        public string PasswordHash { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string EmpType { get; set; }
    }
}
