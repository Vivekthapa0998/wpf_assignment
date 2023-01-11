using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using Assignment.View;


namespace Assignment.View
{
    /// <summary>
    /// Interaction logic for ShowView.xaml
    /// </summary>
    public partial class ShowView : Window
    {
        public ShowView()
        {
            
            InitializeComponent();

            SqlConnection con = new SqlConnection("Data Source=10.50.18.16;Initial Catalog=training_db;User ID=SVC_TRANING;Password=Gemini@123");
            SqlCommand cmd = new SqlCommand("SELECT * FROM vivek_wpf_assignment",con);
            DataTable dt= new DataTable();  
            con.Open();
            SqlDataReader sdr=cmd.ExecuteReader();
            dt.Load(sdr);
            con.Close();
            dgrid.ItemsSource = dt.DefaultView;

        }

        private void Btn_Click(object sender, RoutedEventArgs e)
        {
            LoginView ob=new LoginView();
            ob.Visible = true;
            this.Visibility=Visibility.Hidden;


        }
    }
}
