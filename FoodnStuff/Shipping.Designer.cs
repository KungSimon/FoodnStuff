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
            addToShippingButton = new Button();
            readyToBeShippedListBox = new ListBox();
            ordersListBox = new ListBox();
            chooseTransportButton = new Button();
            SuspendLayout();
            // 
            // addToShippingButton
            // 
            addToShippingButton.Location = new Point(460, 258);
            addToShippingButton.Margin = new Padding(4);
            addToShippingButton.Name = "addToShippingButton";
            addToShippingButton.Size = new Size(182, 36);
            addToShippingButton.TabIndex = 5;
            addToShippingButton.Text = "Add to shipping";
            addToShippingButton.UseVisualStyleBackColor = true;
            addToShippingButton.Click += addToShippingButton_Click;
            // 
            // readyToBeShippedListBox
            // 
            readyToBeShippedListBox.FormattingEnabled = true;
            readyToBeShippedListBox.ItemHeight = 25;
            readyToBeShippedListBox.Location = new Point(676, 111);
            readyToBeShippedListBox.Margin = new Padding(4);
            readyToBeShippedListBox.Name = "readyToBeShippedListBox";
            readyToBeShippedListBox.Size = new Size(350, 429);
            readyToBeShippedListBox.TabIndex = 4;
            // 
            // ordersListBox
            // 
            ordersListBox.FormattingEnabled = true;
            ordersListBox.ItemHeight = 25;
            ordersListBox.Location = new Point(79, 111);
            ordersListBox.Margin = new Padding(4);
            ordersListBox.Name = "ordersListBox";
            ordersListBox.Size = new Size(350, 429);
            ordersListBox.TabIndex = 3;
            // 
            // chooseTransportButton
            // 
            chooseTransportButton.Location = new Point(780, 584);
            chooseTransportButton.Name = "chooseTransportButton";
            chooseTransportButton.Size = new Size(166, 34);
            chooseTransportButton.TabIndex = 6;
            chooseTransportButton.Text = "Choose Transport";
            chooseTransportButton.UseVisualStyleBackColor = true;
            chooseTransportButton.Click += chooseTransportButton_Click;
            // 
            // Shipping
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1105, 654);
            Controls.Add(chooseTransportButton);
            Controls.Add(addToShippingButton);
            Controls.Add(readyToBeShippedListBox);
            Controls.Add(ordersListBox);
            Margin = new Padding(4);
            Name = "Shipping";
            Text = "Shipping";
            ResumeLayout(false);
        }

        #endregion

        private Button addToShippingButton;
        private ListBox readyToBeShippedListBox;
        private ListBox ordersListBox;
        private Button chooseTransportButton;
    }
}