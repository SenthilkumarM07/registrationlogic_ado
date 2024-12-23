namespace registration_logic
{
    partial class Register
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
            this.pnlRegister = new System.Windows.Forms.Panel();
            this.btnRegister = new System.Windows.Forms.Button();
            this.txtRegPassword = new System.Windows.Forms.TextBox();
            this.txtRegMailId = new System.Windows.Forms.TextBox();
            this.txtRegUserName = new System.Windows.Forms.TextBox();
            this.lblRegPassword = new System.Windows.Forms.Label();
            this.lblRegMailId = new System.Windows.Forms.Label();
            this.lblRegUserName = new System.Windows.Forms.Label();
            this.btnRegNext = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlRegister.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlRegister
            // 
            this.pnlRegister.Controls.Add(this.btnRegister);
            this.pnlRegister.Controls.Add(this.txtRegPassword);
            this.pnlRegister.Controls.Add(this.txtRegMailId);
            this.pnlRegister.Controls.Add(this.txtRegUserName);
            this.pnlRegister.Controls.Add(this.lblRegPassword);
            this.pnlRegister.Controls.Add(this.lblRegMailId);
            this.pnlRegister.Controls.Add(this.lblRegUserName);
            this.pnlRegister.Location = new System.Drawing.Point(235, 57);
            this.pnlRegister.Name = "pnlRegister";
            this.pnlRegister.Size = new System.Drawing.Size(267, 263);
            this.pnlRegister.TabIndex = 0;
            // 
            // btnRegister
            // 
            this.btnRegister.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnRegister.Location = new System.Drawing.Point(96, 227);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(75, 23);
            this.btnRegister.TabIndex = 8;
            this.btnRegister.Text = "REGISTER";
            this.btnRegister.UseVisualStyleBackColor = false;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // txtRegPassword
            // 
            this.txtRegPassword.Location = new System.Drawing.Point(130, 159);
            this.txtRegPassword.Name = "txtRegPassword";
            this.txtRegPassword.Size = new System.Drawing.Size(100, 20);
            this.txtRegPassword.TabIndex = 6;
            // 
            // txtRegMailId
            // 
            this.txtRegMailId.Location = new System.Drawing.Point(130, 104);
            this.txtRegMailId.Name = "txtRegMailId";
            this.txtRegMailId.Size = new System.Drawing.Size(100, 20);
            this.txtRegMailId.TabIndex = 5;
            // 
            // txtRegUserName
            // 
            this.txtRegUserName.Location = new System.Drawing.Point(130, 47);
            this.txtRegUserName.Name = "txtRegUserName";
            this.txtRegUserName.Size = new System.Drawing.Size(100, 20);
            this.txtRegUserName.TabIndex = 4;
            // 
            // lblRegPassword
            // 
            this.lblRegPassword.AutoSize = true;
            this.lblRegPassword.Location = new System.Drawing.Point(36, 166);
            this.lblRegPassword.Name = "lblRegPassword";
            this.lblRegPassword.Size = new System.Drawing.Size(70, 13);
            this.lblRegPassword.TabIndex = 3;
            this.lblRegPassword.Text = "PASSWORD";
            // 
            // lblRegMailId
            // 
            this.lblRegMailId.AutoSize = true;
            this.lblRegMailId.Location = new System.Drawing.Point(36, 111);
            this.lblRegMailId.Name = "lblRegMailId";
            this.lblRegMailId.Size = new System.Drawing.Size(43, 13);
            this.lblRegMailId.TabIndex = 2;
            this.lblRegMailId.Text = "MAILID";
            // 
            // lblRegUserName
            // 
            this.lblRegUserName.AutoSize = true;
            this.lblRegUserName.Location = new System.Drawing.Point(36, 47);
            this.lblRegUserName.Name = "lblRegUserName";
            this.lblRegUserName.Size = new System.Drawing.Size(68, 13);
            this.lblRegUserName.TabIndex = 1;
            this.lblRegUserName.Text = "USERNAME";
            // 
            // btnRegNext
            // 
            this.btnRegNext.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnRegNext.Location = new System.Drawing.Point(331, 326);
            this.btnRegNext.Name = "btnRegNext";
            this.btnRegNext.Size = new System.Drawing.Size(75, 23);
            this.btnRegNext.TabIndex = 2;
            this.btnRegNext.Text = "NEXT";
            this.btnRegNext.UseVisualStyleBackColor = false;
            this.btnRegNext.Click += new System.EventHandler(this.btnRegNext_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(331, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "REGISTER";
            // 
            // Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(901, 379);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnRegNext);
            this.Controls.Add(this.pnlRegister);
            this.Name = "Register";
            this.Text = "register";
            this.pnlRegister.ResumeLayout(false);
            this.pnlRegister.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlRegister;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.TextBox txtRegPassword;
        private System.Windows.Forms.TextBox txtRegMailId;
        private System.Windows.Forms.TextBox txtRegUserName;
        private System.Windows.Forms.Label lblRegPassword;
        private System.Windows.Forms.Label lblRegMailId;
        private System.Windows.Forms.Label lblRegUserName;
        private System.Windows.Forms.Button btnRegNext;
        private System.Windows.Forms.Label label1;
    }
}

