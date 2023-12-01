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
            button2 = new Button();
            readyToBeShippedListBox = new ListBox();
            ordersListBox = new ListBox();
            chooseTransportButton = new Button();
            SuspendLayout();
            // 
            // button2
            // 
            button2.Location = new Point(460, 258);
            button2.Margin = new Padding(4, 4, 4, 4);
            button2.Name = "button2";
            button2.Size = new Size(182, 36);
            button2.TabIndex = 5;
            button2.Text = "Add to shipping";
            button2.UseVisualStyleBackColor = true;
            // 
            // readyToBeShippedListBox
            // 
            readyToBeShippedListBox.FormattingEnabled = true;
            readyToBeShippedListBox.ItemHeight = 25;
            readyToBeShippedListBox.Location = new Point(676, 111);
            readyToBeShippedListBox.Margin = new Padding(4, 4, 4, 4);
            readyToBeShippedListBox.Name = "readyToBeShippedListBox";
            readyToBeShippedListBox.Size = new Size(350, 429);
            readyToBeShippedListBox.TabIndex = 4;
            // 
            // ordersListBox
            // 
            ordersListBox.FormattingEnabled = true;
            ordersListBox.ItemHeight = 25;
            ordersListBox.Location = new Point(79, 111);
            ordersListBox.Margin = new Padding(4, 4, 4, 4);
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
            // 
            // Shipping
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1105, 654);
            Controls.Add(chooseTransportButton);
            Controls.Add(button2);
            Controls.Add(readyToBeShippedListBox);
            Controls.Add(ordersListBox);
            Margin = new Padding(4, 4, 4, 4);
            Name = "Shipping";
            Text = "Shipping";
            ResumeLayout(false);
        }

        #endregion

        private Button button2;
        private ListBox readyToBeShippedListBox;
        private ListBox ordersListBox;
        private Button chooseTransportButton;
    }
}