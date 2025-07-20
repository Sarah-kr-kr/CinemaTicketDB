using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using CinemaTicketApp.Data;
using CinemaTicketApp.DAL;
using CinemaTicketDB.Forms;


namespace CinemaTicketDB
{
    public partial class frmCustomerHome : Form
    {
        public frmCustomerHome()
        {
            InitializeComponent();
        }

        private void frmCustomerHome_Load(object sender, EventArgs e)
        {
            LoadShowtimes();
        }

        private void LoadShowtimes()
        {
            DataTable dt = new DataTable();

            using (SqlConnection conn = DbHelper.GetConnection())
            {
                string query = @"
                    SELECT 
                        s.ShowtimeID,
                        m.Title AS MovieTitle,
                        m.Genre,
                        m.Rating,
                        m.Duration,
                        h.HallName,
                        s.Date,
                        s.StartTime
                    FROM Showtime s
                    INNER JOIN Movie m ON s.MovieID = m.MovieID
                    INNER JOIN Hall h ON s.HallID = h.HallID
                    WHERE m.IsDeleted = 0 AND s.Date >= CAST(GETDATE() AS DATE)";

                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                da.Fill(dt);
            }

            dgvShowtimes.DataSource = dt;

            if (dgvShowtimes.Columns.Contains("ShowtimeID"))
                dgvShowtimes.Columns["ShowtimeID"].Visible = false;
        }

        private void btnTicket_Click(object sender, EventArgs e)
        {
            if (dgvShowtimes.CurrentRow != null)
            {
                int showtimeId = Convert.ToInt32(dgvShowtimes.CurrentRow.Cells["ShowtimeID"].Value);
                frmBookTicket bookForm = new frmBookTicket(showtimeId,this);
                bookForm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Please select a showtime to book a ticket.");
            }
        }

        private void btnMyTickets_Click(object sender, EventArgs e)
        {
            frmMyTickets myTicketsForm = new frmMyTickets(this);
            myTicketsForm.Show();
            this.Hide();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            if (GlobalData.CurrentUser != null)
            {
                AuditDAL.LogAction(GlobalData.CurrentUser.UserID, "logout", "User logged out");
            }

            GlobalData.CurrentUser = null;
            frmCustomerLogin loginForm = new frmCustomerLogin();
            loginForm.Show();
            this.Hide();
        }

        private void frmCustomerHome_FormClosing(object sender, FormClosingEventArgs e)
        {
            
            Application.Exit();
            
        }

        private void btnSendMessage_Click(object sender, EventArgs e)
        {
            frmSendMessage sendMessageForm = new frmSendMessage(this);
            sendMessageForm.Show();
            this.Hide();
        }
    }
}
