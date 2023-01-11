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
    /// Interaction logic for BindablePasswordBox.xaml
    /// </summary>
    public partial class BindablePasswordBox : UserControl
    {
        public static readonly DependencyProperty PasswordProperty= 
            DependencyProperty.Register("Password",typeof(string),typeof(BindablePasswordBox),new PropertyMetadata(string.Empty));

        public string Password
        {
            get { return (string) GetValue(PasswordProperty);  }
            set { SetValue(PasswordProperty, value); }
        }
        public BindablePasswordBox()
        {
            InitializeComponent();
            //txtpassword.PasswordChanged += OnPasswordChanged;
        }

      /*  private void OnPasswordChanged(object sender, RoutedEventArgs e)
        {
            Password = txtpassword.SecurePassword; 
        }*/
      private void passwordbox_passwordchanged(object sender, EventArgs e)
        {
            Password = txtpassword.Password;
        }

    }
}
