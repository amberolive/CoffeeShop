using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoffeeShop
{
    public partial class AddRemoveForm : Form
    {

        ArrayList flavors;
        ArrayList prices;
        CoffeeShopAdmin coffeeShop;

        public AddRemoveForm(CoffeeShopAdmin cShop, ArrayList flavors, ArrayList prices)
        {
            InitializeComponent();

            this.flavors = flavors;
            this.prices = prices;
            coffeeShop = cShop as CoffeeShopAdmin;
        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            String flavor = tbFlavor.Text.ToLower();
            String strPrice = mtbPrice.Text.Replace("$", "");

            MessageBox.Show(flavor);
            MessageBox.Show(flavors.Contains(flavor).ToString());
            MessageBox.Show(strPrice);

            double price;

            if (flavor != null && flavor != "")
            {
                if (!flavors.Contains(flavor))
                {

                    if (double.TryParse(strPrice, out price))
                    {
                        prices.Add(price);
                        flavors.Add(flavor);
                        coffeeShop.addFlavor(flavor);
                    }

                    else
                    {
                        MessageBox.Show("Please enter a price.", "Error");
                    }
                }

                else
                {
                    MessageBox.Show("Flavor has already been added.", "Error");
                }
            }

            else
            {
                MessageBox.Show("Please enter a flavor.", "Error");
            }
        }

        private void btExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
