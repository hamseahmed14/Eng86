using SouthWindBusiness;
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

namespace SouthWindWPF
{
    /// <summary>
    /// Interaction logic for LogIn.xaml
    /// </summary>
    public partial class LogIn : Page
    {
        public string Cred { get; set; }

        public LogIn()
        {
            InitializeComponent();
        }

          private void SignUp_Click(object sender, RoutedEventArgs e)
        {

            var username = Username.Text;
            var password = Password.Password;

            AuthenticationManager auth = new AuthenticationManager();
            var authCred = auth.AuthIsCorrect(username, password);

            if (authCred == "Incorrect Credentials")
            {
                MessageBox.Show("Incorrect Credentials. Please input valid credentials");
                Username.Text = "";
                Password.Clear();
            }
            else
            {
                Cred = authCred;

                switch (auth.GetRole(Cred))
                {
                    case 'C':
                        Home windowHome = new Home();
                        Application.Current.MainWindow.Close();
                        windowHome.Show();
                        break;
                    case 'A':
                        Portal windowPortal = new Portal();
                        Application.Current.MainWindow.Close();
                        windowPortal.Show();
                        break;
                    default:
                        break;
                }



            }

        }

       
        

        //private void SignUp_Click(object sender, RoutedEventArgs e)
        //{
        //    SignUp window = new SignUp();
        //    th.Close();
        //    window.Show();
        //}
    }
}
