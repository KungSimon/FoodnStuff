using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.DataFormats;

namespace FoodnStuff
{
    public partial class Shipping : Form
    {
        private ProductManager productManager = ProductManager.GetInstance();
        public Shipping()
        {
            InitializeComponent();

            ordersListBox.DisplayMember = "Name";
            ordersListBox.DataSource = new BindingSource(productManager.Orders, null);
            
        }
        private void shipOrderButton_Click(object sender, EventArgs e)
        {
            //Kallar på funktionen send
        }

        private void removeFromReadyToBeShippedButton_Click(object sender, EventArgs e)
        {
            //Flyttar tillbaka ordern till listan av ordrar
        }
        private void pickOrderButton_Click(object sender, EventArgs e)
        {
            Order test = ordersListBox.SelectedItem as Order;

            if (test != null)
            {
                productManager.CheckTransportAvailability(test);
                transportsListBox.Visible = true;
                pickTransportButton.Visible = true;
                label2.Visible = true;

                transportsListBox.DisplayMember = "Name";
                transportsListBox.DataSource = new BindingSource(productManager.availableTransports, null);
            }
            else
            {
                MessageBox.Show("You have to pick an order");
            }
        }

        private void pickTransportButton_Click(object sender, EventArgs e)
        {
            Order selectedOrder = ordersListBox.SelectedItem as Order;

            if (selectedOrder != null)
            {
                Transport selectedTransport = transportsListBox.SelectedItem as Transport;

                if (selectedTransport != null)
                {
                    readyToBeShippedListBox.Items.Add(selectedOrder); 
                    productManager.Orders.Remove(selectedOrder);
                    ordersListBox.DataSource = null;
                    ordersListBox.DataSource = new BindingSource(productManager.Orders, null);

                    readyToBeShippedListBox.Visible = true;
                    shipOrderButton.Visible = true;
                    label3.Visible = true;

                    productManager.LoadTansport(selectedTransport, selectedOrder);

                    if (selectedTransport.Capacity == 0)
                    {
                        productManager.availableTransports.Remove(selectedTransport);

                        transportsListBox.DataSource = null;
                        transportsListBox.DataSource = new BindingSource(productManager.availableTransports, null);
                    }
                }
                else
                {
                    MessageBox.Show("You have to pick a transport");
                }
            }
            else
            {
                MessageBox.Show("You have to pick an order");
            }
        }

        private void removeOrderButton_Click(object sender, EventArgs e)
        {

        }
    }
}
