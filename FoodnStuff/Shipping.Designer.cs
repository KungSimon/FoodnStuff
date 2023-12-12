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
            addButton = new Button();
            transportsListBox = new ListBox();
            ordersListBox = new ListBox();
            readyToBeShippedListBox = new ListBox();
            shipOrderButton = new Button();
            removeFromReadyToBeShippedButton = new Button();
            deleteOrderButton = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // addButton
            // 
            addButton.Location = new Point(188, 471);
            addButton.Margin = new Padding(4);
            addButton.Name = "addButton";
            addButton.Size = new Size(121, 36);
            addButton.TabIndex = 5;
            addButton.Text = "Add";
            addButton.UseVisualStyleBackColor = true;
            addButton.Click += addButton_Click;
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
            transportsListBox.SelectedIndexChanged += transportsListBox_SelectedIndexChanged;
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
            readyToBeShippedListBox.Location = new Point(761, 34);
            readyToBeShippedListBox.Name = "readyToBeShippedListBox";
            readyToBeShippedListBox.Size = new Size(284, 404);
            readyToBeShippedListBox.TabIndex = 8;
            readyToBeShippedListBox.Visible = false;
            // 
            // shipOrderButton
            // 
            shipOrderButton.Location = new Point(933, 461);
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
            removeFromReadyToBeShippedButton.Location = new Point(761, 461);
            removeFromReadyToBeShippedButton.Name = "removeFromReadyToBeShippedButton";
            removeFromReadyToBeShippedButton.Size = new Size(112, 34);
            removeFromReadyToBeShippedButton.TabIndex = 11;
            removeFromReadyToBeShippedButton.Text = "Remove";
            removeFromReadyToBeShippedButton.UseVisualStyleBackColor = true;
            removeFromReadyToBeShippedButton.Visible = false;
            removeFromReadyToBeShippedButton.Click += removeFromReadyToBeShippedButton_Click;
            // 
            // deleteOrderButton
            // 
            deleteOrderButton.Location = new Point(25, 473);
            deleteOrderButton.Name = "deleteOrderButton";
            deleteOrderButton.Size = new Size(144, 34);
            deleteOrderButton.TabIndex = 12;
            deleteOrderButton.Text = "Delete order";
            deleteOrderButton.UseVisualStyleBackColor = true;
            deleteOrderButton.Click += deleteOrderButton_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(119, 6);
            label1.Name = "label1";
            label1.Size = new Size(66, 25);
            label1.TabIndex = 13;
            label1.Text = "Orders";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(485, 6);
            label2.Name = "label2";
            label2.Size = new Size(94, 25);
            label2.TabIndex = 14;
            label2.Text = "Transports";
            label2.Visible = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(761, 6);
            label3.Name = "label3";
            label3.Size = new Size(238, 25);
            label3.TabIndex = 15;
            label3.Text = "Orders loaded on transports";
            label3.Visible = false;
            // 
            // Shipping
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1105, 523);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(deleteOrderButton);
            Controls.Add(removeFromReadyToBeShippedButton);
            Controls.Add(shipOrderButton);
            Controls.Add(readyToBeShippedListBox);
            Controls.Add(addButton);
            Controls.Add(transportsListBox);
            Controls.Add(ordersListBox);
            Margin = new Padding(4);
            Name = "Shipping";
            Text = "Shipping";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button addButton;
        private ListBox transportsListBox;
        private ListBox ordersListBox;
        private ListBox readyToBeShippedListBox;
        private Button shipOrderButton;
        private Button removeFromReadyToBeShippedButton;
        private Button deleteOrderButton;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}