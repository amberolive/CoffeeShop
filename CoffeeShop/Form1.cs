using System;
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
        public CoffeeShopAdmin()
        {
            InitializeComponent();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutCoffeeShop about = new AboutCoffeeShop();
            about.Show();
        }

        private void countFlavorsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
