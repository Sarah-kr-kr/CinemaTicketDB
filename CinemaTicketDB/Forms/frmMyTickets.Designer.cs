namespace CinemaTicketDB
{
    partial class frmMyTickets
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMyTickets));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblMytickets = new System.Windows.Forms.Label();
            this.lblMybooketticket = new System.Windows.Forms.Label();
            this.dgvMyBookedTicket = new System.Windows.Forms.DataGridView();
            this.btnPrintticket = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnCancelticket = new System.Windows.Forms.Button();
            this.btnHome = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMyBookedTicket)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::CinemaTicketDB.Properties.Resources.cinema_bg;
            this.pictureBox1.Location = new System.Drawing.Point(0, -2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(801, 479);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // lblMytickets
            // 
            this.lblMytickets.BackColor = System.Drawing.SystemColors.Window;
            this.lblMytickets.Font = new System.Drawing.Font("MV Boli", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMytickets.Location = new System.Drawing.Point(273, 36);
            this.lblMytickets.Name = "lblMytickets";
            this.lblMytickets.Size = new System.Drawing.Size(270, 34);
            this.lblMytickets.TabIndex = 12;
            this.lblMytickets.Text = "My Tickets !";
            this.lblMytickets.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblMybooketticket
            // 
            this.lblMybooketticket.BackColor = System.Drawing.SystemColors.Window;
            this.lblMybooketticket.Font = new System.Drawing.Font("MV Boli", 12F);
            this.lblMybooketticket.Location = new System.Drawing.Point(21, 104);
            this.lblMybooketticket.Name = "lblMybooketticket";
            this.lblMybooketticket.Size = new System.Drawing.Size(196, 22);
            this.lblMybooketticket.TabIndex = 13;
            this.lblMybooketticket.Text = "My Booked Ticket :-";
            this.lblMybooketticket.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dgvMyBookedTicket
            // 
            this.dgvMyBookedTicket.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMyBookedTicket.Location = new System.Drawing.Point(25, 143);
            this.dgvMyBookedTicket.Name = "dgvMyBookedTicket";
            this.dgvMyBookedTicket.Size = new System.Drawing.Size(527, 245);
            this.dgvMyBookedTicket.TabIndex = 14;
            // 
            // btnPrintticket
            // 
            this.btnPrintticket.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnPrintticket.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPrintticket.Font = new System.Drawing.Font("MV Boli", 12F);
            this.btnPrintticket.Location = new System.Drawing.Point(626, 192);
            this.btnPrintticket.Name = "btnPrintticket";
            this.btnPrintticket.Size = new System.Drawing.Size(129, 37);
            this.btnPrintticket.TabIndex = 16;
            this.btnPrintticket.Text = "Print Ticket";
            this.btnPrintticket.UseVisualStyleBackColor = false;
            this.btnPrintticket.Click += new System.EventHandler(this.btnPrintticket_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRefresh.Font = new System.Drawing.Font("MV Boli", 12F);
            this.btnRefresh.Location = new System.Drawing.Point(626, 97);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(129, 37);
            this.btnRefresh.TabIndex = 17;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnCancelticket
            // 
            this.btnCancelticket.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnCancelticket.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCancelticket.Font = new System.Drawing.Font("MV Boli", 12F);
            this.btnCancelticket.Location = new System.Drawing.Point(626, 289);
            this.btnCancelticket.Name = "btnCancelticket";
            this.btnCancelticket.Size = new System.Drawing.Size(129, 37);
            this.btnCancelticket.TabIndex = 18;
            this.btnCancelticket.Text = "Cancel Ticket";
            this.btnCancelticket.UseVisualStyleBackColor = false;
            this.btnCancelticket.Click += new System.EventHandler(this.btnCancelticket_Click);
            // 
            // btnHome
            // 
            this.btnHome.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnHome.BackgroundImage = global::CinemaTicketDB.Properties.Resources.download__5_;
            this.btnHome.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnHome.Font = new System.Drawing.Font("MV Boli", 12F);
            this.btnHome.Location = new System.Drawing.Point(707, 401);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(60, 50);
            this.btnHome.TabIndex = 19;
            this.btnHome.UseVisualStyleBackColor = false;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // frmMyTickets
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 474);
            this.Controls.Add(this.btnHome);
            this.Controls.Add(this.btnCancelticket);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnPrintticket);
            this.Controls.Add(this.dgvMyBookedTicket);
            this.Controls.Add(this.lblMybooketticket);
            this.Controls.Add(this.lblMytickets);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmMyTickets";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MyTickets";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMyTickets_FormClosing);
            this.Load += new System.EventHandler(this.frmMyTickets_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMyBookedTicket)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblMytickets;
        private System.Windows.Forms.Label lblMybooketticket;
        private System.Windows.Forms.DataGridView dgvMyBookedTicket;
        private System.Windows.Forms.Button btnPrintticket;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnCancelticket;
        private System.Windows.Forms.Button btnHome;
    }
}