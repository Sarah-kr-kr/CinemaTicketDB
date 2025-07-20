namespace CinemaTicketDB
{
    partial class frmAdminManager
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAdminManager));
            this.MainTabControl = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnRefreshMovies = new System.Windows.Forms.Button();
            this.txtRating = new System.Windows.Forms.TextBox();
            this.lblRating = new System.Windows.Forms.Label();
            this.txtDuration = new System.Windows.Forms.TextBox();
            this.lblDuration = new System.Windows.Forms.Label();
            this.txtGenre = new System.Windows.Forms.TextBox();
            this.lblGenre = new System.Windows.Forms.Label();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.dgvMovies = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.txtCapacity = new System.Windows.Forms.TextBox();
            this.lblCapacity = new System.Windows.Forms.Label();
            this.txtHallName = new System.Windows.Forms.TextBox();
            this.lblHallname = new System.Windows.Forms.Label();
            this.btnUpdateHall = new System.Windows.Forms.Button();
            this.btnClearHall = new System.Windows.Forms.Button();
            this.btnDeleteHall = new System.Windows.Forms.Button();
            this.btnAddHall = new System.Windows.Forms.Button();
            this.dgvHalls = new System.Windows.Forms.DataGridView();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.dtpTime = new System.Windows.Forms.DateTimePicker();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.cmbHall = new System.Windows.Forms.ComboBox();
            this.cmbMovie = new System.Windows.Forms.ComboBox();
            this.lblTime = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblHall = new System.Windows.Forms.Label();
            this.lblMovie = new System.Windows.Forms.Label();
            this.btnUpdateShowtime = new System.Windows.Forms.Button();
            this.btnClearShowtime = new System.Windows.Forms.Button();
            this.btnDeleteShowtime = new System.Windows.Forms.Button();
            this.btnAddShowtime = new System.Windows.Forms.Button();
            this.dgvShowtime = new System.Windows.Forms.DataGridView();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.btnDeleteticket = new System.Windows.Forms.Button();
            this.dgvTickets = new System.Windows.Forms.DataGridView();
            this.tabAuditTrail = new System.Windows.Forms.TabPage();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.dgvAuditTrail = new System.Windows.Forms.DataGridView();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.btnRefreshRecycle = new System.Windows.Forms.Button();
            this.btnRestore = new System.Windows.Forms.Button();
            this.dgvRecycleBin = new System.Windows.Forms.DataGridView();
            this.btnLogout = new System.Windows.Forms.Button();
            this.lblAdmincenter = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnCreateAdmin = new System.Windows.Forms.Button();
            this.tabPage6 = new System.Windows.Forms.TabPage();
            this.dgvMessages = new System.Windows.Forms.DataGridView();
            this.btnRefreshMessages = new System.Windows.Forms.Button();
            this.MainTabControl.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMovies)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHalls)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvShowtime)).BeginInit();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTickets)).BeginInit();
            this.tabAuditTrail.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAuditTrail)).BeginInit();
            this.tabPage5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRecycleBin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabPage6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMessages)).BeginInit();
            this.SuspendLayout();
            // 
            // MainTabControl
            // 
            this.MainTabControl.Controls.Add(this.tabPage1);
            this.MainTabControl.Controls.Add(this.tabPage2);
            this.MainTabControl.Controls.Add(this.tabPage3);
            this.MainTabControl.Controls.Add(this.tabPage4);
            this.MainTabControl.Controls.Add(this.tabAuditTrail);
            this.MainTabControl.Controls.Add(this.tabPage5);
            this.MainTabControl.Controls.Add(this.tabPage6);
            this.MainTabControl.Location = new System.Drawing.Point(79, 52);
            this.MainTabControl.Name = "MainTabControl";
            this.MainTabControl.SelectedIndex = 0;
            this.MainTabControl.Size = new System.Drawing.Size(640, 400);
            this.MainTabControl.TabIndex = 12;
            this.MainTabControl.Tag = "";
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnRefreshMovies);
            this.tabPage1.Controls.Add(this.txtRating);
            this.tabPage1.Controls.Add(this.lblRating);
            this.tabPage1.Controls.Add(this.txtDuration);
            this.tabPage1.Controls.Add(this.lblDuration);
            this.tabPage1.Controls.Add(this.txtGenre);
            this.tabPage1.Controls.Add(this.lblGenre);
            this.tabPage1.Controls.Add(this.txtTitle);
            this.tabPage1.Controls.Add(this.lblTitle);
            this.tabPage1.Controls.Add(this.btnUpdate);
            this.tabPage1.Controls.Add(this.btnClear);
            this.tabPage1.Controls.Add(this.btnDelete);
            this.tabPage1.Controls.Add(this.btnAdd);
            this.tabPage1.Controls.Add(this.dgvMovies);
            this.tabPage1.Font = new System.Drawing.Font("MV Boli", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(632, 374);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Movies";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnRefreshMovies
            // 
            this.btnRefreshMovies.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnRefreshMovies.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRefreshMovies.Font = new System.Drawing.Font("MV Boli", 12F);
            this.btnRefreshMovies.Location = new System.Drawing.Point(469, 289);
            this.btnRefreshMovies.Name = "btnRefreshMovies";
            this.btnRefreshMovies.Size = new System.Drawing.Size(101, 37);
            this.btnRefreshMovies.TabIndex = 31;
            this.btnRefreshMovies.Text = "Refresh";
            this.btnRefreshMovies.UseVisualStyleBackColor = false;
            this.btnRefreshMovies.Click += new System.EventHandler(this.btnRefreshMovies_Click);
            // 
            // txtRating
            // 
            this.txtRating.Font = new System.Drawing.Font("MV Boli", 12F);
            this.txtRating.Location = new System.Drawing.Point(196, 303);
            this.txtRating.Multiline = true;
            this.txtRating.Name = "txtRating";
            this.txtRating.Size = new System.Drawing.Size(193, 23);
            this.txtRating.TabIndex = 24;
            // 
            // lblRating
            // 
            this.lblRating.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblRating.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRating.Location = new System.Drawing.Point(76, 305);
            this.lblRating.Name = "lblRating";
            this.lblRating.Size = new System.Drawing.Size(104, 23);
            this.lblRating.TabIndex = 23;
            this.lblRating.Text = "Rating :";
            this.lblRating.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtDuration
            // 
            this.txtDuration.Font = new System.Drawing.Font("MV Boli", 12F);
            this.txtDuration.Location = new System.Drawing.Point(196, 267);
            this.txtDuration.Multiline = true;
            this.txtDuration.Name = "txtDuration";
            this.txtDuration.Size = new System.Drawing.Size(193, 23);
            this.txtDuration.TabIndex = 22;
            // 
            // lblDuration
            // 
            this.lblDuration.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblDuration.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDuration.Location = new System.Drawing.Point(76, 269);
            this.lblDuration.Name = "lblDuration";
            this.lblDuration.Size = new System.Drawing.Size(104, 23);
            this.lblDuration.TabIndex = 21;
            this.lblDuration.Text = "Duration :";
            this.lblDuration.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtGenre
            // 
            this.txtGenre.Font = new System.Drawing.Font("MV Boli", 12F);
            this.txtGenre.Location = new System.Drawing.Point(196, 228);
            this.txtGenre.Multiline = true;
            this.txtGenre.Name = "txtGenre";
            this.txtGenre.Size = new System.Drawing.Size(193, 23);
            this.txtGenre.TabIndex = 20;
            // 
            // lblGenre
            // 
            this.lblGenre.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblGenre.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGenre.Location = new System.Drawing.Point(76, 230);
            this.lblGenre.Name = "lblGenre";
            this.lblGenre.Size = new System.Drawing.Size(104, 23);
            this.lblGenre.TabIndex = 19;
            this.lblGenre.Text = "Genre :";
            this.lblGenre.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtTitle
            // 
            this.txtTitle.Font = new System.Drawing.Font("MV Boli", 12F);
            this.txtTitle.Location = new System.Drawing.Point(196, 190);
            this.txtTitle.Multiline = true;
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(193, 23);
            this.txtTitle.TabIndex = 18;
            // 
            // lblTitle
            // 
            this.lblTitle.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblTitle.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(76, 192);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(104, 23);
            this.lblTitle.TabIndex = 17;
            this.lblTitle.Text = "Title :";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnUpdate.Font = new System.Drawing.Font("MV Boli", 12F);
            this.btnUpdate.Location = new System.Drawing.Point(521, 180);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(101, 37);
            this.btnUpdate.TabIndex = 16;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnClear.Font = new System.Drawing.Font("MV Boli", 12F);
            this.btnClear.Location = new System.Drawing.Point(521, 230);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(101, 37);
            this.btnClear.TabIndex = 15;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDelete.Font = new System.Drawing.Font("MV Boli", 12F);
            this.btnDelete.Location = new System.Drawing.Point(414, 230);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(101, 37);
            this.btnDelete.TabIndex = 14;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAdd.Font = new System.Drawing.Font("MV Boli", 12F);
            this.btnAdd.Location = new System.Drawing.Point(414, 180);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(101, 37);
            this.btnAdd.TabIndex = 13;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // dgvMovies
            // 
            this.dgvMovies.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMovies.Location = new System.Drawing.Point(6, 7);
            this.dgvMovies.Name = "dgvMovies";
            this.dgvMovies.Size = new System.Drawing.Size(620, 159);
            this.dgvMovies.TabIndex = 0;
            this.dgvMovies.SelectionChanged += new System.EventHandler(this.dgvMovies_SelectionChanged);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.txtCapacity);
            this.tabPage2.Controls.Add(this.lblCapacity);
            this.tabPage2.Controls.Add(this.txtHallName);
            this.tabPage2.Controls.Add(this.lblHallname);
            this.tabPage2.Controls.Add(this.btnUpdateHall);
            this.tabPage2.Controls.Add(this.btnClearHall);
            this.tabPage2.Controls.Add(this.btnDeleteHall);
            this.tabPage2.Controls.Add(this.btnAddHall);
            this.tabPage2.Controls.Add(this.dgvHalls);
            this.tabPage2.Font = new System.Drawing.Font("MV Boli", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(632, 374);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Halls";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // txtCapacity
            // 
            this.txtCapacity.Font = new System.Drawing.Font("MV Boli", 12F);
            this.txtCapacity.Location = new System.Drawing.Point(218, 265);
            this.txtCapacity.Multiline = true;
            this.txtCapacity.Name = "txtCapacity";
            this.txtCapacity.Size = new System.Drawing.Size(193, 23);
            this.txtCapacity.TabIndex = 33;
            // 
            // lblCapacity
            // 
            this.lblCapacity.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblCapacity.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCapacity.Location = new System.Drawing.Point(98, 267);
            this.lblCapacity.Name = "lblCapacity";
            this.lblCapacity.Size = new System.Drawing.Size(104, 23);
            this.lblCapacity.TabIndex = 32;
            this.lblCapacity.Text = "Capacity :";
            this.lblCapacity.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtHallName
            // 
            this.txtHallName.Font = new System.Drawing.Font("MV Boli", 12F);
            this.txtHallName.Location = new System.Drawing.Point(218, 227);
            this.txtHallName.Multiline = true;
            this.txtHallName.Name = "txtHallName";
            this.txtHallName.Size = new System.Drawing.Size(193, 23);
            this.txtHallName.TabIndex = 31;
            // 
            // lblHallname
            // 
            this.lblHallname.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblHallname.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHallname.Location = new System.Drawing.Point(98, 229);
            this.lblHallname.Name = "lblHallname";
            this.lblHallname.Size = new System.Drawing.Size(104, 23);
            this.lblHallname.TabIndex = 30;
            this.lblHallname.Text = "Hall name :";
            this.lblHallname.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnUpdateHall
            // 
            this.btnUpdateHall.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnUpdateHall.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnUpdateHall.Font = new System.Drawing.Font("MV Boli", 12F);
            this.btnUpdateHall.Location = new System.Drawing.Point(475, 222);
            this.btnUpdateHall.Name = "btnUpdateHall";
            this.btnUpdateHall.Size = new System.Drawing.Size(101, 37);
            this.btnUpdateHall.TabIndex = 29;
            this.btnUpdateHall.Text = "Update";
            this.btnUpdateHall.UseVisualStyleBackColor = false;
            this.btnUpdateHall.Click += new System.EventHandler(this.btnUpdateHall_Click);
            // 
            // btnClearHall
            // 
            this.btnClearHall.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnClearHall.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnClearHall.Font = new System.Drawing.Font("MV Boli", 12F);
            this.btnClearHall.Location = new System.Drawing.Point(475, 310);
            this.btnClearHall.Name = "btnClearHall";
            this.btnClearHall.Size = new System.Drawing.Size(101, 37);
            this.btnClearHall.TabIndex = 28;
            this.btnClearHall.Text = "Clear";
            this.btnClearHall.UseVisualStyleBackColor = false;
            this.btnClearHall.Click += new System.EventHandler(this.btnClearHall_Click);
            // 
            // btnDeleteHall
            // 
            this.btnDeleteHall.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnDeleteHall.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDeleteHall.Font = new System.Drawing.Font("MV Boli", 12F);
            this.btnDeleteHall.Location = new System.Drawing.Point(475, 267);
            this.btnDeleteHall.Name = "btnDeleteHall";
            this.btnDeleteHall.Size = new System.Drawing.Size(101, 37);
            this.btnDeleteHall.TabIndex = 27;
            this.btnDeleteHall.Text = "Delete";
            this.btnDeleteHall.UseVisualStyleBackColor = false;
            this.btnDeleteHall.Click += new System.EventHandler(this.btnDeleteHall_Click);
            // 
            // btnAddHall
            // 
            this.btnAddHall.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnAddHall.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAddHall.Font = new System.Drawing.Font("MV Boli", 12F);
            this.btnAddHall.Location = new System.Drawing.Point(475, 179);
            this.btnAddHall.Name = "btnAddHall";
            this.btnAddHall.Size = new System.Drawing.Size(101, 37);
            this.btnAddHall.TabIndex = 26;
            this.btnAddHall.Text = "Add";
            this.btnAddHall.UseVisualStyleBackColor = false;
            this.btnAddHall.Click += new System.EventHandler(this.btnAddHall_Click);
            // 
            // dgvHalls
            // 
            this.dgvHalls.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHalls.Location = new System.Drawing.Point(6, 6);
            this.dgvHalls.Name = "dgvHalls";
            this.dgvHalls.Size = new System.Drawing.Size(620, 159);
            this.dgvHalls.TabIndex = 25;
            this.dgvHalls.SelectionChanged += new System.EventHandler(this.dgvHalls_SelectionChanged);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.dtpTime);
            this.tabPage3.Controls.Add(this.dtpDate);
            this.tabPage3.Controls.Add(this.cmbHall);
            this.tabPage3.Controls.Add(this.cmbMovie);
            this.tabPage3.Controls.Add(this.lblTime);
            this.tabPage3.Controls.Add(this.lblDate);
            this.tabPage3.Controls.Add(this.lblHall);
            this.tabPage3.Controls.Add(this.lblMovie);
            this.tabPage3.Controls.Add(this.btnUpdateShowtime);
            this.tabPage3.Controls.Add(this.btnClearShowtime);
            this.tabPage3.Controls.Add(this.btnDeleteShowtime);
            this.tabPage3.Controls.Add(this.btnAddShowtime);
            this.tabPage3.Controls.Add(this.dgvShowtime);
            this.tabPage3.Font = new System.Drawing.Font("MV Boli", 9.75F);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(632, 374);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "ShowTime";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // dtpTime
            // 
            this.dtpTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpTime.Location = new System.Drawing.Point(196, 300);
            this.dtpTime.Name = "dtpTime";
            this.dtpTime.Size = new System.Drawing.Size(193, 28);
            this.dtpTime.TabIndex = 42;
            // 
            // dtpDate
            // 
            this.dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDate.Location = new System.Drawing.Point(196, 264);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(193, 28);
            this.dtpDate.TabIndex = 41;
            // 
            // cmbHall
            // 
            this.cmbHall.FormattingEnabled = true;
            this.cmbHall.Location = new System.Drawing.Point(196, 229);
            this.cmbHall.Name = "cmbHall";
            this.cmbHall.Size = new System.Drawing.Size(193, 25);
            this.cmbHall.TabIndex = 39;
            // 
            // cmbMovie
            // 
            this.cmbMovie.FormattingEnabled = true;
            this.cmbMovie.Location = new System.Drawing.Point(196, 191);
            this.cmbMovie.Name = "cmbMovie";
            this.cmbMovie.Size = new System.Drawing.Size(193, 25);
            this.cmbMovie.TabIndex = 38;
            // 
            // lblTime
            // 
            this.lblTime.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblTime.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime.Location = new System.Drawing.Point(76, 304);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(104, 23);
            this.lblTime.TabIndex = 36;
            this.lblTime.Text = "Time :";
            this.lblTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDate
            // 
            this.lblDate.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblDate.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.Location = new System.Drawing.Point(76, 268);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(104, 23);
            this.lblDate.TabIndex = 34;
            this.lblDate.Text = "Data :";
            this.lblDate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblHall
            // 
            this.lblHall.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblHall.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHall.Location = new System.Drawing.Point(76, 229);
            this.lblHall.Name = "lblHall";
            this.lblHall.Size = new System.Drawing.Size(104, 23);
            this.lblHall.TabIndex = 32;
            this.lblHall.Text = "Hall :";
            this.lblHall.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblMovie
            // 
            this.lblMovie.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblMovie.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMovie.Location = new System.Drawing.Point(76, 191);
            this.lblMovie.Name = "lblMovie";
            this.lblMovie.Size = new System.Drawing.Size(104, 23);
            this.lblMovie.TabIndex = 30;
            this.lblMovie.Text = "Movie :";
            this.lblMovie.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnUpdateShowtime
            // 
            this.btnUpdateShowtime.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnUpdateShowtime.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnUpdateShowtime.Font = new System.Drawing.Font("MV Boli", 12F);
            this.btnUpdateShowtime.Location = new System.Drawing.Point(475, 222);
            this.btnUpdateShowtime.Name = "btnUpdateShowtime";
            this.btnUpdateShowtime.Size = new System.Drawing.Size(101, 37);
            this.btnUpdateShowtime.TabIndex = 29;
            this.btnUpdateShowtime.Text = "Update";
            this.btnUpdateShowtime.UseVisualStyleBackColor = false;
            this.btnUpdateShowtime.Click += new System.EventHandler(this.btnUpdateShowtime_Click);
            // 
            // btnClearShowtime
            // 
            this.btnClearShowtime.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnClearShowtime.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnClearShowtime.Font = new System.Drawing.Font("MV Boli", 12F);
            this.btnClearShowtime.Location = new System.Drawing.Point(475, 310);
            this.btnClearShowtime.Name = "btnClearShowtime";
            this.btnClearShowtime.Size = new System.Drawing.Size(101, 37);
            this.btnClearShowtime.TabIndex = 28;
            this.btnClearShowtime.Text = "Clear";
            this.btnClearShowtime.UseVisualStyleBackColor = false;
            this.btnClearShowtime.Click += new System.EventHandler(this.btnClearShowtime_Click);
            // 
            // btnDeleteShowtime
            // 
            this.btnDeleteShowtime.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnDeleteShowtime.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDeleteShowtime.Font = new System.Drawing.Font("MV Boli", 12F);
            this.btnDeleteShowtime.Location = new System.Drawing.Point(475, 267);
            this.btnDeleteShowtime.Name = "btnDeleteShowtime";
            this.btnDeleteShowtime.Size = new System.Drawing.Size(101, 37);
            this.btnDeleteShowtime.TabIndex = 27;
            this.btnDeleteShowtime.Text = "Delete";
            this.btnDeleteShowtime.UseVisualStyleBackColor = false;
            this.btnDeleteShowtime.Click += new System.EventHandler(this.btnDeleteShowtime_Click);
            // 
            // btnAddShowtime
            // 
            this.btnAddShowtime.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnAddShowtime.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAddShowtime.Font = new System.Drawing.Font("MV Boli", 12F);
            this.btnAddShowtime.Location = new System.Drawing.Point(475, 179);
            this.btnAddShowtime.Name = "btnAddShowtime";
            this.btnAddShowtime.Size = new System.Drawing.Size(101, 37);
            this.btnAddShowtime.TabIndex = 26;
            this.btnAddShowtime.Text = "Add";
            this.btnAddShowtime.UseVisualStyleBackColor = false;
            this.btnAddShowtime.Click += new System.EventHandler(this.btnAddShowtime_Click);
            // 
            // dgvShowtime
            // 
            this.dgvShowtime.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvShowtime.Location = new System.Drawing.Point(6, 6);
            this.dgvShowtime.Name = "dgvShowtime";
            this.dgvShowtime.Size = new System.Drawing.Size(620, 159);
            this.dgvShowtime.TabIndex = 25;
            this.dgvShowtime.SelectionChanged += new System.EventHandler(this.dgvShowtime_SelectionChanged);
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.btnDeleteticket);
            this.tabPage4.Controls.Add(this.dgvTickets);
            this.tabPage4.Font = new System.Drawing.Font("MV Boli", 9.75F);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(632, 374);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Tickets";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // btnDeleteticket
            // 
            this.btnDeleteticket.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnDeleteticket.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDeleteticket.Font = new System.Drawing.Font("MV Boli", 12F);
            this.btnDeleteticket.Location = new System.Drawing.Point(208, 301);
            this.btnDeleteticket.Name = "btnDeleteticket";
            this.btnDeleteticket.Size = new System.Drawing.Size(207, 37);
            this.btnDeleteticket.TabIndex = 27;
            this.btnDeleteticket.Text = "Delete Ticket";
            this.btnDeleteticket.UseVisualStyleBackColor = false;
            this.btnDeleteticket.Click += new System.EventHandler(this.btnDeleteTicket_Click);
            // 
            // dgvTickets
            // 
            this.dgvTickets.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTickets.Location = new System.Drawing.Point(6, 6);
            this.dgvTickets.Name = "dgvTickets";
            this.dgvTickets.Size = new System.Drawing.Size(620, 275);
            this.dgvTickets.TabIndex = 26;
            // 
            // tabAuditTrail
            // 
            this.tabAuditTrail.Controls.Add(this.btnRefresh);
            this.tabAuditTrail.Controls.Add(this.dgvAuditTrail);
            this.tabAuditTrail.Location = new System.Drawing.Point(4, 22);
            this.tabAuditTrail.Name = "tabAuditTrail";
            this.tabAuditTrail.Padding = new System.Windows.Forms.Padding(3);
            this.tabAuditTrail.Size = new System.Drawing.Size(632, 374);
            this.tabAuditTrail.TabIndex = 4;
            this.tabAuditTrail.Text = "Audit Trail";
            this.tabAuditTrail.UseVisualStyleBackColor = true;
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRefresh.Font = new System.Drawing.Font("MV Boli", 12F);
            this.btnRefresh.Location = new System.Drawing.Point(208, 303);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(207, 37);
            this.btnRefresh.TabIndex = 28;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefreshAudit_Click);
            // 
            // dgvAuditTrail
            // 
            this.dgvAuditTrail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAuditTrail.Location = new System.Drawing.Point(7, 6);
            this.dgvAuditTrail.Name = "dgvAuditTrail";
            this.dgvAuditTrail.Size = new System.Drawing.Size(619, 276);
            this.dgvAuditTrail.TabIndex = 0;
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.btnRefreshRecycle);
            this.tabPage5.Controls.Add(this.btnRestore);
            this.tabPage5.Controls.Add(this.dgvRecycleBin);
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(632, 374);
            this.tabPage5.TabIndex = 5;
            this.tabPage5.Text = "Recycle Bin";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // btnRefreshRecycle
            // 
            this.btnRefreshRecycle.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnRefreshRecycle.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRefreshRecycle.Font = new System.Drawing.Font("MV Boli", 12F);
            this.btnRefreshRecycle.Location = new System.Drawing.Point(351, 298);
            this.btnRefreshRecycle.Name = "btnRefreshRecycle";
            this.btnRefreshRecycle.Size = new System.Drawing.Size(207, 37);
            this.btnRefreshRecycle.TabIndex = 30;
            this.btnRefreshRecycle.Text = "Refresh";
            this.btnRefreshRecycle.UseVisualStyleBackColor = false;
            this.btnRefreshRecycle.Click += new System.EventHandler(this.btnRefreshRecycleBin_Click);
            // 
            // btnRestore
            // 
            this.btnRestore.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnRestore.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRestore.Font = new System.Drawing.Font("MV Boli", 12F);
            this.btnRestore.Location = new System.Drawing.Point(77, 298);
            this.btnRestore.Name = "btnRestore";
            this.btnRestore.Size = new System.Drawing.Size(207, 37);
            this.btnRestore.TabIndex = 29;
            this.btnRestore.Text = "Restore";
            this.btnRestore.UseVisualStyleBackColor = false;
            this.btnRestore.Click += new System.EventHandler(this.btnRestore_Click);
            // 
            // dgvRecycleBin
            // 
            this.dgvRecycleBin.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRecycleBin.Location = new System.Drawing.Point(6, 6);
            this.dgvRecycleBin.Name = "dgvRecycleBin";
            this.dgvRecycleBin.Size = new System.Drawing.Size(620, 269);
            this.dgvRecycleBin.TabIndex = 0;
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.Firebrick;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLogout.Font = new System.Drawing.Font("MV Boli", 12F);
            this.btnLogout.Location = new System.Drawing.Point(703, 12);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(85, 30);
            this.btnLogout.TabIndex = 28;
            this.btnLogout.Text = "Log Out";
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // lblAdmincenter
            // 
            this.lblAdmincenter.BackColor = System.Drawing.SystemColors.Window;
            this.lblAdmincenter.Font = new System.Drawing.Font("MV Boli", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdmincenter.Location = new System.Drawing.Point(286, 15);
            this.lblAdmincenter.Name = "lblAdmincenter";
            this.lblAdmincenter.Size = new System.Drawing.Size(223, 34);
            this.lblAdmincenter.TabIndex = 29;
            this.lblAdmincenter.Text = "Admin Center";
            this.lblAdmincenter.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::CinemaTicketDB.Properties.Resources.Descargar_fondo_abstracto_moderno_gratis;
            this.pictureBox1.Location = new System.Drawing.Point(0, -2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(801, 479);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // btnCreateAdmin
            // 
            this.btnCreateAdmin.BackColor = System.Drawing.Color.SteelBlue;
            this.btnCreateAdmin.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCreateAdmin.Font = new System.Drawing.Font("MV Boli", 12F);
            this.btnCreateAdmin.Location = new System.Drawing.Point(12, 12);
            this.btnCreateAdmin.Name = "btnCreateAdmin";
            this.btnCreateAdmin.Size = new System.Drawing.Size(125, 30);
            this.btnCreateAdmin.TabIndex = 46;
            this.btnCreateAdmin.Text = "Create Admin";
            this.btnCreateAdmin.UseVisualStyleBackColor = false;
            this.btnCreateAdmin.Click += new System.EventHandler(this.btnCreateAdmin_Click);
            // 
            // tabPage6
            // 
            this.tabPage6.Controls.Add(this.btnRefreshMessages);
            this.tabPage6.Controls.Add(this.dgvMessages);
            this.tabPage6.Location = new System.Drawing.Point(4, 22);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage6.Size = new System.Drawing.Size(632, 374);
            this.tabPage6.TabIndex = 6;
            this.tabPage6.Text = "Messages";
            this.tabPage6.UseVisualStyleBackColor = true;
            // 
            // dgvMessages
            // 
            this.dgvMessages.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMessages.Location = new System.Drawing.Point(7, 7);
            this.dgvMessages.Name = "dgvMessages";
            this.dgvMessages.Size = new System.Drawing.Size(619, 269);
            this.dgvMessages.TabIndex = 0;
            // 
            // btnRefreshMessages
            // 
            this.btnRefreshMessages.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnRefreshMessages.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRefreshMessages.Font = new System.Drawing.Font("MV Boli", 12F);
            this.btnRefreshMessages.Location = new System.Drawing.Point(208, 305);
            this.btnRefreshMessages.Name = "btnRefreshMessages";
            this.btnRefreshMessages.Size = new System.Drawing.Size(207, 37);
            this.btnRefreshMessages.TabIndex = 31;
            this.btnRefreshMessages.Text = "Refresh";
            this.btnRefreshMessages.UseVisualStyleBackColor = false;
            this.btnRefreshMessages.Click += new System.EventHandler(this.btnRefreshMessages_Click);
            // 
            // frmAdminManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 474);
            this.Controls.Add(this.btnCreateAdmin);
            this.Controls.Add(this.lblAdmincenter);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.MainTabControl);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmAdminManager";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdminManager";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmAdminManager_FormClosing);
            this.Load += new System.EventHandler(this.frmAdminManager_Load);
            this.MainTabControl.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMovies)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHalls)).EndInit();
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvShowtime)).EndInit();
            this.tabPage4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTickets)).EndInit();
            this.tabAuditTrail.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAuditTrail)).EndInit();
            this.tabPage5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRecycleBin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabPage6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMessages)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TabControl MainTabControl;
        private System.Windows.Forms.DataGridView dgvMovies;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txtRating;
        private System.Windows.Forms.Label lblRating;
        private System.Windows.Forms.TextBox txtDuration;
        private System.Windows.Forms.Label lblDuration;
        private System.Windows.Forms.TextBox txtGenre;
        private System.Windows.Forms.Label lblGenre;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.TextBox txtCapacity;
        private System.Windows.Forms.Label lblCapacity;
        private System.Windows.Forms.TextBox txtHallName;
        private System.Windows.Forms.Label lblHallname;
        private System.Windows.Forms.Button btnUpdateHall;
        private System.Windows.Forms.Button btnClearHall;
        private System.Windows.Forms.Button btnDeleteHall;
        private System.Windows.Forms.Button btnAddHall;
        private System.Windows.Forms.DataGridView dgvHalls;
        private System.Windows.Forms.ComboBox cmbHall;
        private System.Windows.Forms.ComboBox cmbMovie;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblHall;
        private System.Windows.Forms.Label lblMovie;
        private System.Windows.Forms.Button btnUpdateShowtime;
        private System.Windows.Forms.Button btnClearShowtime;
        private System.Windows.Forms.Button btnDeleteShowtime;
        private System.Windows.Forms.Button btnAddShowtime;
        private System.Windows.Forms.DataGridView dgvShowtime;
        private System.Windows.Forms.DateTimePicker dtpTime;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.Button btnDeleteticket;
        private System.Windows.Forms.DataGridView dgvTickets;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Label lblAdmincenter;
        private System.Windows.Forms.Button btnCreateAdmin;
        private System.Windows.Forms.TabPage tabAuditTrail;
        private System.Windows.Forms.DataGridView dgvAuditTrail;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.Button btnRefreshRecycle;
        private System.Windows.Forms.Button btnRestore;
        private System.Windows.Forms.DataGridView dgvRecycleBin;
        private System.Windows.Forms.Button btnRefreshMovies;
        private System.Windows.Forms.TabPage tabPage6;
        private System.Windows.Forms.Button btnRefreshMessages;
        private System.Windows.Forms.DataGridView dgvMessages;
    }
}