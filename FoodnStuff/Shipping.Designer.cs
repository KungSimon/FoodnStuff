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
            SuspendLayout();
            // 
            // button2
            // 
            button2.Location = new Point(368, 206);
            button2.Name = "button2";
            button2.Size = new Size(146, 29);
            button2.TabIndex = 5;
            button2.Text = "Add to shipping";
            button2.UseVisualStyleBackColor = true;
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
            // Shipping
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(884, 523);
            Controls.Add(button2);
            Controls.Add(readyToBeShippedListBox);
            Controls.Add(ordersListBox);
            Name = "Shipping";
            Text = "Shipping";
            ResumeLayout(false);
        }

        #endregion

        private Button button2;
        private ListBox readyToBeShippedListBox;
        private ListBox ordersListBox;
    }
}