namespace exampelProject
{
    partial class Login
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnLogin = new System.Windows.Forms.Button();
            this.lblUsername = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.tBUsername = new System.Windows.Forms.TextBox();
            this.tBPassword = new System.Windows.Forms.TextBox();
            this.lblPWVisable = new System.Windows.Forms.Label();
            this.cBShowPW = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // btnLogin
            // 
            this.btnLogin.Enabled = false;
            this.btnLogin.Location = new System.Drawing.Point(82, 161);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(75, 23);
            this.btnLogin.TabIndex = 0;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Location = new System.Drawing.Point(20, 55);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(58, 13);
            this.lblUsername.TabIndex = 1;
            this.lblUsername.Text = "Username:";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(20, 91);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(56, 13);
            this.lblPassword.TabIndex = 2;
            this.lblPassword.Text = "Password:";
            // 
            // tBUsername
            // 
            this.tBUsername.Location = new System.Drawing.Point(82, 52);
            this.tBUsername.Name = "tBUsername";
            this.tBUsername.Size = new System.Drawing.Size(100, 20);
            this.tBUsername.TabIndex = 3;
            this.tBUsername.TextChanged += new System.EventHandler(this.usernameChanged);
            // 
            // tBPassword
            // 
            this.tBPassword.Location = new System.Drawing.Point(82, 88);
            this.tBPassword.Name = "tBPassword";
            this.tBPassword.Size = new System.Drawing.Size(100, 20);
            this.tBPassword.TabIndex = 4;
            this.tBPassword.TextChanged += new System.EventHandler(this.passwordChanged);
            // 
            // lblPWVisable
            // 
            this.lblPWVisable.AutoSize = true;
            this.lblPWVisable.Location = new System.Drawing.Point(79, 134);
            this.lblPWVisable.Name = "lblPWVisable";
            this.lblPWVisable.Size = new System.Drawing.Size(0, 13);
            this.lblPWVisable.TabIndex = 5;
            // 
            // cBShowPW
            // 
            this.cBShowPW.AutoSize = true;
            this.cBShowPW.Location = new System.Drawing.Point(82, 114);
            this.cBShowPW.Name = "cBShowPW";
            this.cBShowPW.Size = new System.Drawing.Size(99, 17);
            this.cBShowPW.TabIndex = 6;
            this.cBShowPW.Text = "show password";
            this.cBShowPW.UseVisualStyleBackColor = true;
            this.cBShowPW.CheckedChanged += new System.EventHandler(this.checkChanged);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(295, 196);
            this.Controls.Add(this.cBShowPW);
            this.Controls.Add(this.lblPWVisable);
            this.Controls.Add(this.tBPassword);
            this.Controls.Add(this.tBUsername);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.btnLogin);
            this.Name = "Login";
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox tBUsername;
        private System.Windows.Forms.TextBox tBPassword;
        private System.Windows.Forms.Label lblPWVisable;
        private System.Windows.Forms.CheckBox cBShowPW;
    }
}

