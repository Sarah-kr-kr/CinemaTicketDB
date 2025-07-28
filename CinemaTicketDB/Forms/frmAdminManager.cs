using CinemaTicketApp.Data;
using CinemaTicketApp.Models;
using CinemaTicketApp.DAL;
using System;
using System.Windows.Forms;
using System.Data;
using System.Threading.Tasks;

namespace CinemaTicketDB
{
    public partial class frmAdminManager : Form
    {
        public frmAdminManager()
        {
            InitializeComponent();
            this.Load += frmAdminManager_Load;
        }

        private async void frmAdminManager_Load(object sender, EventArgs e)
        {
            if (GlobalData.CurrentUser != null && GlobalData.CurrentUser.Role != "SuperAdmin")
            {
                btnCreateAdmin.Enabled = false;
                btnCreateAdmin.Visible = false;

                MainTabControl.TabPages.Remove(tabAuditTrail);
            }

            LoadMovies();
            LoadHalls();
            LoadTickets();
            LoadShowtimes();
            LoadAuditTrail();
            LoadRecycleBin();
            await LoadMessagesFromAPI();

            txtCapacity.Text = "16";
            txtCapacity.Enabled = false;

            LoadMoviesToComboBox();
            LoadHallsToComboBox();
        }


        private void btnCreateAdmin_Click(object sender, EventArgs e)
        {
            new frmAddAdmin().ShowDialog();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            GlobalData.CurrentUser = null;
            new frmCustomerLogin().Show();
            this.Close();
        }

        // Movie Tab
        private void LoadMovies()
        {
            dgvMovies.DataSource = MovieDAL.GetAllMovies();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtDuration.Text.Trim(), out int duration))
            {
                MessageBox.Show("Duration must be a number.");
                return;
            }

            Movie movie = new Movie
            {
                Title = txtTitle.Text.Trim(),
                Genre = txtGenre.Text.Trim(),
                Duration = duration,
                Rating = txtRating.Text.Trim()
            };

            if (MovieDAL.AddMovie(movie))
            {
                MessageBox.Show("Movie added successfully.");
                LoadMovies();
                ClearMovieFields();

                AuditDAL.LogAction(GlobalData.CurrentUser.UserID, "add_movie", $"Movie '{movie.Title}' added successfully.");
            }
            else
            {
                MessageBox.Show("Failed to add movie.");
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (dgvMovies.CurrentRow == null)
            {
                MessageBox.Show("Please select a movie to update.");
                return;
            }

            if (!int.TryParse(txtDuration.Text.Trim(), out int duration))
            {
                MessageBox.Show("Duration must be a number.");
                return;
            }

            int movieId = Convert.ToInt32(dgvMovies.CurrentRow.Cells["MovieID"].Value);
            Movie movie = new Movie
            {
                MovieID = movieId,
                Title = txtTitle.Text.Trim(),
                Genre = txtGenre.Text.Trim(),
                Duration = duration,
                Rating = txtRating.Text.Trim()
            };

            if (MovieDAL.UpdateMovie(movie))
            {
                MessageBox.Show("Movie updated successfully.");
                LoadMovies();
                ClearMovieFields();

                AuditDAL.LogAction(GlobalData.CurrentUser.UserID, "update_movie", $"Movie '{movie.Title}' updated successfully.");
            }
            else
            {
                MessageBox.Show("Failed to update movie.");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvMovies.CurrentRow == null)
            {
                MessageBox.Show("Please select a movie to delete.");
                return;
            }

            int movieId = Convert.ToInt32(dgvMovies.CurrentRow.Cells["MovieID"].Value);
            if (MovieDAL.SoftDeleteMovie(movieId))
            {
                MessageBox.Show("Movie deleted successfully.");
                LoadMovies();
                ClearMovieFields();

                AuditDAL.LogAction(GlobalData.CurrentUser.UserID, "delete_movie", $"Movie with ID {movieId} deleted successfully.");
            }
            else
            {
                MessageBox.Show("Failed to delete movie.");
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearMovieFields();
        }

        private void ClearMovieFields()
        {
            txtTitle.Clear();
            txtGenre.Clear();
            txtDuration.Clear();
            txtRating.Clear();
        }

        private void btnRefreshMovies_Click(object sender, EventArgs e)
        {
            LoadMovies();
        }

        private void dgvMovies_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvMovies.CurrentRow != null)
            {
                txtTitle.Text = dgvMovies.CurrentRow.Cells["Title"].Value.ToString();
                txtGenre.Text = dgvMovies.CurrentRow.Cells["Genre"].Value.ToString();
                txtDuration.Text = dgvMovies.CurrentRow.Cells["Duration"].Value.ToString();
                txtRating.Text = dgvMovies.CurrentRow.Cells["Rating"].Value.ToString();
            }
        }

        // Halls Tab
        private void LoadHalls()
        {
            dgvHalls.DataSource = HallDAL.GetAllHalls();
        }

        private void btnAddHall_Click(object sender, EventArgs e)
        {

            Hall hall = new Hall
            {
                HallName = txtHallName.Text.Trim(),
                SeatsCapacity = 16
            };

            if (HallDAL.AddHall(hall))
            {
                MessageBox.Show("Hall added successfully.");
                LoadHalls();
                ClearHallFields();

                AuditDAL.LogAction(GlobalData.CurrentUser.UserID, "add_hall", $"Hall '{hall.HallName}' added successfully.");
            }
            else
            {
                MessageBox.Show("Failed to add hall.");
            }
        }

        private void btnUpdateHall_Click(object sender, EventArgs e)
        {
            if (dgvHalls.CurrentRow == null)
            {
                MessageBox.Show("Please select a hall to update.");
                return;
            }

            if (!int.TryParse(txtCapacity.Text.Trim(), out int capacity))
            {
                MessageBox.Show("Capacity must be a number.");
                return;
            }

            int hallId = Convert.ToInt32(dgvHalls.CurrentRow.Cells["HallID"].Value);
            Hall hall = new Hall
            {
                HallID = hallId,
                HallName = txtHallName.Text.Trim(),
                SeatsCapacity = capacity
            };

            if (HallDAL.UpdateHall(hall))
            {
                MessageBox.Show("Hall updated successfully.");
                LoadHalls();
                ClearHallFields();

                AuditDAL.LogAction(GlobalData.CurrentUser.UserID, "update_hall", $"Hall '{hall.HallName}' updated successfully.");
            }
            else
            {
                MessageBox.Show("Failed to update hall.");
            }
        }

        private void btnDeleteHall_Click(object sender, EventArgs e)
        {
            if (dgvHalls.CurrentRow == null)
            {
                MessageBox.Show("Please select a hall to delete.");
                return;
            }

            int hallId = Convert.ToInt32(dgvHalls.CurrentRow.Cells["HallID"].Value);
            if (HallDAL.SoftDeleteHall(hallId))
            {
                MessageBox.Show("Hall deleted successfully.");
                LoadHalls();
                ClearHallFields();

                AuditDAL.LogAction(GlobalData.CurrentUser.UserID, "delete_hall", $"Hall with ID {hallId} deleted successfully.");
            }
            else
            {
                MessageBox.Show("Failed to delete hall.");
            }
        }

        private void btnClearHall_Click(object sender, EventArgs e)
        {
            ClearHallFields();
        }

        private void ClearHallFields()
        {
            txtHallName.Clear();
            txtCapacity.Clear();
        }

        private void dgvHalls_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvHalls.CurrentRow != null)
            {
                txtHallName.Text = dgvHalls.CurrentRow.Cells["HallName"].Value.ToString();
                txtCapacity.Text = dgvHalls.CurrentRow.Cells["SeatsCapacity"].Value.ToString();
            }
        }

        // ShowTime Tab
        private void LoadShowtimes()
        {
            dgvShowtime.DataSource = ShowtimeDAL.GetAllShowtimesWithDetails();
        }

        private void LoadMoviesToComboBox()
        {
            cmbMovie.DataSource = MovieDAL.GetAllMovies();
            cmbMovie.DisplayMember = "Title";
            cmbMovie.ValueMember = "MovieID";
        }

        private void LoadHallsToComboBox()
        {
            cmbHall.DataSource = HallDAL.GetAllHalls();
            cmbHall.DisplayMember = "HallName";
            cmbHall.ValueMember = "HallID";
        }

        private void btnAddShowtime_Click(object sender, EventArgs e)
        {
            if (cmbMovie.SelectedItem == null || cmbHall.SelectedItem == null)
            {
                MessageBox.Show("Please select both movie and hall.");
                return;
            }

            Showtime showtime = new Showtime
            {
                MovieID = (int)cmbMovie.SelectedValue,
                HallID = (int)cmbHall.SelectedValue,
                Date = dtpDate.Value.Date,
                StartTime = dtpTime.Value.TimeOfDay
            };

            if (ShowtimeDAL.AddShowtime(showtime))
            {
                MessageBox.Show("Showtime added successfully.");
                LoadShowtimes();
                ClearShowtimeFields();

                AuditDAL.LogAction(GlobalData.CurrentUser.UserID, "add_showtime", $"Showtime added for movie '{cmbMovie.Text}' in hall '{cmbHall.Text}' on {dtpDate.Value.ToShortDateString()} at {dtpTime.Value.ToShortTimeString()}.");
            }
            else
            {
                MessageBox.Show("Failed to add showtime.");
            }
        }

        private void btnUpdateShowtime_Click(object sender, EventArgs e)
        {
            if (dgvShowtime.CurrentRow == null)
            {
                MessageBox.Show("Please select a showtime to update.");
                return;
            }

            int showtimeId = Convert.ToInt32(dgvShowtime.CurrentRow.Cells["ShowtimeID"].Value);

            Showtime showtime = new Showtime
            {
                ShowtimeID = showtimeId,
                MovieID = (int)cmbMovie.SelectedValue,
                HallID = (int)cmbHall.SelectedValue,
                Date = dtpDate.Value.Date,
                StartTime = dtpTime.Value.TimeOfDay
            };

            if (ShowtimeDAL.UpdateShowtime(showtime))
            {
                MessageBox.Show("Showtime updated successfully.");
                LoadShowtimes();
                ClearShowtimeFields();

                AuditDAL.LogAction(GlobalData.CurrentUser.UserID, "update_showtime", $"Showtime updated for movie '{cmbMovie.Text}' in hall '{cmbHall.Text}' on {dtpDate.Value.ToShortDateString()} at {dtpTime.Value.ToShortTimeString()}.");
            }
            else
            {
                MessageBox.Show("Failed to update showtime.");
            }
        }

        private void btnDeleteShowtime_Click(object sender, EventArgs e)
        {
            if (dgvShowtime.CurrentRow == null)
            {
                MessageBox.Show("Please select a showtime to delete.");
                return;
            }

            int showtimeId = Convert.ToInt32(dgvShowtime.CurrentRow.Cells["ShowtimeID"].Value);

            if (ShowtimeDAL.SoftDeleteShowtime(showtimeId))
            {
                MessageBox.Show("Showtime deleted successfully.");
                LoadShowtimes();
                ClearShowtimeFields();

                AuditDAL.LogAction(GlobalData.CurrentUser.UserID, "delete_showtime", $"Showtime with ID {showtimeId} deleted successfully.");
            }
            else
            {
                MessageBox.Show("Failed to delete showtime.");
            }
        }

        private void dgvShowtime_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvShowtime.CurrentRow != null)
            {
                dtpDate.Value = Convert.ToDateTime(dgvShowtime.CurrentRow.Cells["Date"].Value);
                dtpTime.Value = DateTime.Today + (TimeSpan)dgvShowtime.CurrentRow.Cells["StartTime"].Value;

                cmbMovie.SelectedValue = Convert.ToInt32(dgvShowtime.CurrentRow.Cells["MovieID"].Value);
                cmbHall.SelectedValue = Convert.ToInt32(dgvShowtime.CurrentRow.Cells["HallID"].Value);
            }
        }

        private void btnClearShowtime_Click(object sender, EventArgs e)
        {
            ClearShowtimeFields();
        }

        private void ClearShowtimeFields()
        {
            cmbMovie.SelectedIndex = -1;
            cmbHall.SelectedIndex = -1;
            dtpDate.Value = DateTime.Today;
            dtpTime.Value = DateTime.Now;
        }

        // Tickets Tab
        private void LoadTickets()
        {
            dgvTickets.DataSource = TicketDAL.GetAllTickets();
        }

        private void btnDeleteTicket_Click(object sender, EventArgs e)
        {
            if (dgvTickets.CurrentRow == null)
            {
                MessageBox.Show("Please select a ticket to delete.");
                return;
            }

            int ticketId = Convert.ToInt32(dgvTickets.CurrentRow.Cells["TicketID"].Value);
            if (TicketDAL.SoftDeleteTicket(ticketId))
            {
                MessageBox.Show("Ticket deleted successfully.");
                LoadTickets();
                AuditDAL.LogAction(GlobalData.CurrentUser.UserID, "delete_ticket", $"Ticket with ID {ticketId} deleted successfully.");
            }
            else
            {
                MessageBox.Show("Failed to delete ticket.");
            }
        }

        //Audit Tab

        private void LoadAuditTrail()
        {
            dgvAuditTrail.DataSource = AuditDAL.GetAuditLogs();
        }

        private void btnRefreshAudit_Click(object sender, EventArgs e)
        {
            LoadAuditTrail();
        }

        //Recycle Tab

        private void LoadRecycleBin()
        {
            dgvRecycleBin.DataSource = MovieDAL.GetDeletedMovies();
        }

        private void btnRefreshRecycleBin_Click(object sender, EventArgs e)
        {
            LoadRecycleBin();
        }

        private void btnRestore_Click(object sender, EventArgs e)
        {
            if (dgvRecycleBin.CurrentRow != null)
            {
                int movieId = Convert.ToInt32(dgvRecycleBin.CurrentRow.Cells["MovieID"].Value);
                if (MovieDAL.RestoreMovie(movieId))
                {
                    MessageBox.Show("Movie restored.");
                    LoadRecycleBin();
                }
            }
        }

        // Messages Tab

        private async Task LoadMessagesFromAPI()
        {
            try
            {
                var messages = await ApiMessageDAL.GetAllMessagesAsync();
                dgvMessages.DataSource = messages;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error fetching messages: " + ex.Message);
            }
        }

        private async void btnRefreshMessages_Click(object sender, EventArgs e)
        {
            await LoadMessagesFromAPI();
        }



        private void frmAdminManager_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
