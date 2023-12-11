namespace FoodnStuff
{
    partial class NewItem
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NewItem));
            addItemButton = new Button();
            itemNameLabel = new Label();
            catagoryLabel = new Label();
            itemNameTextBox = new TextBox();
            catagoryTextBox = new TextBox();
            priceLabel = new Label();
            label2 = new Label();
            quantityNumeric = new NumericUpDown();
            priceNumeric = new NumericUpDown();
            editItemButton = new Button();
            ((System.ComponentModel.ISupportInitialize)quantityNumeric).BeginInit();
            ((System.ComponentModel.ISupportInitialize)priceNumeric).BeginInit();
            SuspendLayout();
            // 
            // addItemButton
            // 
            addItemButton.Location = new Point(126, 287);
            addItemButton.Name = "addItemButton";
            addItemButton.Size = new Size(145, 29);
            addItemButton.TabIndex = 18;
            addItemButton.Text = "Add item";
            addItemButton.UseVisualStyleBackColor = true;
            addItemButton.Click += addItemButton_Click;
            // 
            // itemNameLabel
            // 
            itemNameLabel.AutoSize = true;
            itemNameLabel.Location = new Point(37, 93);
            itemNameLabel.Name = "itemNameLabel";
            itemNameLabel.Size = new Size(83, 20);
            itemNameLabel.TabIndex = 17;
            itemNameLabel.Text = "Item name:";
            // 
            // catagoryLabel
            // 
            catagoryLabel.AutoSize = true;
            catagoryLabel.Location = new Point(37, 29);
            catagoryLabel.Name = "catagoryLabel";
            catagoryLabel.Size = new Size(72, 20);
            catagoryLabel.TabIndex = 16;
            catagoryLabel.Text = "Catagory:";
            // 
            // itemNameTextBox
            // 
            itemNameTextBox.Location = new Point(126, 86);
            itemNameTextBox.Name = "itemNameTextBox";
            itemNameTextBox.Size = new Size(185, 27);
            itemNameTextBox.TabIndex = 15;
            // 
            // catagoryTextBox
            // 
            catagoryTextBox.Location = new Point(126, 28);
            catagoryTextBox.Name = "catagoryTextBox";
            catagoryTextBox.Size = new Size(185, 27);
            catagoryTextBox.TabIndex = 14;
            // 
            // priceLabel
            // 
            priceLabel.AutoSize = true;
            priceLabel.Location = new Point(37, 150);
            priceLabel.Name = "priceLabel";
            priceLabel.Size = new Size(44, 20);
            priceLabel.TabIndex = 20;
            priceLabel.Text = "Price:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(37, 213);
            label2.Name = "label2";
            label2.Size = new Size(68, 20);
            label2.TabIndex = 22;
            label2.Text = "Quantity:";
            // 
            // quantityNumeric
            // 
            quantityNumeric.Location = new Point(126, 206);
            quantityNumeric.Name = "quantityNumeric";
            quantityNumeric.Size = new Size(185, 27);
            quantityNumeric.TabIndex = 23;
            // 
            // priceNumeric
            // 
            priceNumeric.Location = new Point(126, 150);
            priceNumeric.Name = "priceNumeric";
            priceNumeric.Size = new Size(185, 27);
            priceNumeric.TabIndex = 24;
            // 
            // editItemButton
            // 
            editItemButton.Location = new Point(126, 341);
            editItemButton.Name = "editItemButton";
            editItemButton.Size = new Size(145, 29);
            editItemButton.TabIndex = 25;
            editItemButton.Text = "Edit item";
            editItemButton.UseVisualStyleBackColor = true;
            editItemButton.Click += editItemButton_Click;
            // 
            // NewItem
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(800, 450);
            Controls.Add(editItemButton);
            Controls.Add(priceNumeric);
            Controls.Add(quantityNumeric);
            Controls.Add(label2);
            Controls.Add(priceLabel);
            Controls.Add(addItemButton);
            Controls.Add(itemNameLabel);
            Controls.Add(catagoryLabel);
            Controls.Add(itemNameTextBox);
            Controls.Add(catagoryTextBox);
            Name = "NewItem";
            Text = "NewItem";
            ((System.ComponentModel.ISupportInitialize)quantityNumeric).EndInit();
            ((System.ComponentModel.ISupportInitialize)priceNumeric).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button addItemButton;
        private Label itemNameLabel;
        private Label catagoryLabel;
        private TextBox itemNameTextBox;
        private TextBox catagoryTextBox;
        private Label priceLabel;
        private Label label2;
        private NumericUpDown quantityNumeric;
        private NumericUpDown priceNumeric;
        private Button editItemButton;
    }
}