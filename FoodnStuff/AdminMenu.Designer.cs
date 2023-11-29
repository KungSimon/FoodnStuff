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
            label1 = new Label();
            removeButton = new Button();
            addNewItemButton = new Button();
            listBox1 = new ListBox();
            tabPage2 = new TabPage();
            listBox2 = new ListBox();
            tabPage3 = new TabPage();
            tabPage4 = new TabPage();
            registerButton = new Button();
            passwordLabel = new Label();
            usernameLabel = new Label();
            passwordTextBox = new TextBox();
            usernameTextBox = new TextBox();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            tabPage4.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Controls.Add(tabPage4);
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
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(523, 27);
            label1.Name = "label1";
            label1.Size = new Size(50, 20);
            label1.TabIndex = 3;
            label1.Text = "label1";
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
            // addNewItemButton
            // 
            addNewItemButton.Location = new Point(343, 315);
            addNewItemButton.Name = "addNewItemButton";
            addNewItemButton.Size = new Size(118, 29);
            addNewItemButton.TabIndex = 1;
            addNewItemButton.Text = "Add new item";
            addNewItemButton.UseVisualStyleBackColor = true;
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
            // listBox2
            // 
            listBox2.FormattingEnabled = true;
            listBox2.ItemHeight = 20;
            listBox2.Location = new Point(34, 24);
            listBox2.Name = "listBox2";
            listBox2.Size = new Size(260, 364);
            listBox2.TabIndex = 0;
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
            // tabPage4
            // 
            tabPage4.Controls.Add(registerButton);
            tabPage4.Controls.Add(passwordLabel);
            tabPage4.Controls.Add(usernameLabel);
            tabPage4.Controls.Add(passwordTextBox);
            tabPage4.Controls.Add(usernameTextBox);
            tabPage4.Location = new Point(4, 29);
            tabPage4.Name = "tabPage4";
            tabPage4.Padding = new Padding(3);
            tabPage4.Size = new Size(795, 421);
            tabPage4.TabIndex = 3;
            tabPage4.Text = "Add a new admin";
            tabPage4.UseVisualStyleBackColor = true;
            // 
            // registerButton
            // 
            registerButton.Location = new Point(336, 256);
            registerButton.Name = "registerButton";
            registerButton.Size = new Size(145, 29);
            registerButton.TabIndex = 13;
            registerButton.Text = "Register";
            registerButton.UseVisualStyleBackColor = true;
            registerButton.Click += registerButton_Click;
            // 
            // passwordLabel
            // 
            passwordLabel.AutoSize = true;
            passwordLabel.Location = new Point(247, 202);
            passwordLabel.Name = "passwordLabel";
            passwordLabel.Size = new Size(73, 20);
            passwordLabel.TabIndex = 12;
            passwordLabel.Text = "Password:";
            // 
            // usernameLabel
            // 
            usernameLabel.AutoSize = true;
            usernameLabel.Location = new Point(247, 138);
            usernameLabel.Name = "usernameLabel";
            usernameLabel.Size = new Size(78, 20);
            usernameLabel.TabIndex = 11;
            usernameLabel.Text = "Username:";
            // 
            // passwordTextBox
            // 
            passwordTextBox.Location = new Point(336, 195);
            passwordTextBox.Name = "passwordTextBox";
            passwordTextBox.Size = new Size(185, 27);
            passwordTextBox.TabIndex = 10;
            // 
            // usernameTextBox
            // 
            usernameTextBox.Location = new Point(336, 137);
            usernameTextBox.Name = "usernameTextBox";
            usernameTextBox.Size = new Size(185, 27);
            usernameTextBox.TabIndex = 9;
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
            tabPage4.ResumeLayout(false);
            tabPage4.PerformLayout();
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
        private TabPage tabPage4;
        private Button registerButton;
        private Label passwordLabel;
        private Label usernameLabel;
        private TextBox passwordTextBox;
        private TextBox usernameTextBox;
    }
}