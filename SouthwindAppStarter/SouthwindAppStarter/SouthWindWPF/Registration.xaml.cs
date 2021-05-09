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
    /// Interaction logic for Registration.xaml
    /// </summary>
    public partial class Registration : Page
    {
        public Registration()
        {
            InitializeComponent();
        }

        private void Submit_Click(object sender, RoutedEventArgs e)
        {
            var username = Username.Text;
            var contactName = Fullname.Text;
            var city = City.Text;
            var country = Country.Text;
            var postalcode = Postalcode.Text;
            var password = Password.Password;
            var confirmPassword = ConfirmPassword.Password;

            if
                (
               String.IsNullOrEmpty(username) ||
               String.IsNullOrEmpty(contactName) ||
                String.IsNullOrEmpty(city) ||
               String.IsNullOrEmpty(country) ||
                String.IsNullOrEmpty(postalcode) ||
                String.IsNullOrEmpty(password) ||
                String.IsNullOrEmpty(confirmPassword)
                )
            {
                MessageBox.Show("Fill in all fields", "Empty Fields");
            }
            else
            {
                if (password == confirmPassword)
                {

                    CRUDManager cm = new CRUDManager();
                    cm.CreateCustomer(username, contactName, city, country, postalcode, username, password, 'C');
                }
                else
                {
                    MessageBox.Show("Confirmed password does not match password", "Incorrect Password");
                }
            }
        }
    }
}
