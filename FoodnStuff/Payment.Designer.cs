namespace FoodnStuff
{
    partial class Payment
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
            cardNumberTextBox = new TextBox();
            purchaseButton = new Button();
            cardPinLabel = new Label();
            cardNumberLabel = new Label();
            cardPinTextBox = new TextBox();
            SuspendLayout();
            // 
            // cardNumberTextBox
            // 
            cardNumberTextBox.Location = new Point(135, 45);
            cardNumberTextBox.Name = "cardNumberTextBox";
            cardNumberTextBox.Size = new Size(229, 27);
            cardNumberTextBox.TabIndex = 14;
            cardNumberTextBox.TextChanged += cardNumberTextBox_TextChanged;
            // 
            // purchaseButton
            // 
            purchaseButton.Location = new Point(159, 167);
            purchaseButton.Name = "purchaseButton";
            purchaseButton.Size = new Size(145, 29);
            purchaseButton.TabIndex = 18;
            purchaseButton.Text = "Purchase";
            purchaseButton.UseVisualStyleBackColor = true;
            purchaseButton.Click += purchaseButton_Click;
            // 
            // cardPinLabel
            // 
            cardPinLabel.AutoSize = true;
            cardPinLabel.Location = new Point(61, 110);
            cardPinLabel.Name = "cardPinLabel";
            cardPinLabel.Size = new Size(68, 20);
            cardPinLabel.TabIndex = 17;
            cardPinLabel.Text = "Card pin:";
            // 
            // cardNumberLabel
            // 
            cardNumberLabel.AutoSize = true;
            cardNumberLabel.Location = new Point(31, 52);
            cardNumberLabel.Name = "cardNumberLabel";
            cardNumberLabel.Size = new Size(98, 20);
            cardNumberLabel.TabIndex = 16;
            cardNumberLabel.Text = "Card number:";
            // 
            // cardPinTextBox
            // 
            cardPinTextBox.Location = new Point(135, 103);
            cardPinTextBox.Name = "cardPinTextBox";
            cardPinTextBox.Size = new Size(229, 27);
            cardPinTextBox.TabIndex = 15;
            cardPinTextBox.TextChanged += cardPinTextBox_TextChanged;
            // 
            // Payment
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(cardNumberTextBox);
            Controls.Add(purchaseButton);
            Controls.Add(cardPinLabel);
            Controls.Add(cardNumberLabel);
            Controls.Add(cardPinTextBox);
            Name = "Payment";
            Text = "Payment";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox cardNumberTextBox;
        private Button purchaseButton;
        private Label cardPinLabel;
        private Label cardNumberLabel;
        private TextBox cardPinTextBox;
    }
}