using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.Model
{
    public class LoginModel
    {

        private string LoginEmail;
        public string _LoginEmail
        {
            get { return LoginEmail; }
            set { LoginEmail = value; }
        }
        private string LoginPassword;
        public string _LoginPassword
        {
            get { return LoginPassword; }
            set { LoginPassword = value; }
        }


    }
}
