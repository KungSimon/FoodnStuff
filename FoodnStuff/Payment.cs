using Microsoft.VisualBasic.ApplicationServices;
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
    public partial class Payment : Form
    {
        public Payment()
        {
            InitializeComponent();
            purchaseButton.Click += purchaseButton_Click;
        }

        private void purchaseButton_Click(object sender, EventArgs e)
        {
            
        }
            

        private void cardNumberTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void cardPinTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
