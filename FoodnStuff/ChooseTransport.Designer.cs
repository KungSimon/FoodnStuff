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
            listBoxAvailableTransports = new ListBox();
            shipOrderButton = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // listBoxAvailableTransports
            // 
            listBoxAvailableTransports.FormattingEnabled = true;
            listBoxAvailableTransports.ItemHeight = 25;
            listBoxAvailableTransports.Location = new Point(60, 84);
            listBoxAvailableTransports.Name = "listBoxAvailableTransports";
            listBoxAvailableTransports.Size = new Size(195, 279);
            listBoxAvailableTransports.TabIndex = 0;
            // 
            // shipOrderButton
            // 
            shipOrderButton.Location = new Point(86, 381);
            shipOrderButton.Name = "shipOrderButton";
            shipOrderButton.Size = new Size(131, 34);
            shipOrderButton.TabIndex = 1;
            shipOrderButton.Text = "Ship Order";
            shipOrderButton.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(25, 39);
            label1.Name = "label1";
            label1.Size = new Size(269, 25);
            label1.TabIndex = 2;
            label1.Text = "Available transport to ship order";
            // 
            // ChooseTransport
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(700, 538);
            Controls.Add(label1);
            Controls.Add(shipOrderButton);
            Controls.Add(listBoxAvailableTransports);
            Name = "ChooseTransport";
            Text = "ChooseTransport";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox listBoxAvailableTransports;
        private Button shipOrderButton;
        private Label label1;
    }
}