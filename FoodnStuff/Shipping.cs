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
            //Vill markera en order i orderslistbox och få upp en ledig transport i transportlistbox.
            //Vill kalla på checkcapacity för att se vilka transporter som finns.
            //Vill lopa igenom listan på tillgängliga transporter och visa dom i listboxen.

            if (ordersListBox.SelectedItem is Order order)
            {
                productManager.CheckTransportAvailability(order);
                transportsListBox.Visible = true;
                pickTransportButton.Visible = true;

                foreach (Transport transport in productManager.availableTransports)
                {
                    transportsListBox.Items.Add(transport);
                }
            }
            else
            {
                MessageBox.Show("You have to pick an order");
            }
        }

        private void pickTransportButton_Click(object sender, EventArgs e)
        {
            string? name = ordersListBox.SelectedItem as string;

            if (name != null)
            {
                readyToBeShippedListBox.Items.Add(name);
                ordersListBox.Items.Remove(name);
            }
            else
            {
                MessageBox.Show("You have to pack a transport");
            }
        }

        private void removeOrderButton_Click(object sender, EventArgs e)
        {

        }
    }
}
