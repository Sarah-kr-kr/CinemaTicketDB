using CinemaTicketApp.DAL;
using CinemaTicketApp.Helpers;
using CinemaTicketApp.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CinemaTicketDB
{
    public partial class frmCustomerRegister : Form
    {
        public frmCustomerRegister()
        {
            InitializeComponent();
            this.KeyPreview = true;
            this.KeyDown += frmCustomerRegister_KeyDown;
        }

        private void frmCustomerRegister_Load(object sender, EventArgs e)
        {
            txtPhoneNumber.Text = "optional";
            txtPhoneNumber.ForeColor = Color.Gray;


        }

        private void txtPhoneNumber_Enter(object sender, EventArgs e)
        {
            if (txtPhoneNumber.Text == "optional")
            {
                txtPhoneNumber.Text = "";
                txtPhoneNumber.ForeColor = Color.Black;
            }
        }

        private void txtPhoneNumber_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtPhoneNumber.Text))
            {
                txtPhoneNumber.Text = "optional";
                txtPhoneNumber.ForeColor = Color.Gray;
            }
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            string fullName = txtFullName.Text.Trim();
            string email = txtEmail.Text.Trim();
            string password = txtPassword.Text;
            string confirmPassword = txtConfirmPassword.Text;
            string phone = txtPhoneNumber.Text.Trim();
            if (phone == "optional") phone = null;

            if (!ValidationHelper.IsValidFullName(fullName))
            {
                MessageBox.Show("Full name must be at least 5 characters.");
                return;
            }

            if (!ValidationHelper.IsValidEmail(email))
            {
                MessageBox.Show("Invalid email format.");
                return;
            }

            if (UserDAL.EmailExists(email))
            {
                MessageBox.Show("This email is already registered.");
                return;
            }

            if (!ValidationHelper.IsValidPassword(password))
            {
                MessageBox.Show("Password must be at least 8 characters and include upper, lower, number and symbol.");
                return;
            }

            if (password != confirmPassword)
            {
                MessageBox.Show("Passwords do not match.");
                return;
            }

            if (!string.IsNullOrWhiteSpace(phone) && !ValidationHelper.IsValidPhone(phone))
            {
                MessageBox.Show("Invalid phone number.");
                return;
            }

            string hashedPassword = SecurityHelper.ComputeSha256Hash(password);

            User newUser = new User
            {
                FullName = fullName,
                Email = email,
                Password = hashedPassword,
                PhoneNumber = phone,
                Role = "Customer"
            };

            if (UserDAL.AddUser(newUser))
            {
                MessageBox.Show("Registration successful! You can now log in.");
                AuditDAL.LogAction(newUser.UserID, "register", "User registered successfully");
                frmCustomerLogin loginForm = new frmCustomerLogin();
                loginForm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Failed to register. Please try again later.");
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            frmCustomerLogin loginForm = new frmCustomerLogin();
            loginForm.Show();
            this.Hide();
        }

        private void frmCustomerRegister_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (Application.OpenForms["frmCustomerLogin"] == null)
            {
                Application.Exit();
            }
        }

        private void frmCustomerRegister_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.SelectNextControl(this.ActiveControl, true, true, true, true);
                e.SuppressKeyPress = true;
            }
        }
    }
}
