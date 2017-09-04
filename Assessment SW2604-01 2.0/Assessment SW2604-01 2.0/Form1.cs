using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assessment_SW2604_01_2._0
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public float Total;
        public float cheeseburger = 6.52f;
        public float pizza = 7.53f;
        public float salad = 7.47f;
        public float coke = 2.99f;
        public float coffee = 3.89f;
        public float sundae = 4.40f;

        private void cbPriceButton_Click(object sender, EventArgs e)
        {
            if (Total > 15.00f)
            {
                MessageBox.Show("You have gone over the cash limit");
            }
            else
            {
                Total += cheeseburger;
                MessageBox.Show("Added a Cheeseburger");
            }
        }

        private void pizzaPriceButton_Click(object sender, EventArgs e)
        {
            if (Total > 15.00f)
            {
                MessageBox.Show("You have gone over the cash limit");
            }
            else
            {
                Total += pizza;
                MessageBox.Show("Added a Pizza");
            }
        }

        private void saladPriceButton_Click(object sender, EventArgs e)
        {
            if (Total > 15.00f)
            {
                MessageBox.Show("You have gone over the cash limit");
            }
            else
            {
                Total += salad;
                MessageBox.Show("Added a Salad");
            }
        }

        private void cokePriceButton_Click(object sender, EventArgs e)
        {
            if (Total > 15.00f)
            {
                MessageBox.Show("You have gone over the cash limit");
            }
            else
            {
                Total += coke;
                MessageBox.Show("Added a Coke");
            }
        }

        private void coffeePriceButton_Click(object sender, EventArgs e)
        {
            if (Total > 15.00f)
            {
                MessageBox.Show("You have gone over the cash limit");
            }
            else
            {
                Total += coffee;
                MessageBox.Show("Added a Coffee");
            }
        }

        private void icsPriceButton_Click(object sender, EventArgs e)
        {
            if (Total > 15.00f)
            {
                MessageBox.Show("You have gone over the cash limit");
            }
            else
            {
                Total += sundae;
                MessageBox.Show("Added an Ice Cream Sundae");
            }
        }

        private void orderButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You have ordered your meal");
        }

        private void priceTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You have cleared your meal");
        }
    }
}
