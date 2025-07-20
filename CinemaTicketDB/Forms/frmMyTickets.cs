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

namespace CinemaTicketDB
{
    public partial class frmMyTickets : Form
    {
        private Form _parentForm;

        public frmMyTickets(Form parentForm)
        {
            InitializeComponent();
            _parentForm = parentForm;
        }

        private void frmMyTickets_Load(object sender, EventArgs e)
        {
            LoadMyTickets();
        }

        private void LoadMyTickets()
        {
            DataTable dt = new DataTable();
            using (SqlConnection conn = DbHelper.GetConnection())
            {
                string query = @"
            SELECT 
                t.TicketID,
                m.Title AS MovieTitle,
                h.HallName,
                s.Date,
                s.StartTime,
                t.SeatNumber
            FROM Ticket t
            INNER JOIN Showtime s ON t.ShowtimeID = s.ShowtimeID
            INNER JOIN Movie m ON s.MovieID = m.MovieID
            INNER JOIN Hall h ON s.HallID = h.HallID
            WHERE t.UserID = @UserID AND t.IsDeleted = 0";  // ← تمت الإضافة هنا

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@UserID", GlobalData.CurrentUser.UserID);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
            }

            dgvMyBookedTicket.DataSource = dt;
            if (dgvMyBookedTicket.Columns.Contains("TicketID"))
                dgvMyBookedTicket.Columns["TicketID"].Visible = false;
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadMyTickets();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            _parentForm?.Show();
            this.Close();
        }

        private void btnCancelticket_Click(object sender, EventArgs e)
        {
            if (dgvMyBookedTicket.CurrentRow != null)
            {
                int ticketId = Convert.ToInt32(dgvMyBookedTicket.CurrentRow.Cells["TicketID"].Value);
                DialogResult result = MessageBox.Show("Are you sure you want to cancel this ticket?", "Confirm", MessageBoxButtons.YesNo);

                if (result == DialogResult.Yes)
                {
                    if (TicketDAL.SoftDeleteTicket(ticketId))
                    {
                        MessageBox.Show("Ticket cancelled successfully.");
                        LoadMyTickets();
                    }
                    else
                    {
                        MessageBox.Show("Failed to cancel ticket.");
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select a ticket to cancel.");
            }
        }

        private void btnPrintticket_Click(object sender, EventArgs e)
        {
            if (dgvMyBookedTicket.CurrentRow != null)
            {
                string details = "--- Ticket Details ---\n";
                foreach (DataGridViewCell cell in dgvMyBookedTicket.CurrentRow.Cells)
                {
                    if (cell.Visible)
                    {
                        details += $"{cell.OwningColumn.HeaderText}: {cell.Value}\n";
                    }
                }
                MessageBox.Show(details, "Print Preview");
            }
            else
            {
                MessageBox.Show("Please select a ticket to print.");
            }
        }

        private void frmMyTickets_FormClosing(object sender, FormClosingEventArgs e)
        {
            _parentForm?.Show();
        }
    }
}

