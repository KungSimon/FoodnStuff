namespace FoodnStuff
{
    partial class Shipping
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            chooseTransportButton = new Button();
            transportsListBox = new ListBox();
            ordersListBox = new ListBox();
            readyToBeShippedListBox = new ListBox();
            addToBeShippedButton = new Button();
            shipOrderButton = new Button();
            SuspendLayout();
            // 
            // chooseTransportButton
            // 
            chooseTransportButton.Location = new Point(61, 475);
            chooseTransportButton.Margin = new Padding(4, 4, 4, 4);
            chooseTransportButton.Name = "chooseTransportButton";
            chooseTransportButton.Size = new Size(182, 36);
            chooseTransportButton.TabIndex = 5;
            chooseTransportButton.Text = "Choose transport";
            chooseTransportButton.UseVisualStyleBackColor = true;
            chooseTransportButton.Click += chooseTransportButton_Click;
            // 
            // transportsListBox
            // 
            transportsListBox.FormattingEnabled = true;
            transportsListBox.ItemHeight = 25;
            transportsListBox.Location = new Point(391, 32);
            transportsListBox.Margin = new Padding(4, 4, 4, 4);
            transportsListBox.Name = "transportsListBox";
            transportsListBox.Size = new Size(284, 404);
            transportsListBox.TabIndex = 4;
            // 
            // ordersListBox
            // 
            ordersListBox.FormattingEnabled = true;
            ordersListBox.ItemHeight = 25;
            ordersListBox.Location = new Point(25, 32);
            ordersListBox.Margin = new Padding(4, 4, 4, 4);
            ordersListBox.Name = "ordersListBox";
            ordersListBox.Size = new Size(284, 404);
            ordersListBox.TabIndex = 3;
            // 
            // readyToBeShippedListBox
            // 
            readyToBeShippedListBox.FormattingEnabled = true;
            readyToBeShippedListBox.ItemHeight = 25;
            readyToBeShippedListBox.Location = new Point(743, 32);
            readyToBeShippedListBox.Name = "readyToBeShippedListBox";
            readyToBeShippedListBox.Size = new Size(284, 404);
            readyToBeShippedListBox.TabIndex = 8;
            // 
            // addToBeShippedButton
            // 
            addToBeShippedButton.Location = new Point(467, 475);
            addToBeShippedButton.Name = "addToBeShippedButton";
            addToBeShippedButton.Size = new Size(112, 34);
            addToBeShippedButton.TabIndex = 9;
            addToBeShippedButton.Text = "Add";
            addToBeShippedButton.UseVisualStyleBackColor = true;
            addToBeShippedButton.Click += addToBeShippedButton_Click;
            // 
            // shipOrderButton
            // 
            shipOrderButton.Location = new Point(839, 477);
            shipOrderButton.Name = "shipOrderButton";
            shipOrderButton.Size = new Size(112, 34);
            shipOrderButton.TabIndex = 10;
            shipOrderButton.Text = "Ship order";
            shipOrderButton.UseVisualStyleBackColor = true;
            shipOrderButton.Click += shipOrderButton_Click;
            // 
            // Shipping
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1105, 654);
            Controls.Add(shipOrderButton);
            Controls.Add(addToBeShippedButton);
            Controls.Add(readyToBeShippedListBox);
            Controls.Add(chooseTransportButton);
            Controls.Add(transportsListBox);
            Controls.Add(ordersListBox);
            Margin = new Padding(4, 4, 4, 4);
            Name = "Shipping";
            Text = "Shipping";
            ResumeLayout(false);
        }

        #endregion

        private Button chooseTransportButton;
        private ListBox transportsListBox;
        private ListBox ordersListBox;
        private ListBox readyToBeShippedListBox;
        private Button addToBeShippedButton;
        private Button shipOrderButton;
    }
}