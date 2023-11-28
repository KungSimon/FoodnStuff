namespace FoodnStuff
{
    partial class RegisterUser
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
            registerButton = new Button();
            passwordLabel = new Label();
            usernameLabel = new Label();
            passwordTextBox = new TextBox();
            usernameTextBox = new TextBox();
            nameLabel = new Label();
            nameTextBox = new TextBox();
            label2 = new Label();
            addressTextBox = new TextBox();
            SuspendLayout();
            // 
            // registerButton
            // 
            registerButton.Location = new Point(120, 287);
            registerButton.Name = "registerButton";
            registerButton.Size = new Size(145, 29);
            registerButton.TabIndex = 18;
            registerButton.Text = "Register";
            registerButton.UseVisualStyleBackColor = true;
            registerButton.Click += registerButton_Click;
            // 
            // passwordLabel
            // 
            passwordLabel.AutoSize = true;
            passwordLabel.Location = new Point(31, 156);
            passwordLabel.Name = "passwordLabel";
            passwordLabel.Size = new Size(73, 20);
            passwordLabel.TabIndex = 17;
            passwordLabel.Text = "Password:";
            // 
            // usernameLabel
            // 
            usernameLabel.AutoSize = true;
            usernameLabel.Location = new Point(31, 92);
            usernameLabel.Name = "usernameLabel";
            usernameLabel.Size = new Size(78, 20);
            usernameLabel.TabIndex = 16;
            usernameLabel.Text = "Username:";
            // 
            // passwordTextBox
            // 
            passwordTextBox.Location = new Point(120, 149);
            passwordTextBox.Name = "passwordTextBox";
            passwordTextBox.Size = new Size(229, 27);
            passwordTextBox.TabIndex = 15;
            // 
            // usernameTextBox
            // 
            usernameTextBox.Location = new Point(120, 91);
            usernameTextBox.Name = "usernameTextBox";
            usernameTextBox.Size = new Size(229, 27);
            usernameTextBox.TabIndex = 14;
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Location = new Point(42, 34);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new Size(52, 20);
            nameLabel.TabIndex = 20;
            nameLabel.Text = "Name:";
            // 
            // nameTextBox
            // 
            nameTextBox.Location = new Point(120, 34);
            nameTextBox.Name = "nameTextBox";
            nameTextBox.Size = new Size(229, 27);
            nameTextBox.TabIndex = 19;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(31, 214);
            label2.Name = "label2";
            label2.Size = new Size(65, 20);
            label2.TabIndex = 22;
            label2.Text = "Address:";
            // 
            // addressTextBox
            // 
            addressTextBox.Location = new Point(120, 207);
            addressTextBox.Name = "addressTextBox";
            addressTextBox.Size = new Size(229, 27);
            addressTextBox.TabIndex = 21;
            // 
            // RegisterUser
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label2);
            Controls.Add(addressTextBox);
            Controls.Add(nameLabel);
            Controls.Add(nameTextBox);
            Controls.Add(registerButton);
            Controls.Add(passwordLabel);
            Controls.Add(usernameLabel);
            Controls.Add(passwordTextBox);
            Controls.Add(usernameTextBox);
            Name = "RegisterUser";
            Text = "RegisterUser";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button registerButton;
        private Label passwordLabel;
        private Label usernameLabel;
        private TextBox passwordTextBox;
        private TextBox usernameTextBox;
        private Label nameLabel;
        private TextBox nameTextBox;
        private Label label2;
        private TextBox addressTextBox;
    }
}