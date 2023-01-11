using Assignment.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using System.Windows;
using System.IO.Packaging;
using Assignment.Commands;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Controls;
using Assignment.View;
using System.Web.UI.WebControls;

namespace Assignment.Viewmodel
{
    public class RegisterViewModel:Window
    {

        SqlConnection con=new SqlConnection("Data Source=10.50.18.16;Initial Catalog=training_db;User ID=SVC_TRANING;Password=Gemini@123");

        private ICommand _buttonCommand;
       

        public ICommand buttonCommand 
        {
            get { return _buttonCommand; }
            set { _buttonCommand = value; }
        }
        
        public RegisterModel register { get; set; }
        public RegisterViewModel() 
        {
            
            buttonCommand = new RegisterButton(ExecuteButtonCommand, CanExecuteButtonCommand);
            register = new RegisterModel()
            {
                _DOB= new DateTime(1980,1,1)
            };
        }
       

        private void ExecuteButtonCommand(object obj)
        {
            
                try
                {
                    SqlCommand cmd = new SqlCommand("INSERT INTO vivek_wpf_assignment VALUES(@d_fname,@d_lname,@d_DOB,@d_email,@d_gender,@d_password)", con);
                    cmd.CommandType = CommandType.Text;
                    cmd.Parameters.AddWithValue("@d_fname", register._Fname);
                    cmd.Parameters.AddWithValue("@d_lname", register._Lname);
                    cmd.Parameters.AddWithValue("@d_DOB", register._DOB);
                    cmd.Parameters.AddWithValue("@d_email", register._Email);
                    cmd.Parameters.AddWithValue("@d_gender", register._Gender);
                    cmd.Parameters.AddWithValue("@d_password", register._Password);
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("registered successfully", "Saved", MessageBoxButton.OK, MessageBoxImage.Information);
                    LoginView ob1 = new LoginView();
                    ob1.Visible= true;
                    this.Visibility = Visibility.Hidden;


                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.Message);
                }
            
        }

        private string _check_inp;
        public string check_inp 
        {
            get { return _check_inp; } set { _check_inp = value; }
        }
        private bool CanExecuteButtonCommand(object obj) 
        {
             if(string.IsNullOrEmpty(register._Fname) || string.IsNullOrEmpty(register._Lname )|| string.IsNullOrEmpty(register._Email)|| string.IsNullOrEmpty(register._Gender)|| string.IsNullOrEmpty(register._Password)|| string.IsNullOrEmpty(register._CnfPassword) || !(string.Equals(register._Password,register._CnfPassword))) 
             {
                 return false;
             }
             else 
             return true; 

            
        }
        
      

    }
}
