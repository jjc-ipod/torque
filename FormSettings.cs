using System;
using System.IO;
using System.Windows.Forms;
using System.Net;

namespace TorControl
{
    public partial class FormSettings : Form
    {
        public FormSettings()
        {
            InitializeComponent();
        }

        private void btnDefaults_Click(object sender, EventArgs e)
        {
            txtAddress.Text = "127.0.0.1";
            txtPort.Text = "9051";
            txtPassword.Text = "";
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnApply_Click(object sender, EventArgs e)
        {
            // Validate IP Address
            IPAddress i;
            if (!IPAddress.TryParse(txtAddress.Text, out i))
            {
                MessageBox.Show("An error occurred while validating the IP Address supplied. Please make sure that you have entered a valid IP Address!", "Bad input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Validate Port
            int port;
            try // Check if input is a number
            {
                port = Convert.ToInt32(txtPort.Text);
            }
            catch
            {
                MessageBox.Show("An error occurred while validating the Port Number supplied. Please enter a valid port number between 1 and 65536", "Bad input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            // Check if number is within valid port range
            if (port < 1 || port > 65535)
            {
                MessageBox.Show("An error occurred while validating the Port Number supplied. Please enter a valid port number between 1 and 65536", "Bad input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Update settings
            FormMain f = new FormMain();
            f.createSettings(txtAddress.Text, port, txtPassword.Text);
            this.Close();
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            if (txtPassword.PasswordChar == '*')
                txtPassword.PasswordChar = '\0';
            else
                txtPassword.PasswordChar = '*';
        }

        private void Settings_TextChanged(object sender, EventArgs e)
        {
            btnApply.Enabled = true;
        }
    }
}
