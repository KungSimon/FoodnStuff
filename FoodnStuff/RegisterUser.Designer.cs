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
            SuspendLayout();
            // 
            // registerButton
            // 
            registerButton.Location = new Point(322, 253);
            registerButton.Name = "registerButton";
            registerButton.Size = new Size(145, 29);
            registerButton.TabIndex = 18;
            registerButton.Text = "Register";
            registerButton.UseVisualStyleBackColor = true;
            // 
            // passwordLabel
            // 
            passwordLabel.AutoSize = true;
            passwordLabel.Location = new Point(209, 196);
            passwordLabel.Name = "passwordLabel";
            passwordLabel.Size = new Size(73, 20);
            passwordLabel.TabIndex = 17;
            passwordLabel.Text = "Password:";
            // 
            // usernameLabel
            // 
            usernameLabel.AutoSize = true;
            usernameLabel.Location = new Point(209, 132);
            usernameLabel.Name = "usernameLabel";
            usernameLabel.Size = new Size(78, 20);
            usernameLabel.TabIndex = 16;
            usernameLabel.Text = "Username:";
            // 
            // passwordTextBox
            // 
            passwordTextBox.Location = new Point(298, 189);
            passwordTextBox.Name = "passwordTextBox";
            passwordTextBox.Size = new Size(229, 27);
            passwordTextBox.TabIndex = 15;
            // 
            // usernameTextBox
            // 
            usernameTextBox.Location = new Point(298, 131);
            usernameTextBox.Name = "usernameTextBox";
            usernameTextBox.Size = new Size(229, 27);
            usernameTextBox.TabIndex = 14;
            // 
            // RegisterUser
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
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
    }
}