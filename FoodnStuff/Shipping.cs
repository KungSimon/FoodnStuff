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

        private void ordersListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

            //Vill markera en order i orderslistbox och få upp en ledig transport i transportlistbox.
            //Vill kalla på checkcapacity för att se vilka transporter som finns.
            //Vill lopa igenom listan på tillgängliga transporter och visa dom i listboxen.

            //if (ordersListBox.SelectedItem is Order order)
            //{
            //    productManager.CheckCapacity(order);
            //    transportsListBox.Visible = true;
            //    addToBeShippedButton.Visible = true;
            //    foreach (Transport transport in productManager.availableTransports)
            //    {
            //        transportsListBox.Items.Add(transport);
            //    }
            //}
            //else
            //{
            //    MessageBox.Show("You have to pick an order");
            //}
        }

        private void pickOrderButton_Click(object sender, EventArgs e)
        {
            Order test = ordersListBox.SelectedItem as Order;

            if (test != null)
            {
                productManager.CheckTransportAvailability(test);
                transportsListBox.Visible = true;
                pickTransportButton.Visible = true;

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
                    productManager.Orders.Remove(selectedOrder);  // Ta bort från den underliggande datan

                    readyToBeShippedListBox.Visible = true;
                    shipOrderButton.Visible = true;

                    // Uppdatera ordersListBox genom att sätta om dess DataSource
                    ordersListBox.DataSource = null;
                    ordersListBox.DataSource = new BindingSource(productManager.Orders, null);

                    // Ladda transporten med den valda ordern
                    productManager.LoadTansport(selectedTransport, selectedOrder);
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
