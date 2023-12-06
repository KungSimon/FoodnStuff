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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminMenu));
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            itemLabel = new Label();
            removeItemButton = new Button();
            addNewItemButton = new Button();
            itemsListBox = new ListBox();
            tabPage2 = new TabPage();
            chooseTransportButton = new Button();
            tabPage3 = new TabPage();
            tabPage4 = new TabPage();
            logOutButton = new Button();
            registerButton = new Button();
            passwordLabel = new Label();
            usernameLabel = new Label();
            passwordTextBox = new TextBox();
            usernameTextBox = new TextBox();
            editButton = new Button();
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
            tabPage1.BackgroundImage = (Image)resources.GetObject("tabPage1.BackgroundImage");
            tabPage1.Controls.Add(editButton);
            tabPage1.Controls.Add(itemLabel);
            tabPage1.Controls.Add(removeItemButton);
            tabPage1.Controls.Add(addNewItemButton);
            tabPage1.Controls.Add(itemsListBox);
            tabPage1.Location = new Point(4, 29);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(795, 421);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Item Manager";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // itemLabel
            // 
            itemLabel.AutoSize = true;
            itemLabel.Location = new Point(411, 40);
            itemLabel.Name = "itemLabel";
            itemLabel.Size = new Size(50, 20);
            itemLabel.TabIndex = 3;
            itemLabel.Text = "label1";
            itemLabel.Visible = false;
            // 
            // removeItemButton
            // 
            removeItemButton.Location = new Point(494, 315);
            removeItemButton.Name = "removeItemButton";
            removeItemButton.Size = new Size(118, 29);
            removeItemButton.TabIndex = 2;
            removeItemButton.Text = "Remove item";
            removeItemButton.UseVisualStyleBackColor = true;
            removeItemButton.Click += removeItemButton_Click;
            // 
            // addNewItemButton
            // 
            addNewItemButton.Location = new Point(343, 315);
            addNewItemButton.Name = "addNewItemButton";
            addNewItemButton.Size = new Size(118, 29);
            addNewItemButton.TabIndex = 1;
            addNewItemButton.Text = "Add new item";
            addNewItemButton.UseVisualStyleBackColor = true;
            addNewItemButton.Click += addNewItemButton_Click;
            // 
            // itemsListBox
            // 
            itemsListBox.FormattingEnabled = true;
            itemsListBox.ItemHeight = 20;
            itemsListBox.Location = new Point(21, 40);
            itemsListBox.Name = "itemsListBox";
            itemsListBox.Size = new Size(276, 304);
            itemsListBox.TabIndex = 0;
            itemsListBox.SelectedIndexChanged += itemsListBox_SelectedIndexChanged;
            // 
            // tabPage2
            // 
            tabPage2.BackgroundImage = (Image)resources.GetObject("tabPage2.BackgroundImage");
            tabPage2.Controls.Add(chooseTransportButton);
            tabPage2.Location = new Point(4, 29);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(795, 421);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Orders";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // chooseTransportButton
            // 
            chooseTransportButton.Location = new Point(302, 161);
            chooseTransportButton.Name = "chooseTransportButton";
            chooseTransportButton.Size = new Size(176, 58);
            chooseTransportButton.TabIndex = 2;
            chooseTransportButton.Text = "Choose Transport";
            chooseTransportButton.UseVisualStyleBackColor = true;
            chooseTransportButton.Click += chooseTransportButton_Click;
            // 
            // tabPage3
            // 
            tabPage3.BackgroundImage = (Image)resources.GetObject("tabPage3.BackgroundImage");
            tabPage3.Location = new Point(4, 29);
            tabPage3.Name = "tabPage3";
            tabPage3.Size = new Size(795, 421);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Inventory ";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            tabPage4.BackgroundImage = (Image)resources.GetObject("tabPage4.BackgroundImage");
            tabPage4.Controls.Add(logOutButton);
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
            // logOutButton
            // 
            logOutButton.Location = new Point(680, 17);
            logOutButton.Name = "logOutButton";
            logOutButton.Size = new Size(94, 29);
            logOutButton.TabIndex = 14;
            logOutButton.Text = "Log out";
            logOutButton.UseVisualStyleBackColor = true;
            logOutButton.Click += logOutButton_Click;
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
            // editButton
            // 
            editButton.Location = new Point(638, 315);
            editButton.Name = "editButton";
            editButton.Size = new Size(118, 29);
            editButton.TabIndex = 4;
            editButton.Text = "Edit item";
            editButton.UseVisualStyleBackColor = true;
            // 
            // AdminMenu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(798, 446);
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
        private Label itemLabel;
        private Button removeItemButton;
        private Button addNewItemButton;
        private ListBox itemsListBox;
        private TabPage tabPage4;
        private Button registerButton;
        private Label passwordLabel;
        private Label usernameLabel;
        private TextBox passwordTextBox;
        private TextBox usernameTextBox;
        private Button logOutButton;
        private Button chooseTransportButton;
        private Button editButton;
    }
}