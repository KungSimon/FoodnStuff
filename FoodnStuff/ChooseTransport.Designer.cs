namespace FoodnStuff
{
    partial class ChooseTransport
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChooseTransport));
            listBoxAvailableTransports = new ListBox();
            loadTransportButton = new Button();
            label1 = new Label();
            readyOrdersListBox = new ListBox();
            moveToTransportButton = new Button();
            ordersLabel = new Label();
            SuspendLayout();
            // 
            // listBoxAvailableTransports
            // 
            listBoxAvailableTransports.FormattingEnabled = true;
            listBoxAvailableTransports.ItemHeight = 20;
            listBoxAvailableTransports.Location = new Point(363, 63);
            listBoxAvailableTransports.Margin = new Padding(2);
            listBoxAvailableTransports.Name = "listBoxAvailableTransports";
            listBoxAvailableTransports.Size = new Size(195, 279);
            listBoxAvailableTransports.TabIndex = 0;
            // 
            // loadTransportButton
            // 
            shipOrderButton.Location = new Point(363, 304);
            shipOrderButton.Margin = new Padding(2);
            shipOrderButton.Name = "shipOrderButton";
            shipOrderButton.Size = new Size(157, 27);
            shipOrderButton.TabIndex = 1;
            shipOrderButton.Text = "Ship Order";
            shipOrderButton.UseVisualStyleBackColor = true;
            shipOrderButton.Click += shipOrderButton_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(325, 27);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(269, 25);
            label1.TabIndex = 2;
            label1.Text = "Available transport to ship order";
            // 
            // readyOrdersListBox
            // 
            readyOrdersListBox.FormattingEnabled = true;
            readyOrdersListBox.ItemHeight = 20;
            readyOrdersListBox.Location = new Point(32, 63);
            readyOrdersListBox.Margin = new Padding(2);
            readyOrdersListBox.Name = "readyOrdersListBox";
            readyOrdersListBox.Size = new Size(157, 224);
            readyOrdersListBox.TabIndex = 3;
            // 
            // moveToTransportButton
            // 
            moveToTransportButton.Location = new Point(32, 304);
            moveToTransportButton.Margin = new Padding(2);
            moveToTransportButton.Name = "moveToTransportButton";
            moveToTransportButton.Size = new Size(157, 27);
            moveToTransportButton.TabIndex = 4;
            moveToTransportButton.Text = "Move to transport";
            moveToTransportButton.UseVisualStyleBackColor = true;
            moveToTransportButton.Click += moveToTransportButton_Click;
            // 
            // ordersLabel
            // 
            ordersLabel.AutoSize = true;
            ordersLabel.Location = new Point(22, 27);
            ordersLabel.Margin = new Padding(2, 0, 2, 0);
            ordersLabel.Name = "ordersLabel";
            ordersLabel.Size = new Size(190, 20);
            ordersLabel.TabIndex = 5;
            ordersLabel.Text = "Orders ready to be shipped";
            // 
            // ChooseTransport
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(560, 430);
            Controls.Add(ordersLabel);
            Controls.Add(moveToTransportButton);
            Controls.Add(readyOrdersListBox);
            Controls.Add(label1);
            Controls.Add(loadTransportButton);
            Controls.Add(listBoxAvailableTransports);
            Margin = new Padding(2);
            Name = "ChooseTransport";
            Text = "ChooseTransport";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox listBoxAvailableTransports;
        private Button loadTransportButton;
        private Label label1;
        private ListBox readyOrdersListBox;
        private Button moveToTransportButton;
        private Label ordersLabel;
    }
}