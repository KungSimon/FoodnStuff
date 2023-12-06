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
            button1 = new Button();
            SuspendLayout();
            // 
            // addToShippingButton
            // 
            addToShippingButton.Location = new Point(368, 206);
            addToShippingButton.Name = "addToShippingButton";
            addToShippingButton.Size = new Size(146, 29);
            addToShippingButton.TabIndex = 5;
            addToShippingButton.Text = "Add to shipping";
            addToShippingButton.UseVisualStyleBackColor = true;
            addToShippingButton.Click += addToShippingButton_Click;
            // 
            // readyToBeShippedListBox
            // 
            readyToBeShippedListBox.FormattingEnabled = true;
            readyToBeShippedListBox.ItemHeight = 20;
            readyToBeShippedListBox.Location = new Point(541, 89);
            readyToBeShippedListBox.Name = "readyToBeShippedListBox";
            readyToBeShippedListBox.Size = new Size(281, 344);
            readyToBeShippedListBox.TabIndex = 4;
            // 
            // ordersListBox
            // 
            ordersListBox.FormattingEnabled = true;
            ordersListBox.ItemHeight = 20;
            ordersListBox.Location = new Point(63, 89);
            ordersListBox.Name = "ordersListBox";
            ordersListBox.Size = new Size(281, 344);
            ordersListBox.TabIndex = 3;
            // 
            // chooseTransportButton
            // 
            chooseTransportButton.Location = new Point(530, 455);
            chooseTransportButton.Margin = new Padding(2, 2, 2, 2);
            chooseTransportButton.Name = "chooseTransportButton";
            chooseTransportButton.Size = new Size(133, 27);
            chooseTransportButton.TabIndex = 6;
            chooseTransportButton.Text = "Choose Transport";
            chooseTransportButton.UseVisualStyleBackColor = true;
            chooseTransportButton.Click += chooseTransportButton_Click;
            // 
            // button1
            // 
            button1.Location = new Point(689, 455);
            button1.Margin = new Padding(2);
            button1.Name = "button1";
            button1.Size = new Size(133, 27);
            button1.TabIndex = 7;
            button1.Text = "Send";
            button1.UseVisualStyleBackColor = true;
            // 
            // Shipping
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(884, 523);
            Controls.Add(button1);
            Controls.Add(chooseTransportButton);
            Controls.Add(addToShippingButton);
            Controls.Add(readyToBeShippedListBox);
            Controls.Add(ordersListBox);
            Name = "Shipping";
            Text = "Shipping";
            ResumeLayout(false);
        }

        #endregion

        private Button addToShippingButton;
        private ListBox readyToBeShippedListBox;
        private ListBox ordersListBox;
        private Button chooseTransportButton;
        private Button button1;
    }
}