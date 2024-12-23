namespace registration_logic
{
    partial class Admin
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
            this.dgvAdmin = new System.Windows.Forms.DataGridView();
            this.lnkAdminBack = new System.Windows.Forms.LinkLabel();
            this.pnlAdmin = new System.Windows.Forms.Panel();
            this.lblAdminUserName = new System.Windows.Forms.Label();
            this.txtAdminUserName = new System.Windows.Forms.TextBox();
            this.btnAdminUpdate = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAdmin)).BeginInit();
            this.pnlAdmin.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvAdmin
            // 
            this.dgvAdmin.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAdmin.Location = new System.Drawing.Point(313, 46);
            this.dgvAdmin.Name = "dgvAdmin";
            this.dgvAdmin.Size = new System.Drawing.Size(536, 299);
            this.dgvAdmin.TabIndex = 0;
            // 
            // lnkAdminBack
            // 
            this.lnkAdminBack.AutoSize = true;
            this.lnkAdminBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnkAdminBack.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lnkAdminBack.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.lnkAdminBack.Location = new System.Drawing.Point(711, 9);
            this.lnkAdminBack.Name = "lnkAdminBack";
            this.lnkAdminBack.Size = new System.Drawing.Size(60, 24);
            this.lnkAdminBack.TabIndex = 1;
            this.lnkAdminBack.TabStop = true;
            this.lnkAdminBack.Text = "BACK";
            this.lnkAdminBack.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkAdminBack_LinkClicked);
            // 
            // pnlAdmin
            // 
            this.pnlAdmin.Controls.Add(this.btnAdminUpdate);
            this.pnlAdmin.Controls.Add(this.txtAdminUserName);
            this.pnlAdmin.Controls.Add(this.lblAdminUserName);
            this.pnlAdmin.Location = new System.Drawing.Point(12, 12);
            this.pnlAdmin.Name = "pnlAdmin";
            this.pnlAdmin.Size = new System.Drawing.Size(252, 114);
            this.pnlAdmin.TabIndex = 2;
            // 
            // lblAdminUserName
            // 
            this.lblAdminUserName.Location = new System.Drawing.Point(17, 33);
            this.lblAdminUserName.Name = "lblAdminUserName";
            this.lblAdminUserName.Size = new System.Drawing.Size(77, 13);
            this.lblAdminUserName.TabIndex = 0;
            this.lblAdminUserName.Text = "USERNAME";
            // 
            // txtAdminUserName
            // 
            this.txtAdminUserName.Location = new System.Drawing.Point(112, 26);
            this.txtAdminUserName.Name = "txtAdminUserName";
            this.txtAdminUserName.Size = new System.Drawing.Size(125, 20);
            this.txtAdminUserName.TabIndex = 1;
            // 
            // btnAdminUpdate
            // 
            this.btnAdminUpdate.Location = new System.Drawing.Point(82, 74);
            this.btnAdminUpdate.Name = "btnAdminUpdate";
            this.btnAdminUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnAdminUpdate.TabIndex = 2;
            this.btnAdminUpdate.Text = "UPDATE";
            this.btnAdminUpdate.UseVisualStyleBackColor = true;
            this.btnAdminUpdate.Click += new System.EventHandler(this.button1_Click);
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(881, 357);
            this.Controls.Add(this.pnlAdmin);
            this.Controls.Add(this.lnkAdminBack);
            this.Controls.Add(this.dgvAdmin);
            this.Name = "Admin";
            this.Text = "Admin";
            this.Load += new System.EventHandler(this.Admin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAdmin)).EndInit();
            this.pnlAdmin.ResumeLayout(false);
            this.pnlAdmin.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvAdmin;
        private System.Windows.Forms.LinkLabel lnkAdminBack;
        private System.Windows.Forms.Panel pnlAdmin;
        private System.Windows.Forms.Button btnAdminUpdate;
        private System.Windows.Forms.TextBox txtAdminUserName;
        private System.Windows.Forms.Label lblAdminUserName;
    }
}