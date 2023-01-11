using System;
using System.Collections.Generic;
using System.Linq;
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
    /// Interaction logic for BindableLoginPassword.xaml
    /// </summary>
    public partial class BindableLoginPassword : UserControl
    {
        public static readonly DependencyProperty PasswordProperty2 =
          DependencyProperty.Register("Password2", typeof(string), typeof(BindableLoginPassword), new PropertyMetadata(string.Empty));

        public string Password2
        {
            get { return (string)GetValue(PasswordProperty2); }
            set { SetValue(PasswordProperty2, value); }
        }
        public BindableLoginPassword()
        {
            InitializeComponent();
        }

        private void Logpasswordbox_passwordchanged(object sender, EventArgs e)
        {
            Password2 = logpassword.Password;
        }
    }
}
