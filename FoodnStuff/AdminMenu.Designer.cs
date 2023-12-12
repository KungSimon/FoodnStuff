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
            label6 = new Label();
            descriptionTextBox = new TextBox();
            label5 = new Label();
            quantityTextBox = new TextBox();
            label4 = new Label();
            priceTextBox = new TextBox();
            label3 = new Label();
            idTextBox = new TextBox();
            label2 = new Label();
            nameTextBox = new TextBox();
            label1 = new Label();
            categoryTextBox = new TextBox();
            editButton = new Button();
            itemLabel = new Label();
            removeItemButton = new Button();
            addNewItemButton = new Button();
            itemsListBox = new ListBox();
            tabPage2 = new TabPage();
            chooseTransportButton = new Button();
            tabPage4 = new TabPage();
            logOutButton = new Button();
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
            tabControl1.Controls.Add(tabPage4);
            tabControl1.Location = new Point(0, -1);
            tabControl1.Margin = new Padding(3, 2, 3, 2);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(703, 340);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.BackgroundImage = (Image)resources.GetObject("tabPage1.BackgroundImage");
            tabPage1.Controls.Add(label6);
            tabPage1.Controls.Add(descriptionTextBox);
            tabPage1.Controls.Add(label5);
            tabPage1.Controls.Add(quantityTextBox);
            tabPage1.Controls.Add(label4);
            tabPage1.Controls.Add(priceTextBox);
            tabPage1.Controls.Add(label3);
            tabPage1.Controls.Add(idTextBox);
            tabPage1.Controls.Add(label2);
            tabPage1.Controls.Add(nameTextBox);
            tabPage1.Controls.Add(label1);
            tabPage1.Controls.Add(categoryTextBox);
            tabPage1.Controls.Add(editButton);
            tabPage1.Controls.Add(itemLabel);
            tabPage1.Controls.Add(removeItemButton);
            tabPage1.Controls.Add(addNewItemButton);
            tabPage1.Controls.Add(itemsListBox);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Margin = new Padding(3, 2, 3, 2);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3, 2, 3, 2);
            tabPage1.Size = new Size(695, 312);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Item Manager";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(283, 83);
            label6.Name = "label6";
            label6.Size = new Size(67, 15);
            label6.TabIndex = 16;
            label6.Text = "Description";
            // 
            // descriptionTextBox
            // 
            descriptionTextBox.Location = new Point(283, 101);
            descriptionTextBox.Multiline = true;
            descriptionTextBox.Name = "descriptionTextBox";
            descriptionTextBox.Size = new Size(361, 130);
            descriptionTextBox.TabIndex = 15;
            descriptionTextBox.TextChanged += aTextBox_TextChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(599, 30);
            label5.Name = "label5";
            label5.Size = new Size(36, 15);
            label5.TabIndex = 14;
            label5.Text = "Stock";
            // 
            // quantityTextBox
            // 
            quantityTextBox.Location = new Point(599, 48);
            quantityTextBox.Name = "quantityTextBox";
            quantityTextBox.Size = new Size(45, 23);
            quantityTextBox.TabIndex = 13;
            quantityTextBox.TextChanged += aTextBox_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(548, 30);
            label4.Name = "label4";
            label4.Size = new Size(33, 15);
            label4.TabIndex = 12;
            label4.Text = "Price";
            // 
            // priceTextBox
            // 
            priceTextBox.Location = new Point(548, 48);
            priceTextBox.Name = "priceTextBox";
            priceTextBox.Size = new Size(45, 23);
            priceTextBox.TabIndex = 11;
            priceTextBox.TextChanged += aTextBox_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(497, 30);
            label3.Name = "label3";
            label3.Size = new Size(18, 15);
            label3.TabIndex = 10;
            label3.Text = "ID";
            // 
            // idTextBox
            // 
            idTextBox.Location = new Point(497, 48);
            idTextBox.Name = "idTextBox";
            idTextBox.Size = new Size(45, 23);
            idTextBox.TabIndex = 9;
            idTextBox.TextChanged += aTextBox_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(389, 30);
            label2.Name = "label2";
            label2.Size = new Size(39, 15);
            label2.TabIndex = 8;
            label2.Text = "Name";
            // 
            // nameTextBox
            // 
            nameTextBox.Location = new Point(389, 48);
            nameTextBox.Name = "nameTextBox";
            nameTextBox.Size = new Size(100, 23);
            nameTextBox.TabIndex = 7;
            nameTextBox.TextChanged += aTextBox_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(283, 30);
            label1.Name = "label1";
            label1.Size = new Size(55, 15);
            label1.TabIndex = 6;
            label1.Text = "Category";
            // 
            // categoryTextBox
            // 
            categoryTextBox.Location = new Point(283, 48);
            categoryTextBox.Name = "categoryTextBox";
            categoryTextBox.Size = new Size(100, 23);
            categoryTextBox.TabIndex = 5;
            categoryTextBox.TextChanged += aTextBox_TextChanged;
            // 
            // editButton
            // 
            editButton.Location = new Point(541, 236);
            editButton.Margin = new Padding(3, 2, 3, 2);
            editButton.Name = "editButton";
            editButton.Size = new Size(103, 22);
            editButton.TabIndex = 4;
            editButton.Text = "Edit item";
            editButton.UseVisualStyleBackColor = true;
            editButton.Click += editButton_Click_1;
            // 
            // itemLabel
            // 
            itemLabel.AutoSize = true;
            itemLabel.Location = new Point(18, 276);
            itemLabel.Name = "itemLabel";
            itemLabel.Size = new Size(38, 15);
            itemLabel.TabIndex = 3;
            itemLabel.Text = "label1";
            itemLabel.Visible = false;
            // 
            // removeItemButton
            // 
            removeItemButton.Location = new Point(412, 236);
            removeItemButton.Margin = new Padding(3, 2, 3, 2);
            removeItemButton.Name = "removeItemButton";
            removeItemButton.Size = new Size(103, 22);
            removeItemButton.TabIndex = 2;
            removeItemButton.Text = "Remove item";
            removeItemButton.UseVisualStyleBackColor = true;
            removeItemButton.Click += removeItemButton_Click;
            // 
            // addNewItemButton
            // 
            addNewItemButton.Location = new Point(283, 237);
            addNewItemButton.Margin = new Padding(3, 2, 3, 2);
            addNewItemButton.Name = "addNewItemButton";
            addNewItemButton.Size = new Size(103, 22);
            addNewItemButton.TabIndex = 1;
            addNewItemButton.Text = "Add new item";
            addNewItemButton.UseVisualStyleBackColor = true;
            addNewItemButton.Click += addNewItemButton_Click;
            // 
            // itemsListBox
            // 
            itemsListBox.FormattingEnabled = true;
            itemsListBox.ItemHeight = 15;
            itemsListBox.Location = new Point(18, 30);
            itemsListBox.Margin = new Padding(3, 2, 3, 2);
            itemsListBox.Name = "itemsListBox";
            itemsListBox.Size = new Size(242, 229);
            itemsListBox.TabIndex = 0;
            itemsListBox.SelectedIndexChanged += itemsListBox_SelectedIndexChanged;
            // 
            // tabPage2
            // 
            tabPage2.BackgroundImage = (Image)resources.GetObject("tabPage2.BackgroundImage");
            tabPage2.Controls.Add(chooseTransportButton);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Margin = new Padding(3, 2, 3, 2);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3, 2, 3, 2);
            tabPage2.Size = new Size(695, 312);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Orders";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // chooseTransportButton
            // 
            chooseTransportButton.Location = new Point(264, 121);
            chooseTransportButton.Margin = new Padding(3, 2, 3, 2);
            chooseTransportButton.Name = "chooseTransportButton";
            chooseTransportButton.Size = new Size(154, 44);
            chooseTransportButton.TabIndex = 2;
            chooseTransportButton.Text = "Choose Transport";
            chooseTransportButton.UseVisualStyleBackColor = true;
            chooseTransportButton.Click += chooseTransportButton_Click;
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
            tabPage4.Location = new Point(4, 24);
            tabPage4.Margin = new Padding(3, 2, 3, 2);
            tabPage4.Name = "tabPage4";
            tabPage4.Padding = new Padding(3, 2, 3, 2);
            tabPage4.Size = new Size(695, 312);
            tabPage4.TabIndex = 3;
            tabPage4.Text = "Add a new admin";
            tabPage4.UseVisualStyleBackColor = true;
            // 
            // logOutButton
            // 
            logOutButton.Location = new Point(595, 13);
            logOutButton.Margin = new Padding(3, 2, 3, 2);
            logOutButton.Name = "logOutButton";
            logOutButton.Size = new Size(82, 22);
            logOutButton.TabIndex = 14;
            logOutButton.Text = "Log out";
            logOutButton.UseVisualStyleBackColor = true;
            logOutButton.Click += logOutButton_Click;
            // 
            // registerButton
            // 
            registerButton.Location = new Point(294, 192);
            registerButton.Margin = new Padding(3, 2, 3, 2);
            registerButton.Name = "registerButton";
            registerButton.Size = new Size(127, 22);
            registerButton.TabIndex = 13;
            registerButton.Text = "Register";
            registerButton.UseVisualStyleBackColor = true;
            registerButton.Click += registerButton_Click;
            // 
            // passwordLabel
            // 
            passwordLabel.AutoSize = true;
            passwordLabel.Location = new Point(216, 152);
            passwordLabel.Name = "passwordLabel";
            passwordLabel.Size = new Size(60, 15);
            passwordLabel.TabIndex = 12;
            passwordLabel.Text = "Password:";
            // 
            // usernameLabel
            // 
            usernameLabel.AutoSize = true;
            usernameLabel.Location = new Point(216, 104);
            usernameLabel.Name = "usernameLabel";
            usernameLabel.Size = new Size(63, 15);
            usernameLabel.TabIndex = 11;
            usernameLabel.Text = "Username:";
            // 
            // passwordTextBox
            // 
            passwordTextBox.Location = new Point(294, 146);
            passwordTextBox.Margin = new Padding(3, 2, 3, 2);
            passwordTextBox.Name = "passwordTextBox";
            passwordTextBox.Size = new Size(162, 23);
            passwordTextBox.TabIndex = 10;
            // 
            // usernameTextBox
            // 
            usernameTextBox.Location = new Point(294, 103);
            usernameTextBox.Margin = new Padding(3, 2, 3, 2);
            usernameTextBox.Name = "usernameTextBox";
            usernameTextBox.Size = new Size(162, 23);
            usernameTextBox.TabIndex = 9;
            // 
            // AdminMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(698, 334);
            Controls.Add(tabControl1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "AdminMenu";
            Text = "AdminMenu";
            FormClosed += AdminMenu_FormClosed;
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
        private Label label3;
        private TextBox idTextBox;
        private Label label2;
        private TextBox nameTextBox;
        private Label label1;
        private TextBox categoryTextBox;
        private Label label6;
        private TextBox descriptionTextBox;
        private Label label5;
        private TextBox quantityTextBox;
        private Label label4;
        private TextBox priceTextBox;
    }
}