namespace CinemaTicketDB
{
    partial class frmAddAdmin
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblAddAdmin = new System.Windows.Forms.Label();
            this.txtPhonenumber = new System.Windows.Forms.TextBox();
            this.lblPhonenumber = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtFullname = new System.Windows.Forms.TextBox();
            this.lblFullname = new System.Windows.Forms.Label();
            this.btnCreatadmin = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.txtConfirmpassword = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::CinemaTicketDB.Properties.Resources.Descargar_fondo_abstracto_moderno_gratis;
            this.pictureBox1.Location = new System.Drawing.Point(0, -2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(801, 479);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // lblAddAdmin
            // 
            this.lblAddAdmin.BackColor = System.Drawing.SystemColors.Window;
            this.lblAddAdmin.Font = new System.Drawing.Font("MV Boli", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddAdmin.Location = new System.Drawing.Point(283, 38);
            this.lblAddAdmin.Name = "lblAddAdmin";
            this.lblAddAdmin.Size = new System.Drawing.Size(223, 34);
            this.lblAddAdmin.TabIndex = 30;
            this.lblAddAdmin.Text = "Add New Admin";
            this.lblAddAdmin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtPhonenumber
            // 
            this.txtPhonenumber.Font = new System.Drawing.Font("MV Boli", 12F);
            this.txtPhonenumber.Location = new System.Drawing.Point(344, 299);
            this.txtPhonenumber.Multiline = true;
            this.txtPhonenumber.Name = "txtPhonenumber";
            this.txtPhonenumber.Size = new System.Drawing.Size(253, 37);
            this.txtPhonenumber.TabIndex = 5;
            this.txtPhonenumber.Enter += new System.EventHandler(this.txtPhoneNumber_Enter);
            this.txtPhonenumber.Leave += new System.EventHandler(this.txtPhoneNumber_Leave);
            // 
            // lblPhonenumber
            // 
            this.lblPhonenumber.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblPhonenumber.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhonenumber.Location = new System.Drawing.Point(187, 301);
            this.lblPhonenumber.Name = "lblPhonenumber";
            this.lblPhonenumber.Size = new System.Drawing.Size(141, 35);
            this.lblPhonenumber.TabIndex = 41;
            this.lblPhonenumber.Text = "Phone Number :";
            this.lblPhonenumber.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtPassword
            // 
            this.txtPassword.Font = new System.Drawing.Font("MV Boli", 12F);
            this.txtPassword.Location = new System.Drawing.Point(344, 205);
            this.txtPassword.Multiline = true;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(253, 37);
            this.txtPassword.TabIndex = 3;
            // 
            // lblPassword
            // 
            this.lblPassword.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblPassword.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword.Location = new System.Drawing.Point(228, 207);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(100, 35);
            this.lblPassword.TabIndex = 39;
            this.lblPassword.Text = "Password :";
            this.lblPassword.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("MV Boli", 12F);
            this.txtEmail.Location = new System.Drawing.Point(344, 158);
            this.txtEmail.Multiline = true;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(253, 37);
            this.txtEmail.TabIndex = 2;
            // 
            // lblEmail
            // 
            this.lblEmail.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblEmail.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(228, 164);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(100, 31);
            this.lblEmail.TabIndex = 37;
            this.lblEmail.Text = "Email :";
            this.lblEmail.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtFullname
            // 
            this.txtFullname.Font = new System.Drawing.Font("MV Boli", 12F);
            this.txtFullname.Location = new System.Drawing.Point(344, 115);
            this.txtFullname.Multiline = true;
            this.txtFullname.Name = "txtFullname";
            this.txtFullname.Size = new System.Drawing.Size(253, 37);
            this.txtFullname.TabIndex = 1;
            // 
            // lblFullname
            // 
            this.lblFullname.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblFullname.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFullname.Location = new System.Drawing.Point(222, 117);
            this.lblFullname.Name = "lblFullname";
            this.lblFullname.Size = new System.Drawing.Size(106, 35);
            this.lblFullname.TabIndex = 35;
            this.lblFullname.Text = "Full Name :";
            this.lblFullname.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnCreatadmin
            // 
            this.btnCreatadmin.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnCreatadmin.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCreatadmin.Font = new System.Drawing.Font("MV Boli", 12F);
            this.btnCreatadmin.Location = new System.Drawing.Point(325, 375);
            this.btnCreatadmin.Name = "btnCreatadmin";
            this.btnCreatadmin.Size = new System.Drawing.Size(139, 37);
            this.btnCreatadmin.TabIndex = 6;
            this.btnCreatadmin.Text = "Creat Admin";
            this.btnCreatadmin.UseVisualStyleBackColor = false;
            this.btnCreatadmin.Click += new System.EventHandler(this.btnAddAdmin_Click);
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.SteelBlue;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBack.Font = new System.Drawing.Font("MV Boli", 12F);
            this.btnBack.Location = new System.Drawing.Point(12, 12);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(85, 30);
            this.btnBack.TabIndex = 45;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // txtConfirmpassword
            // 
            this.txtConfirmpassword.Font = new System.Drawing.Font("MV Boli", 12F);
            this.txtConfirmpassword.Location = new System.Drawing.Point(344, 252);
            this.txtConfirmpassword.Multiline = true;
            this.txtConfirmpassword.Name = "txtConfirmpassword";
            this.txtConfirmpassword.Size = new System.Drawing.Size(253, 37);
            this.txtConfirmpassword.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label1.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(167, 252);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 35);
            this.label1.TabIndex = 46;
            this.label1.Text = "Confirm Password :";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmAddAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 474);
            this.Controls.Add(this.txtConfirmpassword);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnCreatadmin);
            this.Controls.Add(this.txtPhonenumber);
            this.Controls.Add(this.lblPhonenumber);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.txtFullname);
            this.Controls.Add(this.lblFullname);
            this.Controls.Add(this.lblAddAdmin);
            this.Controls.Add(this.pictureBox1);
            this.Name = "frmAddAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmAddAdmin";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmAddAdmin_FormClosing);
            this.Load += new System.EventHandler(this.frmAddAdmin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblAddAdmin;
        private System.Windows.Forms.TextBox txtPhonenumber;
        private System.Windows.Forms.Label lblPhonenumber;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtFullname;
        private System.Windows.Forms.Label lblFullname;
        private System.Windows.Forms.Button btnCreatadmin;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.TextBox txtConfirmpassword;
        private System.Windows.Forms.Label label1;
    }
}