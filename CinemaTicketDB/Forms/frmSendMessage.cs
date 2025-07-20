using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Http;
using Newtonsoft.Json;
using CinemaTicketApp.Data;

namespace CinemaTicketDB.Forms
{
    public partial class frmSendMessage : Form
    {
        private Form _parentForm;
        public frmSendMessage(Form parentForm)
        {
            InitializeComponent();
            _parentForm = parentForm;
        }

        private void frmSendMessage_Load(object sender, EventArgs e)
        {
            if (GlobalData.CurrentUser != null)
            {
                txtUserID.Text = GlobalData.CurrentUser.UserID.ToString();
                txtName.Text = GlobalData.CurrentUser.FullName;

                // اجعل الحقول غير قابلة للتعديل إذا أردت
                txtUserID.Enabled = false;
                txtName.Enabled = false;
            }
            else
            {
                MessageBox.Show("No user is currently logged in.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.Close();
            }
        }


        private async void btnSend_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtName.Text) || string.IsNullOrWhiteSpace(txtMessage.Text))
            {
                MessageBox.Show("Please fill in all fields.");
                return;
            }

            var payload = new
            {
                user_id = GlobalData.CurrentUser.UserID,
                username = txtName.Text.Trim(),
                message = txtMessage.Text.Trim()
            };

            string apiUrl = "http://dev2.alashiq.com/send.php?systemId=2651412887162";

            try
            {
                using (HttpClient client = new HttpClient())
                {
                    string json = JsonConvert.SerializeObject(payload);
                    var content = new StringContent(json, Encoding.UTF8, "application/json");

                    HttpResponseMessage response = await client.PostAsync(apiUrl, content);

                    if (response.IsSuccessStatusCode)
                    {
                        MessageBox.Show("Message sent successfully!");
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show($"Failed to send message. Status code: {response.StatusCode}");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            _parentForm?.Show();
            this.Close();
        }

        private void frmSendMessage_FormClosing(object sender, FormClosingEventArgs e)
        {
            _parentForm?.Show();
        }
    }
}
