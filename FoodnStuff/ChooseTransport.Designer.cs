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
            shipOrderButton = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // listBoxAvailableTransports
            // 
            listBoxAvailableTransports.FormattingEnabled = true;
            listBoxAvailableTransports.ItemHeight = 20;
            listBoxAvailableTransports.Location = new Point(48, 67);
            listBoxAvailableTransports.Margin = new Padding(2, 2, 2, 2);
            listBoxAvailableTransports.Name = "listBoxAvailableTransports";
            listBoxAvailableTransports.Size = new Size(157, 224);
            listBoxAvailableTransports.TabIndex = 0;
            // 
            // shipOrderButton
            // 
            shipOrderButton.Location = new Point(69, 305);
            shipOrderButton.Margin = new Padding(2, 2, 2, 2);
            shipOrderButton.Name = "shipOrderButton";
            shipOrderButton.Size = new Size(105, 27);
            shipOrderButton.TabIndex = 1;
            shipOrderButton.Text = "Ship Order";
            shipOrderButton.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(20, 31);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(224, 20);
            label1.TabIndex = 2;
            label1.Text = "Available transport to ship order";
            // 
            // ChooseTransport
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(560, 430);
            Controls.Add(label1);
            Controls.Add(shipOrderButton);
            Controls.Add(listBoxAvailableTransports);
            Margin = new Padding(2, 2, 2, 2);
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