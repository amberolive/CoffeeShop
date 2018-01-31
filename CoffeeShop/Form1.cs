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

public partial class CoffeeShopAdmin : Form
    {

        public ArrayList flavors = new ArrayList();
        public ArrayList prices = new ArrayList();
        public const double SYRUP_PRICE = 2.50;

        public CoffeeShopAdmin()
        {
            InitializeComponent();

            flavors.Add("Cappuccino");
            prices.Add(4.98);

            flavors.Add("Drip");
            prices.Add(1.64);

            flavors.Add("Espresso");
            prices.Add(3.57);

            flavors.Add("French Press");
            prices.Add(5.99);

            foreach(String flavor in flavors)
            {
                cbFlavor.Items.Add(flavor);
            }
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutCoffeeShop about = new AboutCoffeeShop();
            about.Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void addFlavorToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            AddRemoveForm addRemoveForm = new AddRemoveForm(this, flavors, prices);
            addRemoveForm.Show();
        }

        private void countFlavorsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("There are " + cbFlavor.Items.Count.ToString() + " coffee flavors available.", "Number of Flavors");
        }

        public void addFlavor(String value) 
        {
            cbFlavor.Items.Add(value);
        }

        public void removeFlavor(String value)
        {
            cbFlavor.Items.Remove(value);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            foreach(String flavor in flavors)
            {
                MessageBox.Show(flavor);
            }
        }

        private void removeFlavorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (cbFlavor.SelectedIndex > -1)
            {
                DialogResult answer = MessageBox.Show("Do you want to remove " + cbFlavor.SelectedItem.ToString() + "?", 
                    "Remove Flavor", 
                    MessageBoxButtons.YesNo);
                if(answer == DialogResult.Yes)
                {
                    flavors.Remove(cbFlavor.SelectedItem.ToString());
                    prices.Remove(cbFlavor.SelectedItem.ToString());
                    removeFlavor(cbFlavor.SelectedItem.ToString());
                }
            }

            else
            {
                MessageBox.Show("Please select a flavor to remove.");
            }
            
        }

        private void clearFlavorsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult answer = MessageBox.Show("Do you want to clear the coffee flavors?", "Clear Flavors",
                    MessageBoxButtons.YesNo);

            if(answer == DialogResult.Yes)
            {
                flavors.Clear();
                prices.Clear();
                cbFlavor.Items.Clear();
            }
        }

        private int countCheckBoxes()
        {
            int numSelected = 0;

            numSelected = clbSyrup.CheckedItems.Count;

            return numSelected;
        }

        private String getCheckedSyrups()
        {
            String syrups = "";

            foreach (object syrup in clbSyrup.CheckedItems)
            {
                syrups += syrup.ToString() + "\n";
            }

            return syrups;
        }

        private double calculateTotal()
        {
            double syrupTotal = SYRUP_PRICE * countCheckBoxes();
            double total = syrupTotal + double.Parse(prices[cbFlavor.SelectedIndex].ToString());

            return total;
        }

        private void btDisplay_Click(object sender, EventArgs e)
        {
            String output = "";

            int numSelected = countCheckBoxes();

            double syrupPrice = SYRUP_PRICE * numSelected;

            if(cbFlavor.SelectedIndex > -1)
            {
                output += "Drink\n\n" + cbFlavor.SelectedItem + "\n\n";
                output += "Syrup(s)\n\n";
                output += getCheckedSyrups() + "\n\n";
                output += "Total: " + calculateTotal().ToString("C");
            }

            else
            {
                MessageBox.Show("Please select a drink.", "Error");
            }

            lbDisplayCoffee.Text = output;

            
        }
    }
}
