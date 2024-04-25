using ShoppingApp.Product;
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

namespace ShoppingApp
{
    /// <summary>
    /// Interaction logic for Win.xaml
    /// </summary>
    public partial class Win : Window
    {
        public List<Class> liststring { get; set; }
        public Win()
        {
            InitializeComponent();

            liststring = new List<Class>()
          {

              new Class{ Price ="10000"},
              new Class{  Price ="20000"},
              new Class{ Price ="30000"},
              new Class{  Price ="40000"},
              new Class{ Price ="50000"},
              new Class{  Price ="60000"},
              new Class{ Price ="70000"},
              new Class{  Price ="80000"},
              new Class{ Price ="90000"},
              new Class{  Price ="100000"},
          };

            listview.ItemsSource = liststring;

            liststring = new List<Class>()
            {
                new Class  {  brand = "vivo"},
              new Class { brand = "oppo" },
               new Class { brand = "samsung"},
              new Class { brand = "Apple" },
               new Class { brand = "realme"},
              new Class { brand = "poco" }

            };
            listdata.ItemsSource = liststring;


        }

        private void btnsearch_Click(object sender, RoutedEventArgs e)
        {

        }

        private void searchbox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
