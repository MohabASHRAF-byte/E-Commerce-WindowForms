namespace SWProject
{
    partial class RegisterForm
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
            this.loginMenuReturn = new System.Windows.Forms.Button();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.usernameLabel = new System.Windows.Forms.Label();
            this.passwordInp = new System.Windows.Forms.TextBox();
            this.usernameInp = new System.Windows.Forms.TextBox();
            this.RegisterBtn = new System.Windows.Forms.Button();
            this.confirmPasswordLabel = new System.Windows.Forms.Label();
            this.confirmPasswordInp = new System.Windows.Forms.TextBox();
            this.roleLabel = new System.Windows.Forms.Label();
            this.roleInp = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // loginMenuReturn
            // 
            this.loginMenuReturn.Location = new System.Drawing.Point(41, 205);
            this.loginMenuReturn.Name = "loginMenuReturn";
            this.loginMenuReturn.Size = new System.Drawing.Size(106, 45);
            this.loginMenuReturn.TabIndex = 11;
            this.loginMenuReturn.Text = "Return to menu";
            this.loginMenuReturn.UseVisualStyleBackColor = true;
            this.loginMenuReturn.Click += new System.EventHandler(this.loginMenuReturn_Click);
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Location = new System.Drawing.Point(27, 117);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(53, 13);
            this.passwordLabel.TabIndex = 10;
            this.passwordLabel.Text = "Password";
            // 
            // usernameLabel
            // 
            this.usernameLabel.AutoSize = true;
            this.usernameLabel.Location = new System.Drawing.Point(27, 41);
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Size = new System.Drawing.Size(55, 13);
            this.usernameLabel.TabIndex = 9;
            this.usernameLabel.Text = "Username";
            // 
            // passwordInp
            // 
            this.passwordInp.Location = new System.Drawing.Point(126, 114);
            this.passwordInp.Name = "passwordInp";
            this.passwordInp.PasswordChar = '*';
            this.passwordInp.Size = new System.Drawing.Size(157, 20);
            this.passwordInp.TabIndex = 8;
            // 
            // usernameInp
            // 
            this.usernameInp.Location = new System.Drawing.Point(126, 38);
            this.usernameInp.Name = "usernameInp";
            this.usernameInp.Size = new System.Drawing.Size(157, 20);
            this.usernameInp.TabIndex = 7;
            // 
            // RegisterBtn
            // 
            this.RegisterBtn.Location = new System.Drawing.Point(153, 205);
            this.RegisterBtn.Name = "RegisterBtn";
            this.RegisterBtn.Size = new System.Drawing.Size(106, 45);
            this.RegisterBtn.TabIndex = 6;
            this.RegisterBtn.Text = "Register";
            this.RegisterBtn.UseVisualStyleBackColor = true;
            this.RegisterBtn.Click += new System.EventHandler(this.RegisterBtn_Click);
            // 
            // confirmPasswordLabel
            // 
            this.confirmPasswordLabel.AutoSize = true;
            this.confirmPasswordLabel.Location = new System.Drawing.Point(27, 160);
            this.confirmPasswordLabel.Name = "confirmPasswordLabel";
            this.confirmPasswordLabel.Size = new System.Drawing.Size(91, 13);
            this.confirmPasswordLabel.TabIndex = 13;
            this.confirmPasswordLabel.Text = "Confirm Password";
            // 
            // confirmPasswordInp
            // 
            this.confirmPasswordInp.Location = new System.Drawing.Point(126, 157);
            this.confirmPasswordInp.Name = "confirmPasswordInp";
            this.confirmPasswordInp.PasswordChar = '*';
            this.confirmPasswordInp.Size = new System.Drawing.Size(157, 20);
            this.confirmPasswordInp.TabIndex = 12;
            // 
            // roleLabel
            // 
            this.roleLabel.AutoSize = true;
            this.roleLabel.Location = new System.Drawing.Point(27, 79);
            this.roleLabel.Name = "roleLabel";
            this.roleLabel.Size = new System.Drawing.Size(29, 13);
            this.roleLabel.TabIndex = 14;
            this.roleLabel.Text = "Role";
            // 
            // roleInp
            // 
            this.roleInp.FormattingEnabled = true;
            this.roleInp.Items.AddRange(new object[] {
            "User",
            "Artist"});
            this.roleInp.Location = new System.Drawing.Point(126, 76);
            this.roleInp.Name = "roleInp";
            this.roleInp.Size = new System.Drawing.Size(157, 21);
            this.roleInp.TabIndex = 16;
            // 
            // RegisterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(313, 279);
            this.Controls.Add(this.roleInp);
            this.Controls.Add(this.roleLabel);
            this.Controls.Add(this.confirmPasswordLabel);
            this.Controls.Add(this.confirmPasswordInp);
            this.Controls.Add(this.loginMenuReturn);
            this.Controls.Add(this.passwordLabel);
            this.Controls.Add(this.usernameLabel);
            this.Controls.Add(this.passwordInp);
            this.Controls.Add(this.usernameInp);
            this.Controls.Add(this.RegisterBtn);
            this.Name = "RegisterForm";
            this.Text = "RegisterForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.RegisterForm_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button loginMenuReturn;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.Label usernameLabel;
        private System.Windows.Forms.TextBox passwordInp;
        private System.Windows.Forms.TextBox usernameInp;
        private System.Windows.Forms.Button RegisterBtn;
        private System.Windows.Forms.Label confirmPasswordLabel;
        private System.Windows.Forms.TextBox confirmPasswordInp;
        private System.Windows.Forms.Label roleLabel;
        private System.Windows.Forms.ComboBox roleInp;
    }
}