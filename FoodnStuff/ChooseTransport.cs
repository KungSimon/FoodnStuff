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
    public partial class ChooseTransport : Form
    {
        private ProductManager productManager = ProductManager.GetInstance();
        public ChooseTransport()
        {
            InitializeComponent();
        }

        private void moveToTransportButton_Click(object sender, EventArgs e)
        {
            //Ska sparas här i transport ProductsOutOnDelivery?
        }

        private void shipOrderButton_Click(object sender, EventArgs e)
        {

        }

        private void listBoxAvailableTransports_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
