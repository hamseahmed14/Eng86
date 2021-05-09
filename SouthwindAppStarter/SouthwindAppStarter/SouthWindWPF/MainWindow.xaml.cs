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
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public string cred { get; set; }
        public MainWindow()
        {
            InitializeComponent();

            Main.Content = new LogIn();

        }

        //private void Submit_Click(object sender, RoutedEventArgs e)
        //{

        //    var username = Username.Text;
        //    var password = Password.Password;

        //    AuthenticationManager auth = new AuthenticationManager();
        //    var authCred = auth.AuthIsCorrect(username, password);

        //    if (authCred == "Incorrect Credentials")
        //    {
        //        MessageBox.Show("Incorrect Credentials. Please input valid credentials");
        //        Username.Text = "";
        //        Password.Clear();
        //    }
        //    else
        //    {
        //        cred = authCred;

        //        switch (auth.GetRole(cred))
        //        {
        //            case 'C':
        //                Home windowHome = new Home();
        //                this.Close();
        //                windowHome.Show();
        //                break;
        //            case 'A':
        //                Portal windowPortal = new Portal();
        //                this.Close();
        //                windowPortal.Show();
        //                break;
        //            default:
        //                break;
        //        }
                
                
               
        //    }
            
        //}

        //private void SignUp_Click(object sender, RoutedEventArgs e)
        //{
        //    SignUp window = new SignUp();
        //    this.Close();
        //    window.Show();
        //}

        private void BtnClickLogin(object sender, RoutedEventArgs e)
        {
            Main.Content = new LogIn();
        }

        private void BtnClickRegister(object sender, RoutedEventArgs e)
        {
            Main.Content = new Registration();
        }
    }

}
