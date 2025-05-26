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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.dgvMovies = new System.Windows.Forms.DataGridView();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnbtnUpdate = new System.Windows.Forms.Button();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.txtGenre = new System.Windows.Forms.TextBox();
            this.lblGenre = new System.Windows.Forms.Label();
            this.txtDuration = new System.Windows.Forms.TextBox();
            this.lblDuration = new System.Windows.Forms.Label();
            this.txtRating = new System.Windows.Forms.TextBox();
            this.lblRating = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.lblCapacity = new System.Windows.Forms.Label();
            this.txtHallname = new System.Windows.Forms.TextBox();
            this.lblHallname = new System.Windows.Forms.Label();
            this.btnUpdate2 = new System.Windows.Forms.Button();
            this.btnClear2 = new System.Windows.Forms.Button();
            this.btnDelete2 = new System.Windows.Forms.Button();
            this.btnAdd2 = new System.Windows.Forms.Button();
            this.dgvHalls = new System.Windows.Forms.DataGridView();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnAdd3 = new System.Windows.Forms.Button();
            this.btnDelete3 = new System.Windows.Forms.Button();
            this.btnClear3 = new System.Windows.Forms.Button();
            this.btnUpdate3 = new System.Windows.Forms.Button();
            this.lblMovie = new System.Windows.Forms.Label();
            this.lblHall = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            this.cbMovielist = new System.Windows.Forms.ComboBox();
            this.cbHalllist = new System.Windows.Forms.ComboBox();
            this.dtpdate = new System.Windows.Forms.DateTimePicker();
            this.dtpTime = new System.Windows.Forms.DateTimePicker();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.btnDeleteticket = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.lblAdmincenter = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMovies)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHalls)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Location = new System.Drawing.Point(79, 52);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(640, 400);
            this.tabControl1.TabIndex = 12;
            this.tabControl1.Tag = "";
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.txtRating);
            this.tabPage1.Controls.Add(this.lblRating);
            this.tabPage1.Controls.Add(this.txtDuration);
            this.tabPage1.Controls.Add(this.lblDuration);
            this.tabPage1.Controls.Add(this.txtGenre);
            this.tabPage1.Controls.Add(this.lblGenre);
            this.tabPage1.Controls.Add(this.txtTitle);
            this.tabPage1.Controls.Add(this.lblTitle);
            this.tabPage1.Controls.Add(this.btnbtnUpdate);
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
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.textBox3);
            this.tabPage2.Controls.Add(this.lblCapacity);
            this.tabPage2.Controls.Add(this.txtHallname);
            this.tabPage2.Controls.Add(this.lblHallname);
            this.tabPage2.Controls.Add(this.btnUpdate2);
            this.tabPage2.Controls.Add(this.btnClear2);
            this.tabPage2.Controls.Add(this.btnDelete2);
            this.tabPage2.Controls.Add(this.btnAdd2);
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
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.dtpTime);
            this.tabPage3.Controls.Add(this.dtpdate);
            this.tabPage3.Controls.Add(this.cbHalllist);
            this.tabPage3.Controls.Add(this.cbMovielist);
            this.tabPage3.Controls.Add(this.lblTime);
            this.tabPage3.Controls.Add(this.lblDate);
            this.tabPage3.Controls.Add(this.lblHall);
            this.tabPage3.Controls.Add(this.lblMovie);
            this.tabPage3.Controls.Add(this.btnUpdate3);
            this.tabPage3.Controls.Add(this.btnClear3);
            this.tabPage3.Controls.Add(this.btnDelete3);
            this.tabPage3.Controls.Add(this.btnAdd3);
            this.tabPage3.Controls.Add(this.dataGridView1);
            this.tabPage3.Font = new System.Drawing.Font("MV Boli", 9.75F);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(632, 374);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "ShowTime";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.btnDeleteticket);
            this.tabPage4.Controls.Add(this.dataGridView2);
            this.tabPage4.Font = new System.Drawing.Font("MV Boli", 9.75F);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(632, 374);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Tickets";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // dgvMovies
            // 
            this.dgvMovies.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMovies.Location = new System.Drawing.Point(6, 7);
            this.dgvMovies.Name = "dgvMovies";
            this.dgvMovies.Size = new System.Drawing.Size(620, 159);
            this.dgvMovies.TabIndex = 0;
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAdd.Font = new System.Drawing.Font("MV Boli", 12F);
            this.btnAdd.Location = new System.Drawing.Point(475, 180);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(101, 37);
            this.btnAdd.TabIndex = 13;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDelete.Font = new System.Drawing.Font("MV Boli", 12F);
            this.btnDelete.Location = new System.Drawing.Point(475, 268);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(101, 37);
            this.btnDelete.TabIndex = 14;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnClear.Font = new System.Drawing.Font("MV Boli", 12F);
            this.btnClear.Location = new System.Drawing.Point(475, 311);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(101, 37);
            this.btnClear.TabIndex = 15;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            // 
            // btnbtnUpdate
            // 
            this.btnbtnUpdate.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnbtnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnbtnUpdate.Font = new System.Drawing.Font("MV Boli", 12F);
            this.btnbtnUpdate.Location = new System.Drawing.Point(475, 223);
            this.btnbtnUpdate.Name = "btnbtnUpdate";
            this.btnbtnUpdate.Size = new System.Drawing.Size(101, 37);
            this.btnbtnUpdate.TabIndex = 16;
            this.btnbtnUpdate.Text = "Update";
            this.btnbtnUpdate.UseVisualStyleBackColor = false;
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
            this.lblTitle.Text = "Titlel :";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            // textBox3
            // 
            this.textBox3.Font = new System.Drawing.Font("MV Boli", 12F);
            this.textBox3.Location = new System.Drawing.Point(218, 265);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(193, 23);
            this.textBox3.TabIndex = 33;
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
            // txtHallname
            // 
            this.txtHallname.Font = new System.Drawing.Font("MV Boli", 12F);
            this.txtHallname.Location = new System.Drawing.Point(218, 227);
            this.txtHallname.Multiline = true;
            this.txtHallname.Name = "txtHallname";
            this.txtHallname.Size = new System.Drawing.Size(193, 23);
            this.txtHallname.TabIndex = 31;
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
            // btnUpdate2
            // 
            this.btnUpdate2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnUpdate2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnUpdate2.Font = new System.Drawing.Font("MV Boli", 12F);
            this.btnUpdate2.Location = new System.Drawing.Point(475, 222);
            this.btnUpdate2.Name = "btnUpdate2";
            this.btnUpdate2.Size = new System.Drawing.Size(101, 37);
            this.btnUpdate2.TabIndex = 29;
            this.btnUpdate2.Text = "Update";
            this.btnUpdate2.UseVisualStyleBackColor = false;
            // 
            // btnClear2
            // 
            this.btnClear2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnClear2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnClear2.Font = new System.Drawing.Font("MV Boli", 12F);
            this.btnClear2.Location = new System.Drawing.Point(475, 310);
            this.btnClear2.Name = "btnClear2";
            this.btnClear2.Size = new System.Drawing.Size(101, 37);
            this.btnClear2.TabIndex = 28;
            this.btnClear2.Text = "Clear";
            this.btnClear2.UseVisualStyleBackColor = false;
            // 
            // btnDelete2
            // 
            this.btnDelete2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnDelete2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDelete2.Font = new System.Drawing.Font("MV Boli", 12F);
            this.btnDelete2.Location = new System.Drawing.Point(475, 267);
            this.btnDelete2.Name = "btnDelete2";
            this.btnDelete2.Size = new System.Drawing.Size(101, 37);
            this.btnDelete2.TabIndex = 27;
            this.btnDelete2.Text = "Delete";
            this.btnDelete2.UseVisualStyleBackColor = false;
            // 
            // btnAdd2
            // 
            this.btnAdd2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnAdd2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAdd2.Font = new System.Drawing.Font("MV Boli", 12F);
            this.btnAdd2.Location = new System.Drawing.Point(475, 179);
            this.btnAdd2.Name = "btnAdd2";
            this.btnAdd2.Size = new System.Drawing.Size(101, 37);
            this.btnAdd2.TabIndex = 26;
            this.btnAdd2.Text = "Add";
            this.btnAdd2.UseVisualStyleBackColor = false;
            // 
            // dgvHalls
            // 
            this.dgvHalls.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHalls.Location = new System.Drawing.Point(6, 6);
            this.dgvHalls.Name = "dgvHalls";
            this.dgvHalls.Size = new System.Drawing.Size(620, 159);
            this.dgvHalls.TabIndex = 25;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(6, 6);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(620, 159);
            this.dataGridView1.TabIndex = 25;
            // 
            // btnAdd3
            // 
            this.btnAdd3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnAdd3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAdd3.Font = new System.Drawing.Font("MV Boli", 12F);
            this.btnAdd3.Location = new System.Drawing.Point(475, 179);
            this.btnAdd3.Name = "btnAdd3";
            this.btnAdd3.Size = new System.Drawing.Size(101, 37);
            this.btnAdd3.TabIndex = 26;
            this.btnAdd3.Text = "Add";
            this.btnAdd3.UseVisualStyleBackColor = false;
            // 
            // btnDelete3
            // 
            this.btnDelete3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnDelete3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDelete3.Font = new System.Drawing.Font("MV Boli", 12F);
            this.btnDelete3.Location = new System.Drawing.Point(475, 267);
            this.btnDelete3.Name = "btnDelete3";
            this.btnDelete3.Size = new System.Drawing.Size(101, 37);
            this.btnDelete3.TabIndex = 27;
            this.btnDelete3.Text = "Delete";
            this.btnDelete3.UseVisualStyleBackColor = false;
            // 
            // btnClear3
            // 
            this.btnClear3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnClear3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnClear3.Font = new System.Drawing.Font("MV Boli", 12F);
            this.btnClear3.Location = new System.Drawing.Point(475, 310);
            this.btnClear3.Name = "btnClear3";
            this.btnClear3.Size = new System.Drawing.Size(101, 37);
            this.btnClear3.TabIndex = 28;
            this.btnClear3.Text = "Clear";
            this.btnClear3.UseVisualStyleBackColor = false;
            // 
            // btnUpdate3
            // 
            this.btnUpdate3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnUpdate3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnUpdate3.Font = new System.Drawing.Font("MV Boli", 12F);
            this.btnUpdate3.Location = new System.Drawing.Point(475, 222);
            this.btnUpdate3.Name = "btnUpdate3";
            this.btnUpdate3.Size = new System.Drawing.Size(101, 37);
            this.btnUpdate3.TabIndex = 29;
            this.btnUpdate3.Text = "Update";
            this.btnUpdate3.UseVisualStyleBackColor = false;
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
            // cbMovielist
            // 
            this.cbMovielist.FormattingEnabled = true;
            this.cbMovielist.Location = new System.Drawing.Point(196, 191);
            this.cbMovielist.Name = "cbMovielist";
            this.cbMovielist.Size = new System.Drawing.Size(193, 25);
            this.cbMovielist.TabIndex = 38;
            // 
            // cbHalllist
            // 
            this.cbHalllist.FormattingEnabled = true;
            this.cbHalllist.Location = new System.Drawing.Point(196, 229);
            this.cbHalllist.Name = "cbHalllist";
            this.cbHalllist.Size = new System.Drawing.Size(193, 25);
            this.cbHalllist.TabIndex = 39;
            // 
            // dtpdate
            // 
            this.dtpdate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpdate.Location = new System.Drawing.Point(196, 264);
            this.dtpdate.Name = "dtpdate";
            this.dtpdate.Size = new System.Drawing.Size(193, 28);
            this.dtpdate.TabIndex = 41;
            // 
            // dtpTime
            // 
            this.dtpTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpTime.Location = new System.Drawing.Point(196, 300);
            this.dtpTime.Name = "dtpTime";
            this.dtpTime.Size = new System.Drawing.Size(193, 28);
            this.dtpTime.TabIndex = 42;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(6, 6);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(620, 275);
            this.dataGridView2.TabIndex = 26;
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
            // frmAdminManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 474);
            this.Controls.Add(this.lblAdmincenter);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmAdminManager";
            this.Text = "AdminManager";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMovies)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHalls)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.DataGridView dgvMovies;
        private System.Windows.Forms.Button btnbtnUpdate;
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
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label lblCapacity;
        private System.Windows.Forms.TextBox txtHallname;
        private System.Windows.Forms.Label lblHallname;
        private System.Windows.Forms.Button btnUpdate2;
        private System.Windows.Forms.Button btnClear2;
        private System.Windows.Forms.Button btnDelete2;
        private System.Windows.Forms.Button btnAdd2;
        private System.Windows.Forms.DataGridView dgvHalls;
        private System.Windows.Forms.ComboBox cbHalllist;
        private System.Windows.Forms.ComboBox cbMovielist;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblHall;
        private System.Windows.Forms.Label lblMovie;
        private System.Windows.Forms.Button btnUpdate3;
        private System.Windows.Forms.Button btnClear3;
        private System.Windows.Forms.Button btnDelete3;
        private System.Windows.Forms.Button btnAdd3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DateTimePicker dtpTime;
        private System.Windows.Forms.DateTimePicker dtpdate;
        private System.Windows.Forms.Button btnDeleteticket;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Label lblAdmincenter;
    }
}