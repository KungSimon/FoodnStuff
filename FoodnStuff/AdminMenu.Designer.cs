namespace FoodnStuff
{
    partial class AdminMenu
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
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            tabPage2 = new TabPage();
            tabPage3 = new TabPage();
            listBox1 = new ListBox();
            addNewItemButton = new Button();
            removeButton = new Button();
            label1 = new Label();
            listBox2 = new ListBox();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Location = new Point(0, -1);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(803, 454);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(label1);
            tabPage1.Controls.Add(removeButton);
            tabPage1.Controls.Add(addNewItemButton);
            tabPage1.Controls.Add(listBox1);
            tabPage1.Location = new Point(4, 29);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(795, 421);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Item Manager";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(listBox2);
            tabPage2.Location = new Point(4, 29);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(795, 421);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Orders";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            tabPage3.Location = new Point(4, 29);
            tabPage3.Name = "tabPage3";
            tabPage3.Size = new Size(795, 421);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Inventory ";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 20;
            listBox1.Location = new Point(21, 40);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(276, 304);
            listBox1.TabIndex = 0;
            // 
            // addNewItemButton
            // 
            addNewItemButton.Location = new Point(343, 315);
            addNewItemButton.Name = "addNewItemButton";
            addNewItemButton.Size = new Size(118, 29);
            addNewItemButton.TabIndex = 1;
            addNewItemButton.Text = "Add new item";
            addNewItemButton.UseVisualStyleBackColor = true;
            // 
            // removeButton
            // 
            removeButton.Location = new Point(494, 315);
            removeButton.Name = "removeButton";
            removeButton.Size = new Size(118, 29);
            removeButton.TabIndex = 2;
            removeButton.Text = "Remove item";
            removeButton.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(523, 27);
            label1.Name = "label1";
            label1.Size = new Size(50, 20);
            label1.TabIndex = 3;
            label1.Text = "label1";
            // 
            // listBox2
            // 
            listBox2.FormattingEnabled = true;
            listBox2.ItemHeight = 20;
            listBox2.Location = new Point(34, 24);
            listBox2.Name = "listBox2";
            listBox2.Size = new Size(260, 364);
            listBox2.TabIndex = 0;
            // 
            // AdminMenu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tabControl1);
            Name = "AdminMenu";
            Text = "AdminMenu";
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            tabPage2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private TabPage tabPage3;
        private Label label1;
        private Button removeButton;
        private Button addNewItemButton;
        private ListBox listBox1;
        private ListBox listBox2;
    }
}