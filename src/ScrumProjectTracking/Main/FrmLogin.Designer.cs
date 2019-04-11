namespace ScrumProjectTracking
{
    partial class FrmLogin
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
            this.loginUsername = new System.Windows.Forms.TextBox();
            this.loginPassword = new System.Windows.Forms.TextBox();
            this.loginButton = new System.Windows.Forms.Button();
            this.projectTitleLogin = new System.Windows.Forms.Label();
            this.usernameLabelLogin = new System.Windows.Forms.Label();
            this.passwordLabelLogin = new System.Windows.Forms.Label();
            this.FrmLoginMsg = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // loginUsername
            // 
            this.loginUsername.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginUsername.Location = new System.Drawing.Point(149, 77);
            this.loginUsername.Name = "loginUsername";
            this.loginUsername.Size = new System.Drawing.Size(123, 27);
            this.loginUsername.TabIndex = 1;
            // 
            // loginPassword
            // 
            this.loginPassword.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginPassword.Location = new System.Drawing.Point(149, 106);
            this.loginPassword.Name = "loginPassword";
            this.loginPassword.Size = new System.Drawing.Size(123, 27);
            this.loginPassword.TabIndex = 2;
            this.loginPassword.UseSystemPasswordChar = true;
            // 
            // loginButton
            // 
            this.loginButton.Font = new System.Drawing.Font("Calibri", 12F);
            this.loginButton.Location = new System.Drawing.Point(278, 77);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(82, 27);
            this.loginButton.TabIndex = 3;
            this.loginButton.Text = "Login";
            this.loginButton.UseVisualStyleBackColor = true;
            this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
            // 
            // projectTitleLogin
            // 
            this.projectTitleLogin.AutoSize = true;
            this.projectTitleLogin.CausesValidation = false;
            this.projectTitleLogin.Font = new System.Drawing.Font("Calibri", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.projectTitleLogin.Location = new System.Drawing.Point(12, 18);
            this.projectTitleLogin.Name = "projectTitleLogin";
            this.projectTitleLogin.Size = new System.Drawing.Size(449, 42);
            this.projectTitleLogin.TabIndex = 4;
            this.projectTitleLogin.Text = "Scrum Project Tracking System";
            // 
            // usernameLabelLogin
            // 
            this.usernameLabelLogin.AutoSize = true;
            this.usernameLabelLogin.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameLabelLogin.Location = new System.Drawing.Point(68, 80);
            this.usernameLabelLogin.Name = "usernameLabelLogin";
            this.usernameLabelLogin.Size = new System.Drawing.Size(75, 19);
            this.usernameLabelLogin.TabIndex = 5;
            this.usernameLabelLogin.Text = "Username";
            // 
            // passwordLabelLogin
            // 
            this.passwordLabelLogin.AutoSize = true;
            this.passwordLabelLogin.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordLabelLogin.Location = new System.Drawing.Point(71, 109);
            this.passwordLabelLogin.Name = "passwordLabelLogin";
            this.passwordLabelLogin.Size = new System.Drawing.Size(71, 19);
            this.passwordLabelLogin.TabIndex = 6;
            this.passwordLabelLogin.Text = "Password";
            // 
            // FrmLoginMsg
            // 
            this.FrmLoginMsg.AutoSize = true;
            this.FrmLoginMsg.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.FrmLoginMsg.Location = new System.Drawing.Point(48, 165);
            this.FrmLoginMsg.Name = "FrmLoginMsg";
            this.FrmLoginMsg.Size = new System.Drawing.Size(331, 17);
            this.FrmLoginMsg.TabIndex = 7;
            this.FrmLoginMsg.Text = "Username: MSWARENS or SSHROUT Password: test123";
            // 
            // FrmLogin
            // 
            this.AcceptButton = this.loginButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(488, 227);
            this.Controls.Add(this.FrmLoginMsg);
            this.Controls.Add(this.passwordLabelLogin);
            this.Controls.Add(this.usernameLabelLogin);
            this.Controls.Add(this.projectTitleLogin);
            this.Controls.Add(this.loginButton);
            this.Controls.Add(this.loginPassword);
            this.Controls.Add(this.loginUsername);
            this.Font = new System.Drawing.Font("Times New Roman", 8.25F);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmLogin";
            this.Text = "Login";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmLogin_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox loginUsername;
        private System.Windows.Forms.TextBox loginPassword;
        private System.Windows.Forms.Button loginButton;
        private System.Windows.Forms.Label projectTitleLogin;
        private System.Windows.Forms.Label usernameLabelLogin;
        private System.Windows.Forms.Label passwordLabelLogin;
        private System.Windows.Forms.Label FrmLoginMsg;
    }
}
