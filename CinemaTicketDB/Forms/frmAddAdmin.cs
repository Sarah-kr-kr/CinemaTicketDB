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
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CinemaTicketDB
{
    public partial class frmAddAdmin : Form
    {
        public frmAddAdmin()
        {
            InitializeComponent();
            this.Load += frmAddAdmin_Load;
        }

        private void frmAddAdmin_Load(object sender, EventArgs e)
        {
            txtPhonenumber.Text = "optional";
            txtPhonenumber.ForeColor = Color.Gray;

            txtPhonenumber.Enter += txtPhoneNumber_Enter;
            txtPhonenumber.Leave += txtPhoneNumber_Leave;
        }

        private void txtPhoneNumber_Enter(object sender, EventArgs e)
        {
            if (txtPhonenumber.Text == "optional")
            {
                txtPhonenumber.Text = "";
                txtPhonenumber.ForeColor = Color.Black;
            }
        }

        private void txtPhoneNumber_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtPhonenumber.Text))
            {
                txtPhonenumber.Text = "optional";
                txtPhonenumber.ForeColor = Color.Gray;
            }
        }

        private void btnAddAdmin_Click(object sender, EventArgs e)
        {
            string fullName = txtFullname.Text.Trim();
            string email = txtEmail.Text.Trim();
            string password = txtPassword.Text;
            string confirmPassword = txtConfirmpassword.Text;
            string phone = txtPhonenumber.Text.Trim();
            if (phone == "optional") phone = null;

            // التحقق من الحقول
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

            // ✅ تشفير كلمة المرور
            string hashedPassword = SecurityHelper.ComputeSha256Hash(password);

            User newAdmin = new User
            {
                FullName = fullName,
                Email = email,
                Password = hashedPassword,
                PhoneNumber = phone,
                Role = "Admin"
            };

            if (UserDAL.AddUser(newAdmin))
            {
                MessageBox.Show("Admin account created successfully.");
                this.Close();
                AuditDAL.LogAction(newAdmin.UserID, "add_admin", "Admin account created successfully");
            }
            else
            {
                MessageBox.Show("Failed to create admin account.");
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            new frmAdminManager().Show();
        }
        private void frmAddAdmin_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            new frmAdminManager().Show();

        }
    }
}