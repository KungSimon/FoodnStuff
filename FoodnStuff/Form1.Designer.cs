namespace FoodnStuff
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            itemsListBox = new ListBox();
            addToCartButton = new Button();
            searchLabel = new Label();
            searchTextBox = new TextBox();
            catagoryListBox = new ListBox();
            tabPage2 = new TabPage();
            proceedToCheckoutButton = new Button();
            button1 = new Button();
            cartLabel = new Label();
            listBox2 = new ListBox();
            tabPage3 = new TabPage();
            logOutButton = new Button();
            logInButton = new Button();
            label1 = new Label();
            logInWorkerButton = new Button();
            registerLabel = new Label();
            registerButton = new Button();
            passwordLabel = new Label();
            usernameLabel = new Label();
            passwordTextBox = new TextBox();
            usernameTextBox = new TextBox();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            tabPage3.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Location = new Point(1, 0);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(993, 526);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.BackgroundImage = (Image)resources.GetObject("tabPage1.BackgroundImage");
            tabPage1.Controls.Add(itemsListBox);
            tabPage1.Controls.Add(addToCartButton);
            tabPage1.Controls.Add(searchLabel);
            tabPage1.Controls.Add(searchTextBox);
            tabPage1.Controls.Add(catagoryListBox);
            tabPage1.Location = new Point(4, 29);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(985, 493);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Items";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // itemsListBox
            // 
            itemsListBox.FormattingEnabled = true;
            itemsListBox.ItemHeight = 20;
            itemsListBox.Location = new Point(417, 87);
            itemsListBox.Name = "itemsListBox";
            itemsListBox.Size = new Size(508, 384);
            itemsListBox.TabIndex = 4;
            itemsListBox.Visible = false;
            // 
            // addToCartButton
            // 
            addToCartButton.Location = new Point(221, 87);
            addToCartButton.Name = "addToCartButton";
            addToCartButton.Size = new Size(94, 29);
            addToCartButton.TabIndex = 3;
            addToCartButton.Text = "Add to cart";
            addToCartButton.UseVisualStyleBackColor = true;
            addToCartButton.Click += addToCartButton_Click;
            // 
            // searchLabel
            // 
            searchLabel.AutoSize = true;
            searchLabel.Location = new Point(11, 27);
            searchLabel.Name = "searchLabel";
            searchLabel.Size = new Size(53, 20);
            searchLabel.TabIndex = 2;
            searchLabel.Text = "Search";
            // 
            // searchTextBox
            // 
            searchTextBox.Location = new Point(92, 27);
            searchTextBox.Name = "searchTextBox";
            searchTextBox.Size = new Size(251, 27);
            searchTextBox.TabIndex = 1;
            // 
            // catagoryListBox
            // 
            catagoryListBox.FormattingEnabled = true;
            catagoryListBox.ItemHeight = 20;
            catagoryListBox.Location = new Point(11, 147);
            catagoryListBox.Name = "catagoryListBox";
            catagoryListBox.Size = new Size(383, 324);
            catagoryListBox.TabIndex = 0;
            catagoryListBox.SelectedIndexChanged += catagoryListBox_SelectedIndexChanged;
            // 
            // tabPage2
            // 
            tabPage2.BackgroundImage = (Image)resources.GetObject("tabPage2.BackgroundImage");
            tabPage2.Controls.Add(proceedToCheckoutButton);
            tabPage2.Controls.Add(button1);
            tabPage2.Controls.Add(cartLabel);
            tabPage2.Controls.Add(listBox2);
            tabPage2.Location = new Point(4, 29);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(985, 493);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Cart";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // proceedToCheckoutButton
            // 
            proceedToCheckoutButton.Location = new Point(344, 119);
            proceedToCheckoutButton.Name = "proceedToCheckoutButton";
            proceedToCheckoutButton.Size = new Size(182, 29);
            proceedToCheckoutButton.TabIndex = 3;
            proceedToCheckoutButton.Text = "Proceed to checkout";
            proceedToCheckoutButton.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(67, 430);
            button1.Name = "button1";
            button1.Size = new Size(182, 29);
            button1.TabIndex = 2;
            button1.Text = "Remove item from cart";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // cartLabel
            // 
            cartLabel.AutoSize = true;
            cartLabel.Location = new Point(31, 41);
            cartLabel.Name = "cartLabel";
            cartLabel.Size = new Size(67, 20);
            cartLabel.TabIndex = 1;
            cartLabel.Text = "Your cart";
            // 
            // listBox2
            // 
            listBox2.FormattingEnabled = true;
            listBox2.ItemHeight = 20;
            listBox2.Location = new Point(31, 64);
            listBox2.Name = "listBox2";
            listBox2.Size = new Size(262, 344);
            listBox2.TabIndex = 0;
            listBox2.SelectedIndexChanged += listBox2_SelectedIndexChanged;
            // 
            // tabPage3
            // 
            tabPage3.BackgroundImage = (Image)resources.GetObject("tabPage3.BackgroundImage");
            tabPage3.Controls.Add(logOutButton);
            tabPage3.Controls.Add(logInButton);
            tabPage3.Controls.Add(label1);
            tabPage3.Controls.Add(logInWorkerButton);
            tabPage3.Controls.Add(registerLabel);
            tabPage3.Controls.Add(registerButton);
            tabPage3.Controls.Add(passwordLabel);
            tabPage3.Controls.Add(usernameLabel);
            tabPage3.Controls.Add(passwordTextBox);
            tabPage3.Controls.Add(usernameTextBox);
            tabPage3.Location = new Point(4, 29);
            tabPage3.Name = "tabPage3";
            tabPage3.Size = new Size(985, 493);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Log In";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // logOutButton
            // 
            logOutButton.Location = new Point(871, 15);
            logOutButton.Name = "logOutButton";
            logOutButton.Size = new Size(94, 29);
            logOutButton.TabIndex = 15;
            logOutButton.Text = "Log out";
            logOutButton.UseVisualStyleBackColor = true;
            // 
            // logInButton
            // 
            logInButton.Location = new Point(150, 151);
            logInButton.Name = "logInButton";
            logInButton.Size = new Size(145, 29);
            logInButton.TabIndex = 8;
            logInButton.Text = "Log In";
            logInButton.UseVisualStyleBackColor = true;
            logInButton.Click += logInButton_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = SystemColors.ControlText;
            label1.Location = new Point(821, 366);
            label1.Name = "label1";
            label1.Size = new Size(122, 20);
            label1.TabIndex = 7;
            label1.Text = "To workers log in";
            // 
            // logInWorkerButton
            // 
            logInWorkerButton.Location = new Point(805, 405);
            logInWorkerButton.Name = "logInWorkerButton";
            logInWorkerButton.Size = new Size(160, 29);
            logInWorkerButton.TabIndex = 6;
            logInWorkerButton.Text = "Log In";
            logInWorkerButton.UseVisualStyleBackColor = true;
            logInWorkerButton.Click += logInWorkerButton_Click;
            // 
            // registerLabel
            // 
            registerLabel.AutoSize = true;
            registerLabel.ForeColor = SystemColors.ControlText;
            registerLabel.Location = new Point(17, 366);
            registerLabel.Name = "registerLabel";
            registerLabel.Size = new Size(335, 20);
            registerLabel.TabIndex = 5;
            registerLabel.Text = "Dont have a account? Register for exclusive deals";
            // 
            // registerButton
            // 
            registerButton.Location = new Point(78, 405);
            registerButton.Name = "registerButton";
            registerButton.Size = new Size(160, 29);
            registerButton.TabIndex = 4;
            registerButton.Text = "Register";
            registerButton.UseVisualStyleBackColor = true;
            registerButton.Click += registerButton_Click;
            // 
            // passwordLabel
            // 
            passwordLabel.AutoSize = true;
            passwordLabel.Location = new Point(50, 100);
            passwordLabel.Name = "passwordLabel";
            passwordLabel.Size = new Size(73, 20);
            passwordLabel.TabIndex = 3;
            passwordLabel.Text = "Password:";
            // 
            // usernameLabel
            // 
            usernameLabel.AutoSize = true;
            usernameLabel.Location = new Point(50, 36);
            usernameLabel.Name = "usernameLabel";
            usernameLabel.Size = new Size(78, 20);
            usernameLabel.TabIndex = 2;
            usernameLabel.Text = "Username:";
            // 
            // passwordTextBox
            // 
            passwordTextBox.Location = new Point(139, 93);
            passwordTextBox.Name = "passwordTextBox";
            passwordTextBox.Size = new Size(185, 27);
            passwordTextBox.TabIndex = 1;
            // 
            // usernameTextBox
            // 
            usernameTextBox.Location = new Point(139, 35);
            usernameTextBox.Name = "usernameTextBox";
            usernameTextBox.Size = new Size(185, 27);
            usernameTextBox.TabIndex = 0;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(992, 528);
            Controls.Add(tabControl1);
            Name = "Form1";
            Text = "Form1";
            Load += catagoryListBox_SelectedIndexChanged;
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            tabPage3.ResumeLayout(false);
            tabPage3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private TextBox searchTextBox;
        private ListBox catagoryListBox;
        private TabPage tabPage2;
        private TabPage tabPage3;
        private Button addToCartButton;
        private Label searchLabel;
        private Label cartLabel;
        private ListBox listBox2;
        private Button proceedToCheckoutButton;
        private Button button1;
        private Label label1;
        private Button logInWorkerButton;
        private Label registerLabel;
        private Button registerButton;
        private Label passwordLabel;
        private Label usernameLabel;
        private TextBox passwordTextBox;
        private TextBox usernameTextBox;
        private Button logInButton;
        private ListBox itemsListBox;
        private Button logOutButton;
    }
}