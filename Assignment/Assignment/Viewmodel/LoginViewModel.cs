using Assignment.Commands;
using Assignment.Model;
using Assignment.View;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using System.Data;
using System.Web.UI.WebControls;

namespace Assignment.Viewmodel
{
    public class LoginViewModel:Window
    {
        SqlConnection con = new SqlConnection("Data Source=10.50.18.16;Initial Catalog=training_db;User ID=SVC_TRANING;Password=Gemini@123");

        private ICommand _LoginCommand;
        private ICommand _RegCommand;

        public ICommand LoginCommand
        {
            get { return _LoginCommand; }
            set { _LoginCommand = value; }
        }

        public ICommand RegCommand
        {
            get { return _RegCommand; }
            set { _RegCommand = value; }
        }

        

        public LoginModel Login1 { get; set; }
       // public Visibility Visibility { get; private set; }

        public LoginViewModel()
        {
            LoginCommand = new RegisterButton(ExecuteButtonCommand1, CanExecuteButtonCommand1);
            RegCommand = new RegisterButton(ExecuteButtonCommand2, CanExecuteButtonCommand2);
            Login1 = new LoginModel();
        }

        private void ExecuteButtonCommand2(object obj)
        {
            RegisterView ob = new RegisterView();
            this.Visibility = Visibility.Hidden;
            ob.Show();
           
            
              

        }
        private bool CanExecuteButtonCommand2(object obj)
        {
            return true;
        }

        private void ExecuteButtonCommand1(object obj1)
        {
            try
            {
                if(con.State == ConnectionState.Closed)
                    con.Open();
                string query = "SELECT COUNT(1) FROM vivek_wpf_assignment WHERE d_email= @d_email AND d_password= @d_password";
                SqlCommand sqlcmd= new SqlCommand(query, con);
                sqlcmd.CommandType= CommandType.Text;
                sqlcmd.Parameters.AddWithValue("@d_email",Login1._LoginEmail);
                sqlcmd.Parameters.AddWithValue("@d_password", Login1._LoginPassword);
                int count= Convert.ToInt32(sqlcmd.ExecuteScalar());
                if (count == 1)
                {
                    MessageBox.Show("login successful");
                    ShowView ob1= new ShowView();
                    ob1.Show();
                    this.Close();

                }
                else
                {
                    MessageBox.Show("incorrect details");
                }
            }
            catch(SqlException ex) 
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }
        }

        private bool CanExecuteButtonCommand1(object obj1)
        {
            if (string.IsNullOrEmpty(Login1._LoginEmail) || string.IsNullOrEmpty(Login1._LoginPassword) )
            {
                return false;
            }
            else
                return true;
        }
    }
}
