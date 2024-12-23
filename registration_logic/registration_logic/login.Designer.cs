namespace registration_logic
{
    partial class login
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
            this.pnlLogIn = new System.Windows.Forms.Panel();
            this.btnLogin = new System.Windows.Forms.Button();
            this.txtLogInPassword = new System.Windows.Forms.TextBox();
            this.txtLogInUserName = new System.Windows.Forms.TextBox();
            this.lblLoginPassword = new System.Windows.Forms.Label();
            this.lblLoginUserName = new System.Windows.Forms.Label();
            this.lblLogInPage = new System.Windows.Forms.Label();
            this.lnkLogInBack = new System.Windows.Forms.LinkLabel();
            this.pnlLogIn.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlLogIn
            // 
            this.pnlLogIn.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.pnlLogIn.Controls.Add(this.btnLogin);
            this.pnlLogIn.Controls.Add(this.txtLogInPassword);
            this.pnlLogIn.Controls.Add(this.txtLogInUserName);
            this.pnlLogIn.Controls.Add(this.lblLoginPassword);
            this.pnlLogIn.Controls.Add(this.lblLoginUserName);
            this.pnlLogIn.Location = new System.Drawing.Point(211, 86);
            this.pnlLogIn.Name = "pnlLogIn";
            this.pnlLogIn.Size = new System.Drawing.Size(396, 209);
            this.pnlLogIn.TabIndex = 10;
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(145, 153);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(75, 23);
            this.btnLogin.TabIndex = 8;
            this.btnLogin.Text = "LOGIN";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // txtLogInPassword
            // 
            this.txtLogInPassword.Location = new System.Drawing.Point(186, 85);
            this.txtLogInPassword.Name = "txtLogInPassword";
            this.txtLogInPassword.Size = new System.Drawing.Size(148, 20);
            this.txtLogInPassword.TabIndex = 5;
            // 
            // txtLogInUserName
            // 
            this.txtLogInUserName.Location = new System.Drawing.Point(186, 37);
            this.txtLogInUserName.Name = "txtLogInUserName";
            this.txtLogInUserName.Size = new System.Drawing.Size(148, 20);
            this.txtLogInUserName.TabIndex = 4;
            // 
            // lblLoginPassword
            // 
            this.lblLoginPassword.AutoSize = true;
            this.lblLoginPassword.Location = new System.Drawing.Point(36, 85);
            this.lblLoginPassword.Name = "lblLoginPassword";
            this.lblLoginPassword.Size = new System.Drawing.Size(70, 13);
            this.lblLoginPassword.TabIndex = 2;
            this.lblLoginPassword.Text = "PASSWORD";
            // 
            // lblLoginUserName
            // 
            this.lblLoginUserName.AutoSize = true;
            this.lblLoginUserName.Location = new System.Drawing.Point(36, 44);
            this.lblLoginUserName.Name = "lblLoginUserName";
            this.lblLoginUserName.Size = new System.Drawing.Size(68, 13);
            this.lblLoginUserName.TabIndex = 1;
            this.lblLoginUserName.Text = "USERNAME";
            // 
            // lblLogInPage
            // 
            this.lblLogInPage.AutoSize = true;
            this.lblLogInPage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogInPage.Location = new System.Drawing.Point(372, 24);
            this.lblLogInPage.Name = "lblLogInPage";
            this.lblLogInPage.Size = new System.Drawing.Size(59, 20);
            this.lblLogInPage.TabIndex = 11;
            this.lblLogInPage.Tag = "df";
            this.lblLogInPage.Text = "LOGIN";
            // 
            // lnkLogInBack
            // 
            this.lnkLogInBack.AutoSize = true;
            this.lnkLogInBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnkLogInBack.Location = new System.Drawing.Point(769, 27);
            this.lnkLogInBack.Name = "lnkLogInBack";
            this.lnkLogInBack.Size = new System.Drawing.Size(43, 16);
            this.lnkLogInBack.TabIndex = 12;
            this.lnkLogInBack.TabStop = true;
            this.lnkLogInBack.Text = "BACK";
            this.lnkLogInBack.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkLogInBack_LinkClicked);
            // 
            // login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(883, 363);
            this.Controls.Add(this.lnkLogInBack);
            this.Controls.Add(this.lblLogInPage);
            this.Controls.Add(this.pnlLogIn);
            this.Name = "login";
            this.Text = "login";
            this.pnlLogIn.ResumeLayout(false);
            this.pnlLogIn.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlLogIn;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.TextBox txtLogInPassword;
        private System.Windows.Forms.TextBox txtLogInUserName;
        private System.Windows.Forms.Label lblLoginPassword;
        private System.Windows.Forms.Label lblLoginUserName;
        private System.Windows.Forms.Label lblLogInPage;
        private System.Windows.Forms.LinkLabel lnkLogInBack;
    }
}