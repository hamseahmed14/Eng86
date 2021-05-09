using SouthwindApp;
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
using System.Windows.Shapes;

namespace SouthWindWPF
{
    /// <summary>
    /// Interaction logic for Home.xaml
    /// </summary>
    public partial class Home : Window
    {
        private CRUDManager _crudManager = new CRUDManager();
        private List<Product> _basket = new List<Product>();
        private string cred;
        
        public Home()
        {
            InitializeComponent();
            PopulateListBox();
            cred = ((MainWindow)Application.Current.MainWindow).cred;        
        }

        private void PopulateListBox()
        {
            ListBoxProduct.ItemsSource = _crudManager.RetrieveAllProducts();
        }

        public void PopulateProductFields()
        {
            List<int> quantity = new List<int>();
            if (_crudManager.SelectedProduct != null)
            {
                var basePrice = Double.Parse(_crudManager.SelectedProduct.ProductPrice).ToString("C");
                Price.Content = basePrice;
                TotalPrice.Content = 0.ToString("C");

                for (int i = 1; i <= _crudManager.SelectedProduct.Quantity; i++)
                {
                    quantity.Add(i);
                }
                ComboBox.ItemsSource = quantity;
            }
        }

        private void ListBoxProduct_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (ListBoxProduct.SelectedItem != null)
            {
                _crudManager.SetSelectedProduct(ListBoxProduct.SelectedItem);
                PopulateProductFields();
            }
        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if( ComboBox.SelectedItem != null)
            {
                var basePrice = Double.Parse(_crudManager.SelectedProduct.ProductPrice);
                var currency = basePrice * Int32.Parse(ComboBox.SelectedItem.ToString());
                TotalPrice.Content = currency.ToString("C");
            }
        }

        private void ListBoxBasket_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void AddBasket_Click(object sender, RoutedEventArgs e)
        {
            if (ComboBox != null)
            {
                for (int i = 0; i < Int32.Parse(ComboBox.SelectedItem.ToString()); i++)
                {
                    _basket.Add(_crudManager.SelectedProduct);
                    ListBoxBasket.ItemsSource = new List<string> { "", "" };
                    ListBoxBasket.ItemsSource = _basket;
                }
            }

            ComboBox.SelectedItem = null;
            ListBoxBasket.ItemsSource = _basket;
          
        }

        private void RemoveItemFromBasket_Click(object sender, RoutedEventArgs e)
        {
            _crudManager.SetSelectedProduct(ListBoxBasket.SelectedItem);
            _basket.Remove(_crudManager.SelectedProduct);
            ListBoxBasket.Items.Refresh();
        }

        private void CheckoutButton_Click(object sender, RoutedEventArgs e)
        {
          var input =  _crudManager.CreateOrder(_basket,cred);
            MessageBox.Show(input,"Receipt");

          
        }
    }
}
