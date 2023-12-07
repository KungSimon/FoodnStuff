using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FoodnStuff
{
    public partial class Shipping : Form
    {
        private ProductManager productManager = ProductManager.GetInstance();
        public Shipping()
        {
            InitializeComponent();

            foreach (Order order in productManager.Orders)
            {
                ordersListBox.Items.Add(order);
            }
        }
        private void chooseTransportButton_Click(object sender, EventArgs e)
        {
            string? name = ordersListBox.SelectedItem as string;
            if (name != null)
            {
                transportsListBox.Items.Add(name);
                ordersListBox.Items.Remove(name);
            }
            else
            {
                MessageBox.Show("You have to pick an order");
            }
        }
        private void addToBeShippedButton_Click(object sender, EventArgs e)
        {

        }

        private void shipOrderButton_Click(object sender, EventArgs e)
        {

        }
    }
}
