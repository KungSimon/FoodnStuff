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
            pickOrderButton = new Button();
            transportsListBox = new ListBox();
            ordersListBox = new ListBox();
            readyToBeShippedListBox = new ListBox();
            pickTransportButton = new Button();
            shipOrderButton = new Button();
            removeFromReadyToBeShippedButton = new Button();
            removeOrderButton = new Button();
            SuspendLayout();
            // 
            // pickOrderButton
            // 
            pickOrderButton.Location = new Point(188, 471);
            pickOrderButton.Margin = new Padding(4);
            pickOrderButton.Name = "pickOrderButton";
            pickOrderButton.Size = new Size(121, 36);
            pickOrderButton.TabIndex = 5;
            pickOrderButton.Text = "Pick order";
            pickOrderButton.UseVisualStyleBackColor = true;
            pickOrderButton.Click += pickOrderButton_Click;
            // 
            // transportsListBox
            // 
            transportsListBox.FormattingEnabled = true;
            transportsListBox.ItemHeight = 25;
            transportsListBox.Location = new Point(391, 32);
            transportsListBox.Margin = new Padding(4);
            transportsListBox.Name = "transportsListBox";
            transportsListBox.Size = new Size(284, 404);
            transportsListBox.TabIndex = 4;
            transportsListBox.Visible = false;
            // 
            // ordersListBox
            // 
            ordersListBox.FormattingEnabled = true;
            ordersListBox.ItemHeight = 25;
            ordersListBox.Location = new Point(25, 32);
            ordersListBox.Margin = new Padding(4);
            ordersListBox.Name = "ordersListBox";
            ordersListBox.Size = new Size(284, 404);
            ordersListBox.TabIndex = 3;
            ordersListBox.SelectedIndexChanged += ordersListBox_SelectedIndexChanged;
            // 
            // readyToBeShippedListBox
            // 
            readyToBeShippedListBox.FormattingEnabled = true;
            readyToBeShippedListBox.ItemHeight = 25;
            readyToBeShippedListBox.Location = new Point(743, 32);
            readyToBeShippedListBox.Name = "readyToBeShippedListBox";
            readyToBeShippedListBox.Size = new Size(284, 404);
            readyToBeShippedListBox.TabIndex = 8;
            readyToBeShippedListBox.Visible = false;
            // 
            // pickTransportButton
            // 
            pickTransportButton.Location = new Point(448, 471);
            pickTransportButton.Name = "pickTransportButton";
            pickTransportButton.Size = new Size(145, 34);
            pickTransportButton.TabIndex = 9;
            pickTransportButton.Text = "Pick transport";
            pickTransportButton.UseVisualStyleBackColor = true;
            pickTransportButton.Visible = false;
            pickTransportButton.Click += pickTransportButton_Click;
            // 
            // shipOrderButton
            // 
            shipOrderButton.Location = new Point(915, 471);
            shipOrderButton.Name = "shipOrderButton";
            shipOrderButton.Size = new Size(112, 34);
            shipOrderButton.TabIndex = 10;
            shipOrderButton.Text = "Ship order";
            shipOrderButton.UseVisualStyleBackColor = true;
            shipOrderButton.Visible = false;
            shipOrderButton.Click += shipOrderButton_Click;
            // 
            // removeFromReadyToBeShippedButton
            // 
            removeFromReadyToBeShippedButton.Location = new Point(743, 471);
            removeFromReadyToBeShippedButton.Name = "removeFromReadyToBeShippedButton";
            removeFromReadyToBeShippedButton.Size = new Size(112, 34);
            removeFromReadyToBeShippedButton.TabIndex = 11;
            removeFromReadyToBeShippedButton.Text = "Remove";
            removeFromReadyToBeShippedButton.UseVisualStyleBackColor = true;
            removeFromReadyToBeShippedButton.Visible = false;
            removeFromReadyToBeShippedButton.Click += removeFromReadyToBeShippedButton_Click;
            // 
            // removeOrderButton
            // 
            removeOrderButton.Location = new Point(25, 473);
            removeOrderButton.Name = "removeOrderButton";
            removeOrderButton.Size = new Size(144, 34);
            removeOrderButton.TabIndex = 12;
            removeOrderButton.Text = "Remove order";
            removeOrderButton.UseVisualStyleBackColor = true;
            removeOrderButton.Click += removeOrderButton_Click;
            // 
            // Shipping
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1105, 523);
            Controls.Add(removeOrderButton);
            Controls.Add(removeFromReadyToBeShippedButton);
            Controls.Add(shipOrderButton);
            Controls.Add(pickTransportButton);
            Controls.Add(readyToBeShippedListBox);
            Controls.Add(pickOrderButton);
            Controls.Add(transportsListBox);
            Controls.Add(ordersListBox);
            Margin = new Padding(4);
            Name = "Shipping";
            Text = "Shipping";
            ResumeLayout(false);
        }

        #endregion

        private Button pickOrderButton;
        private ListBox transportsListBox;
        private ListBox ordersListBox;
        private ListBox readyToBeShippedListBox;
        private Button pickTransportButton;
        private Button shipOrderButton;
        private Button removeFromReadyToBeShippedButton;
        private Button removeOrderButton;
    }
}