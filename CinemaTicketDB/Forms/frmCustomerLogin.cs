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
using CinemaTicketApp.Helpers;
using CinemaTicketApp.DAL;
using CinemaTicketApp.Data;

namespace CinemaTicketDB
{
    public partial class frmCustomerLogin : Form
    {
        public frmCustomerLogin()
    {
        InitializeComponent();
        this.KeyPreview = true;
        this.Load += frmCustomerLogin_Load;
        this.KeyDown += frmCustomerLogin_KeyDown;
    }

        private void btnLogin_Click(object sender, EventArgs e)
        {

            string email = txtEmail.Text.Trim();
            string password = txtPassword.Text;

            // Validate email and password
            if (!ValidationHelper.IsValidEmail(email))
            {
                MessageBox.Show("Invalid email format.");
                return;
            }

            if (string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Please enter your password.");
                return;
            }

            // Check failed login attempts in the last 5 minutes
            int failedAttempts = LoginAttemptDAL.CountFailedAttempts(email, DateTime.Now.AddMinutes(-5));
            if (failedAttempts >= 5)
            {
                MessageBox.Show("Account temporarily locked due to repeated failed attempts. Please try again later.");
                return;
            }

            // Hash the password
            string hashedPassword = SecurityHelper.ComputeSha256Hash(password);

            // Attempt login
            User user = UserDAL.Authenticate(email, hashedPassword);

            // Record login attempt
            LoginAttemptDAL.AddAttempt(new LoginAttempt
            {
                Email = email,
                AttemptTime = DateTime.Now,
                IsSuccessful = user != null
            });

            if (user != null)
            {
                // Store current user
                GlobalData.CurrentUser = user;

                AuditDAL.LogAction(user.UserID, "login", "User logged in");

                LoginAttemptDAL.ClearAttempts(email); // Reset attempts after successful login


                // Redirect based on role
                if (user.Role == "Customer")
                {
                    new frmCustomerHome().Show();
                }
                else // Admin أو SuperAdmin
                {
                    new frmAdminManager().Show();
                }

                this.Hide();
            }
            else
            {
                MessageBox.Show("Login failed. Please check your email or password.");
            }
        }

        private void lnkRegister_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmCustomerRegister registerForm = new frmCustomerRegister();
            registerForm.Show();
            this.Hide();
        }

        private void frmCustomerLogin_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.SelectNextControl(this.ActiveControl, true, true, true, true);
                e.SuppressKeyPress = true;
            }
        }

        private void frmCustomerLogin_Load(object sender, EventArgs e)
        {
            txtPassword.UseSystemPasswordChar = true;
        }

    }
}
