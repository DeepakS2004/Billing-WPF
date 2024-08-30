using System.Text;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace jsbilling
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    { 
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnvis_Click(object sender, RoutedEventArgs e)
        {
            string value = btnvis.Content.ToString();
           if(value =="-" )
            {
                btnvis.Content = "+";
                spvou.Visibility = Visibility.Collapsed;
            }
           else
            {
                btnvis.Content = "-";
                spvou.Visibility = Visibility.Visible;
            }
        }
        private void txttot_TextChanged(object sender, TextChangedEventArgs e)
        {
            if(txttot.Text!="")
            {
                btnvis.Visibility = Visibility.Visible;
                spvou.Visibility= Visibility.Visible;
                spgrand.Visibility= Visibility.Visible;
            }
            else
            {
                btnvis.Visibility = Visibility.Collapsed;
                spvou.Visibility = Visibility.Collapsed;
                spgrand.Visibility = Visibility.Collapsed;
            }

        }

        private void txtpro_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (txtpro.Text== "apple")
            {
                txtprice.Text = "50";
            }
            if (txtpro.Text == "orange")
            {
                txtprice.Text = "70";
            }
            if (txtpro.Text == "pomogranate")
            {
                txtprice.Text = "130";
            }
            if (txtpro.Text == "watermelon")
            {
                txtprice.Text = "40";
            }
            if(txtpro.Text == "pineapple")
            {
                txtprice.Text = "120";
            }
            if (txtpro.Text == "muskmelon")
            {
                txtprice.Text = "70";
            }

        }

        private void txtpro1_TextChanged(object sender, TextChangedEventArgs e)
        {

            if (txtpro1.Text == "apple")
            {
                txtprice1.Text = "50";
            }
            if (txtpro1.Text == "orange")
            {
                txtprice1.Text = "70";
            }
            if (txtpro1.Text == "pomogranate")
            {
                txtprice1.Text = "130";
            }
            if (txtpro1.Text == "watermelon")
            {
                txtprice1.Text = "40";
            }
            if (txtpro1.Text == "pineapple")
            {
                txtprice1.Text = "120";
            }
            if (txtpro1.Text == "muskmelon")
            {
                txtprice1.Text = "70";
            }

        }

        private void txtpro2_TextChanged(object sender, TextChangedEventArgs e)
        {

            if (txtpro2.Text == "apple")
            {
                txtprice2.Text = "50";
            }
            if (txtpro2.Text == "orange")
            {
                txtprice2.Text = "70";
            }
            if (txtpro2.Text == "pomogranate")
            {
                txtprice2.Text = "130";
            }
            if (txtpro2.Text == "watermelon")
            {
                txtprice2.Text = "40";
            }
            if (txtpro2.Text == "pineapple")
            {
                txtprice.Text = "120";
            }
            if (txtpro2.Text == "muskmelon")
            {
                txtprice2.Text = "70";
            }

        }

        private void txtpro3_TextChanged(object sender, TextChangedEventArgs e)
        {

            if (txtpro3.Text == "apple")
            {
                txtprice3.Text = "50";
            }
            if (txtpro3.Text == "orange")
            {
                txtprice3.Text = "70";
            }
            if (txtpro3.Text == "pomogranate")
            {
                txtprice3.Text = "130";
            }
            if (txtpro3.Text == "watermelon")
            {
                txtprice3.Text = "40";
            }
            if (txtpro3.Text == "pineapple")
            {
                txtprice3.Text = "120";
            }
            if (txtpro3.Text == "muskmelon")
            {
                txtprice3.Text = "70";
            }

        }

        private void txtpro4_TextChanged(object sender, TextChangedEventArgs e)
        {

            if (txtpro4.Text == "apple")
            {
                txtprice4.Text = "50";
            }
            if (txtpro4.Text == "orange")
            {
                txtprice4.Text = "70";
            }
            if (txtpro4.Text == "pomogranate")
            {
                txtprice4.Text = "130";
            }
            if (txtpro4.Text == "watermelon")
            {
                txtprice4.Text = "40";
            }
            if (txtpro4.Text == "pineapple")
            {
                txtprice4.Text = "120";
            }
            if (txtpro4.Text == "muskmelon")
            {
                txtprice4.Text = "70";
            }

        }
        private void txtqua_MouseLeave(object sender, MouseEventArgs e)
        {
            if (txtqua.Text != "")
            {
                int quantity = Convert.ToInt32(txtqua.Text);
                int price = Convert.ToInt32(txtprice.Text);
                int amount = quantity * price;
                txtamt.Text = amount.ToString();
            }

        }

        private void txtqua1_MouseLeave(object sender, MouseEventArgs e)
        {
            
            if (txtqua1.Text != "")
            {
                int quantity = Convert.ToInt32(txtqua1.Text);
                int price = Convert.ToInt32(txtprice1.Text);
                int amount = quantity * price;
                txtamt1.Text = amount.ToString();
            }

        }
        private void txtqua2_MouseLeave(object sender, MouseEventArgs e)
        {
            
            if (txtqua2.Text != "")
            {
                int quantity = Convert.ToInt32(txtqua2.Text);
                int price = Convert.ToInt32(txtprice2.Text);
                int amount = quantity * price;
                txtamt2.Text = amount.ToString();
            }

        }

        private void txtqua3_MouseLeave(object sender, MouseEventArgs e)
        {
            if (txtqua3.Text != "")
            {

                int quantity = Convert.ToInt32(txtqua3.Text);
                int price = Convert.ToInt32(txtprice3.Text);
                int amount = quantity * price;
                txtamt3.Text = amount.ToString();
            }

        }

        private void txtqua4_MouseMove(object sender, MouseEventArgs e)
        {
            
            if (txtqua4.Text != "")
            {
                int quantity = Convert.ToInt32(txtqua4.Text);
                int price = Convert.ToInt32(txtprice4.Text);
                int amount = quantity * price;
                txtamt4.Text = amount.ToString();
            }
            if(txtqua4.Text !="")
            {
                int amt1 = Convert.ToInt32(txtamt1.Text);
                int amt2 = Convert.ToInt32(txtamt2.Text);
                int amt3 = Convert.ToInt32(txtamt3.Text);
                int amt4 = Convert.ToInt32(txtamt4.Text);
                int total = amt1 + amt2+ amt3+ amt4;
                txttot.Text = total.ToString();

            }
        }

        private void txtvou_MouseLeave(object sender, MouseEventArgs e)
        {
            
            if (txtvou.Text != "")
            {
                int total = Convert.ToInt32(txttot.Text);
                int grand1 = total / 100 *10;
                int grand = total - grand1;
                txtgrand.Text = grand.ToString();
            }

        }
    }
}