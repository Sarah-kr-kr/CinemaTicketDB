namespace CinemaTicketDB
{
    partial class frmCustomerHome
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCustomerHome));
            this.lblWelcome = new System.Windows.Forms.Label();
            this.dgvShowtime = new System.Windows.Forms.DataGridView();
            this.btnMyticket = new System.Windows.Forms.Button();
            this.btnTicket = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnLogout = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvShowtime)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblWelcome
            // 
            this.lblWelcome.BackColor = System.Drawing.SystemColors.Window;
            this.lblWelcome.Font = new System.Drawing.Font("MV Boli", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcome.Location = new System.Drawing.Point(324, 29);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(152, 34);
            this.lblWelcome.TabIndex = 1;
            this.lblWelcome.Text = "Welcome!...";
            this.lblWelcome.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dgvShowtime
            // 
            this.dgvShowtime.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvShowtime.Location = new System.Drawing.Point(71, 79);
            this.dgvShowtime.Name = "dgvShowtime";
            this.dgvShowtime.Size = new System.Drawing.Size(661, 303);
            this.dgvShowtime.TabIndex = 2;
            // 
            // btnMyticket
            // 
            this.btnMyticket.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnMyticket.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnMyticket.Font = new System.Drawing.Font("MV Boli", 12F);
            this.btnMyticket.Location = new System.Drawing.Point(476, 401);
            this.btnMyticket.Name = "btnMyticket";
            this.btnMyticket.Size = new System.Drawing.Size(129, 37);
            this.btnMyticket.TabIndex = 7;
            this.btnMyticket.Text = "My Ticket";
            this.btnMyticket.UseVisualStyleBackColor = false;
            // 
            // btnTicket
            // 
            this.btnTicket.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnTicket.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnTicket.Font = new System.Drawing.Font("MV Boli", 12F);
            this.btnTicket.Location = new System.Drawing.Point(184, 401);
            this.btnTicket.Name = "btnTicket";
            this.btnTicket.Size = new System.Drawing.Size(129, 37);
            this.btnTicket.TabIndex = 8;
            this.btnTicket.Text = "Book a Ticket";
            this.btnTicket.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::CinemaTicketDB.Properties.Resources.cinema_bg;
            this.pictureBox1.Location = new System.Drawing.Point(0, -1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(801, 479);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.Firebrick;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLogout.Font = new System.Drawing.Font("MV Boli", 12F);
            this.btnLogout.Location = new System.Drawing.Point(703, 432);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(85, 30);
            this.btnLogout.TabIndex = 10;
            this.btnLogout.Text = "Log Out";
            this.btnLogout.UseVisualStyleBackColor = false;
            // 
            // frmCustomerHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 474);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.btnTicket);
            this.Controls.Add(this.btnMyticket);
            this.Controls.Add(this.dgvShowtime);
            this.Controls.Add(this.lblWelcome);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmCustomerHome";
            this.Text = "Home";
            ((System.ComponentModel.ISupportInitialize)(this.dgvShowtime)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.DataGridView dgvShowtime;
        private System.Windows.Forms.Button btnMyticket;
        private System.Windows.Forms.Button btnTicket;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnLogout;
    }
}