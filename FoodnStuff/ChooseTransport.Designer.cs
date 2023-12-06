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
            SuspendLayout();
            // 
            // listBoxAvailableTransports
            // 
            listBoxAvailableTransports.FormattingEnabled = true;
            listBoxAvailableTransports.ItemHeight = 20;
            listBoxAvailableTransports.Location = new Point(83, 66);
            listBoxAvailableTransports.Margin = new Padding(2);
            listBoxAvailableTransports.Name = "listBoxAvailableTransports";
            listBoxAvailableTransports.Size = new Size(157, 224);
            listBoxAvailableTransports.TabIndex = 0;
            listBoxAvailableTransports.SelectedIndexChanged += listBoxAvailableTransports_SelectedIndexChanged;
            // 
            // loadTransportButton
            // 
            loadTransportButton.Location = new Point(95, 294);
            loadTransportButton.Margin = new Padding(2);
            loadTransportButton.Name = "loadTransportButton";
            loadTransportButton.Size = new Size(126, 33);
            loadTransportButton.TabIndex = 1;
            loadTransportButton.Text = "Ship Order";
            loadTransportButton.UseVisualStyleBackColor = true;
            loadTransportButton.Click += shipOrderButton_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(53, 38);
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
            ClientSize = new Size(559, 408);
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
    }
}