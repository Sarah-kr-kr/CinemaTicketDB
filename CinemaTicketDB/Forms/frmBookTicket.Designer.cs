namespace CinemaTicketDB
{
    partial class frmBookTicket
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBookTicket));
            this.grpShowtime = new System.Windows.Forms.GroupBox();
            this.lblDateTime = new System.Windows.Forms.Label();
            this.lblHallName = new System.Windows.Forms.Label();
            this.lblMovieTitle = new System.Windows.Forms.Label();
            this.grpSeats = new System.Windows.Forms.GroupBox();
            this.btnD4 = new System.Windows.Forms.Button();
            this.btnD3 = new System.Windows.Forms.Button();
            this.btnD2 = new System.Windows.Forms.Button();
            this.btnD1 = new System.Windows.Forms.Button();
            this.btnC4 = new System.Windows.Forms.Button();
            this.btnC3 = new System.Windows.Forms.Button();
            this.btnC2 = new System.Windows.Forms.Button();
            this.btnC1 = new System.Windows.Forms.Button();
            this.btnB4 = new System.Windows.Forms.Button();
            this.btnB3 = new System.Windows.Forms.Button();
            this.btnB2 = new System.Windows.Forms.Button();
            this.btnB1 = new System.Windows.Forms.Button();
            this.btnA4 = new System.Windows.Forms.Button();
            this.btnA3 = new System.Windows.Forms.Button();
            this.btnA2 = new System.Windows.Forms.Button();
            this.btnA1 = new System.Windows.Forms.Button();
            this.lblSelectedseat = new System.Windows.Forms.Label();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.btnHome = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.grpShowtime.SuspendLayout();
            this.grpSeats.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // grpShowtime
            // 
            this.grpShowtime.Controls.Add(this.lblDateTime);
            this.grpShowtime.Controls.Add(this.lblHallName);
            this.grpShowtime.Controls.Add(this.lblMovieTitle);
            this.grpShowtime.Font = new System.Drawing.Font("MV Boli", 15.75F, System.Drawing.FontStyle.Bold);
            this.grpShowtime.Location = new System.Drawing.Point(52, 70);
            this.grpShowtime.Name = "grpShowtime";
            this.grpShowtime.Size = new System.Drawing.Size(382, 159);
            this.grpShowtime.TabIndex = 0;
            this.grpShowtime.TabStop = false;
            this.grpShowtime.Text = "Showtime Info :";
            // 
            // lblDateTime
            // 
            this.lblDateTime.BackColor = System.Drawing.SystemColors.Window;
            this.lblDateTime.Font = new System.Drawing.Font("MV Boli", 12F);
            this.lblDateTime.Location = new System.Drawing.Point(21, 110);
            this.lblDateTime.Name = "lblDateTime";
            this.lblDateTime.Size = new System.Drawing.Size(332, 22);
            this.lblDateTime.TabIndex = 4;
            this.lblDateTime.Text = "Show Date/Time :";
            this.lblDateTime.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblHallName
            // 
            this.lblHallName.BackColor = System.Drawing.SystemColors.Window;
            this.lblHallName.Font = new System.Drawing.Font("MV Boli", 12F);
            this.lblHallName.Location = new System.Drawing.Point(21, 74);
            this.lblHallName.Name = "lblHallName";
            this.lblHallName.Size = new System.Drawing.Size(332, 22);
            this.lblHallName.TabIndex = 3;
            this.lblHallName.Text = "Hall Name :";
            this.lblHallName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblMovieTitle
            // 
            this.lblMovieTitle.BackColor = System.Drawing.SystemColors.Window;
            this.lblMovieTitle.Font = new System.Drawing.Font("MV Boli", 12F);
            this.lblMovieTitle.Location = new System.Drawing.Point(21, 37);
            this.lblMovieTitle.Name = "lblMovieTitle";
            this.lblMovieTitle.Size = new System.Drawing.Size(332, 22);
            this.lblMovieTitle.TabIndex = 2;
            this.lblMovieTitle.Text = "Movie Title :";
            this.lblMovieTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // grpSeats
            // 
            this.grpSeats.Controls.Add(this.btnD4);
            this.grpSeats.Controls.Add(this.btnD3);
            this.grpSeats.Controls.Add(this.btnD2);
            this.grpSeats.Controls.Add(this.btnD1);
            this.grpSeats.Controls.Add(this.btnC4);
            this.grpSeats.Controls.Add(this.btnC3);
            this.grpSeats.Controls.Add(this.btnC2);
            this.grpSeats.Controls.Add(this.btnC1);
            this.grpSeats.Controls.Add(this.btnB4);
            this.grpSeats.Controls.Add(this.btnB3);
            this.grpSeats.Controls.Add(this.btnB2);
            this.grpSeats.Controls.Add(this.btnB1);
            this.grpSeats.Controls.Add(this.btnA4);
            this.grpSeats.Controls.Add(this.btnA3);
            this.grpSeats.Controls.Add(this.btnA2);
            this.grpSeats.Controls.Add(this.btnA1);
            this.grpSeats.Font = new System.Drawing.Font("MV Boli", 15.75F, System.Drawing.FontStyle.Bold);
            this.grpSeats.Location = new System.Drawing.Point(472, 92);
            this.grpSeats.Name = "grpSeats";
            this.grpSeats.Size = new System.Drawing.Size(295, 271);
            this.grpSeats.TabIndex = 11;
            this.grpSeats.TabStop = false;
            this.grpSeats.Text = "Hall\'s Seats :";
            // 
            // btnD4
            // 
            this.btnD4.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnD4.Location = new System.Drawing.Point(218, 209);
            this.btnD4.Name = "btnD4";
            this.btnD4.Size = new System.Drawing.Size(50, 41);
            this.btnD4.TabIndex = 15;
            this.btnD4.Text = "D-4";
            this.btnD4.UseVisualStyleBackColor = true;
            // 
            // btnD3
            // 
            this.btnD3.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnD3.Location = new System.Drawing.Point(153, 209);
            this.btnD3.Name = "btnD3";
            this.btnD3.Size = new System.Drawing.Size(50, 41);
            this.btnD3.TabIndex = 14;
            this.btnD3.Text = "D-3";
            this.btnD3.UseVisualStyleBackColor = true;
            // 
            // btnD2
            // 
            this.btnD2.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnD2.Location = new System.Drawing.Point(85, 209);
            this.btnD2.Name = "btnD2";
            this.btnD2.Size = new System.Drawing.Size(50, 41);
            this.btnD2.TabIndex = 13;
            this.btnD2.Text = "D-2";
            this.btnD2.UseVisualStyleBackColor = true;
            // 
            // btnD1
            // 
            this.btnD1.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnD1.Location = new System.Drawing.Point(20, 209);
            this.btnD1.Name = "btnD1";
            this.btnD1.Size = new System.Drawing.Size(50, 41);
            this.btnD1.TabIndex = 12;
            this.btnD1.Text = "D-1";
            this.btnD1.UseVisualStyleBackColor = true;
            // 
            // btnC4
            // 
            this.btnC4.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnC4.Location = new System.Drawing.Point(218, 153);
            this.btnC4.Name = "btnC4";
            this.btnC4.Size = new System.Drawing.Size(50, 41);
            this.btnC4.TabIndex = 11;
            this.btnC4.Text = "C-4";
            this.btnC4.UseVisualStyleBackColor = true;
            // 
            // btnC3
            // 
            this.btnC3.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnC3.Location = new System.Drawing.Point(153, 153);
            this.btnC3.Name = "btnC3";
            this.btnC3.Size = new System.Drawing.Size(50, 41);
            this.btnC3.TabIndex = 10;
            this.btnC3.Text = "C-3";
            this.btnC3.UseVisualStyleBackColor = true;
            // 
            // btnC2
            // 
            this.btnC2.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnC2.Location = new System.Drawing.Point(85, 153);
            this.btnC2.Name = "btnC2";
            this.btnC2.Size = new System.Drawing.Size(50, 41);
            this.btnC2.TabIndex = 9;
            this.btnC2.Text = "C-2";
            this.btnC2.UseVisualStyleBackColor = true;
            // 
            // btnC1
            // 
            this.btnC1.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnC1.Location = new System.Drawing.Point(20, 153);
            this.btnC1.Name = "btnC1";
            this.btnC1.Size = new System.Drawing.Size(50, 41);
            this.btnC1.TabIndex = 8;
            this.btnC1.Text = "C-1";
            this.btnC1.UseVisualStyleBackColor = true;
            // 
            // btnB4
            // 
            this.btnB4.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnB4.Location = new System.Drawing.Point(218, 96);
            this.btnB4.Name = "btnB4";
            this.btnB4.Size = new System.Drawing.Size(50, 41);
            this.btnB4.TabIndex = 7;
            this.btnB4.Text = "B-4";
            this.btnB4.UseVisualStyleBackColor = true;
            // 
            // btnB3
            // 
            this.btnB3.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnB3.Location = new System.Drawing.Point(153, 96);
            this.btnB3.Name = "btnB3";
            this.btnB3.Size = new System.Drawing.Size(50, 41);
            this.btnB3.TabIndex = 6;
            this.btnB3.Text = "B-3";
            this.btnB3.UseVisualStyleBackColor = true;
            // 
            // btnB2
            // 
            this.btnB2.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnB2.Location = new System.Drawing.Point(85, 96);
            this.btnB2.Name = "btnB2";
            this.btnB2.Size = new System.Drawing.Size(50, 41);
            this.btnB2.TabIndex = 5;
            this.btnB2.Text = "B-2";
            this.btnB2.UseVisualStyleBackColor = true;
            // 
            // btnB1
            // 
            this.btnB1.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnB1.Location = new System.Drawing.Point(20, 96);
            this.btnB1.Name = "btnB1";
            this.btnB1.Size = new System.Drawing.Size(50, 41);
            this.btnB1.TabIndex = 4;
            this.btnB1.Text = "B-1";
            this.btnB1.UseVisualStyleBackColor = true;
            // 
            // btnA4
            // 
            this.btnA4.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnA4.Location = new System.Drawing.Point(218, 40);
            this.btnA4.Name = "btnA4";
            this.btnA4.Size = new System.Drawing.Size(50, 41);
            this.btnA4.TabIndex = 3;
            this.btnA4.Text = "A-4";
            this.btnA4.UseVisualStyleBackColor = true;
            // 
            // btnA3
            // 
            this.btnA3.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnA3.Location = new System.Drawing.Point(153, 40);
            this.btnA3.Name = "btnA3";
            this.btnA3.Size = new System.Drawing.Size(50, 41);
            this.btnA3.TabIndex = 2;
            this.btnA3.Text = "A-3";
            this.btnA3.UseVisualStyleBackColor = true;
            // 
            // btnA2
            // 
            this.btnA2.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnA2.Location = new System.Drawing.Point(85, 40);
            this.btnA2.Name = "btnA2";
            this.btnA2.Size = new System.Drawing.Size(50, 41);
            this.btnA2.TabIndex = 1;
            this.btnA2.Text = "A-2";
            this.btnA2.UseVisualStyleBackColor = true;
            // 
            // btnA1
            // 
            this.btnA1.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnA1.Location = new System.Drawing.Point(20, 40);
            this.btnA1.Name = "btnA1";
            this.btnA1.Size = new System.Drawing.Size(50, 41);
            this.btnA1.TabIndex = 0;
            this.btnA1.Text = "A-1";
            this.btnA1.UseVisualStyleBackColor = true;
            // 
            // lblSelectedseat
            // 
            this.lblSelectedseat.BackColor = System.Drawing.SystemColors.Window;
            this.lblSelectedseat.Font = new System.Drawing.Font("MV Boli", 12F);
            this.lblSelectedseat.Location = new System.Drawing.Point(114, 289);
            this.lblSelectedseat.Name = "lblSelectedseat";
            this.lblSelectedseat.Size = new System.Drawing.Size(256, 22);
            this.lblSelectedseat.TabIndex = 5;
            this.lblSelectedseat.Text = "Selected Seat :";
            this.lblSelectedseat.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblSelectedseat.UseCompatibleTextRendering = true;
            // 
            // btnConfirm
            // 
            this.btnConfirm.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnConfirm.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnConfirm.Font = new System.Drawing.Font("MV Boli", 12F);
            this.btnConfirm.Location = new System.Drawing.Point(179, 328);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(129, 37);
            this.btnConfirm.TabIndex = 12;
            this.btnConfirm.Text = "Confirm";
            this.btnConfirm.UseVisualStyleBackColor = false;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
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
            this.btnHome.TabIndex = 13;
            this.btnHome.UseVisualStyleBackColor = false;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::CinemaTicketDB.Properties.Resources.cinema_bg;
            this.pictureBox1.Location = new System.Drawing.Point(0, -2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(801, 479);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // frmBookTicket
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 474);
            this.Controls.Add(this.btnHome);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.lblSelectedseat);
            this.Controls.Add(this.grpSeats);
            this.Controls.Add(this.grpShowtime);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmBookTicket";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BookingTicket";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmBookTicket_FormClosing);
            this.Load += new System.EventHandler(this.frmBookTicket_Load);
            this.grpShowtime.ResumeLayout(false);
            this.grpSeats.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpShowtime;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblMovieTitle;
        private System.Windows.Forms.Label lblDateTime;
        private System.Windows.Forms.Label lblHallName;
        private System.Windows.Forms.GroupBox grpSeats;
        private System.Windows.Forms.Button btnD4;
        private System.Windows.Forms.Button btnD3;
        private System.Windows.Forms.Button btnD2;
        private System.Windows.Forms.Button btnD1;
        private System.Windows.Forms.Button btnC4;
        private System.Windows.Forms.Button btnC3;
        private System.Windows.Forms.Button btnC2;
        private System.Windows.Forms.Button btnC1;
        private System.Windows.Forms.Button btnB4;
        private System.Windows.Forms.Button btnB3;
        private System.Windows.Forms.Button btnB2;
        private System.Windows.Forms.Button btnB1;
        private System.Windows.Forms.Button btnA4;
        private System.Windows.Forms.Button btnA3;
        private System.Windows.Forms.Button btnA2;
        private System.Windows.Forms.Button btnA1;
        private System.Windows.Forms.Label lblSelectedseat;
        private System.Windows.Forms.Button btnConfirm;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button btnHome;
    }
}