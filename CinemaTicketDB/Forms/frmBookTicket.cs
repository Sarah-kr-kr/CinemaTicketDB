using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CinemaTicketApp.Models;
using CinemaTicketApp.DAL;
using CinemaTicketApp.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;

namespace CinemaTicketDB
{
    public partial class frmBookTicket : Form
    {
        private Form _parentForm;
        private int _showtimeId;

        public frmBookTicket(int showtimeId, Form parentForm)
        {
            InitializeComponent();
            _showtimeId = showtimeId;
            _parentForm = parentForm;
        }

        private void frmBookTicket_Load(object sender, EventArgs e)
        {
            LoadShowtimeDetails();

            foreach (Control ctrl in grpSeats.Controls)
            {
                if (ctrl is Button btn)
                {
                    btn.Click += SeatButton_Click;
                }
            }
        }

        private void LoadShowtimeDetails()
        {
            using (SqlConnection conn = DbHelper.GetConnection())
            {
                string query = @"
                    SELECT m.Title, h.HallName, s.Date, s.StartTime
                    FROM Showtime s
                    INNER JOIN Movie m ON s.MovieID = m.MovieID
                    INNER JOIN Hall h ON s.HallID = h.HallID
                    WHERE s.ShowtimeID = @ShowtimeID";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@ShowtimeID", _showtimeId);

                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    lblMovieTitle.Text = reader["Title"].ToString();
                    lblHallName.Text = reader["HallName"].ToString();
                    lblDateTime.Text = $"{Convert.ToDateTime(reader["Date"]).ToShortDateString()} {reader["StartTime"]}";
                }
            }
        }

        private void SeatButton_Click(object sender, EventArgs e)
        {
            Button clicked = sender as Button;
            lblSelectedseat.Text = clicked.Text;
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            string seatNumber = lblSelectedseat.Text.Trim();

            if (string.IsNullOrWhiteSpace(seatNumber))
            {
                MessageBox.Show("Please select a seat.");
                return;
            }

            if (TicketDAL.IsSeatAlreadyBooked(_showtimeId, seatNumber))
            {
                MessageBox.Show("This seat is already booked. Please select another seat.");
                return;
            }

            Ticket ticket = new Ticket
            {
                ShowtimeID = _showtimeId,
                SeatNumber = seatNumber,
                UserID = GlobalData.CurrentUser.UserID
            };

            if (TicketDAL.BookTicketWithTransaction(ticket))
            {
                MessageBox.Show("Ticket booked successfully!");
                AuditDAL.LogAction(GlobalData.CurrentUser.UserID, "book_ticket", $"Ticket booked for seat {seatNumber} at showtime {_showtimeId}");
                _parentForm?.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Booking failed. This seat may already be taken.");
            }

        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            _parentForm?.Show();
            this.Close();
        }

        private void frmBookTicket_FormClosing(object sender, FormClosingEventArgs e)
        {

             _parentForm?.Show();

        }
    }
}
