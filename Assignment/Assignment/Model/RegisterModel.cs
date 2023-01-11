using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.Model
{
    public class RegisterModel
    {
        private string Fname;
        public string _Fname
        {
            get { return Fname; }
            set { Fname = value; }
        }

        private string Lname;
        public string _Lname
        {
            get { return Lname; }
            set { Lname = value; }
        }

        private DateTime DOB;
        public DateTime _DOB 
        { get { return DOB; } 
          set { DOB= value; } 
        }

        private string Email;
        public string _Email
        {
            get { return Email; }
            set { Email = value; }
        }

        private string Gender;
        public string _Gender
        {
            get { return Gender; }
            set { Gender = value; }
        }

        private string Password;
        public string _Password
        {
            get { return Password; }
            set {  Password= value; }
        }

        private string CnfPassword;
        public string _CnfPassword
        {
            get { return CnfPassword; }
            set { CnfPassword = value; }
        }
    }
}
