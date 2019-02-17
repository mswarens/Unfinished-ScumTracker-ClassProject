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
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // loginUsername
            // 
            this.loginUsername.Location = new System.Drawing.Point(241, 255);
            this.loginUsername.Name = "loginUsername";
            this.loginUsername.Size = new System.Drawing.Size(303, 20);
            this.loginUsername.TabIndex = 1;
            this.loginUsername.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // loginPassword
            // 
            this.loginPassword.Location = new System.Drawing.Point(241, 323);
            this.loginPassword.Name = "loginPassword";
            this.loginPassword.Size = new System.Drawing.Size(303, 20);
            this.loginPassword.TabIndex = 2;
            this.loginPassword.UseSystemPasswordChar = true;
            // 
            // loginButton
            // 
            this.loginButton.Font = new System.Drawing.Font("Times New Roman", 8.5F, System.Drawing.FontStyle.Bold);
            this.loginButton.Location = new System.Drawing.Point(241, 382);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(303, 25);
            this.loginButton.TabIndex = 3;
            this.loginButton.Text = "Login";
            this.loginButton.UseVisualStyleBackColor = true;
            // 
            // projectTitleLogin
            // 
            this.projectTitleLogin.AutoSize = true;
            this.projectTitleLogin.CausesValidation = false;
            this.projectTitleLogin.Font = new System.Drawing.Font("Times New Roman", 40F);
            this.projectTitleLogin.Location = new System.Drawing.Point(34, 79);
            this.projectTitleLogin.Name = "projectTitleLogin";
            this.projectTitleLogin.Size = new System.Drawing.Size(708, 61);
            this.projectTitleLogin.TabIndex = 4;
            this.projectTitleLogin.Text = "Scrum Project Tracking System";
            // 
            // usernameLabelLogin
            // 
            this.usernameLabelLogin.AutoSize = true;
            this.usernameLabelLogin.Font = new System.Drawing.Font("Times New Roman", 13F);
            this.usernameLabelLogin.Location = new System.Drawing.Point(153, 254);
            this.usernameLabelLogin.Name = "usernameLabelLogin";
            this.usernameLabelLogin.Size = new System.Drawing.Size(82, 20);
            this.usernameLabelLogin.TabIndex = 5;
            this.usernameLabelLogin.Text = "Username";
            // 
            // passwordLabelLogin
            // 
            this.passwordLabelLogin.AutoSize = true;
            this.passwordLabelLogin.Font = new System.Drawing.Font("Times New Roman", 13F);
            this.passwordLabelLogin.Location = new System.Drawing.Point(156, 322);
            this.passwordLabelLogin.Name = "passwordLabelLogin";
            this.passwordLabelLogin.Size = new System.Drawing.Size(79, 20);
            this.passwordLabelLogin.TabIndex = 6;
            this.passwordLabelLogin.Text = "Password";
            this.passwordLabelLogin.Click += new System.EventHandler(this.passwordLabelLogin_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Bold);
            this.button1.Location = new System.Drawing.Point(241, 450);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(303, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "New Account Creation";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // FrmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 485);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.passwordLabelLogin);
            this.Controls.Add(this.usernameLabelLogin);
            this.Controls.Add(this.projectTitleLogin);
            this.Controls.Add(this.loginButton);
            this.Controls.Add(this.loginPassword);
            this.Controls.Add(this.loginUsername);
            this.Font = new System.Drawing.Font("Times New Roman", 8.25F);
            this.Name = "FrmLogin";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Form1_Load);
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
        private System.Windows.Forms.Button button1;
    }
}