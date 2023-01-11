using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Assignment.CustomControl
{
    /// <summary>
    /// Interaction logic for BindablePasswordBox1.xaml
    /// </summary>
    public partial class BindablePasswordBox1 : UserControl
    {
        public static readonly DependencyProperty PasswordProperty1 =
           DependencyProperty.Register("Password1", typeof(string), typeof(BindablePasswordBox1), new PropertyMetadata(string.Empty));

        public string Password1
        {
            get { return (string)GetValue(PasswordProperty1); }
            set { SetValue(PasswordProperty1, value); }
        }
       

        /* private void OnPasswordChanged(object sender, RoutedEventArgs e)
          {
              Password1 = txtpassword1.SecurePassword; 
          }*/
        private void passwordbox_passwordchanged1(object sender, EventArgs e)
        {
            Password1 = txtpassword1.Password;
        }

        public BindablePasswordBox1()
        {
            InitializeComponent();
        }
    }
}
