using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bank_System
{
    public partial class Form1 : Form
    {
        // Constants
        private const string UserFileName = @"C:\Users\Med Amine\source\Window Form\Bank System\User.txt";
        private const int MaxLoginAttempts = 3;
        private const int LockoutDuration = 120; // seconds

        // Fields
        private int failedAttempts = 0;
        private int countdown = 0;

        private Form2 mainPage;
        public Form1()
        {
            InitializeComponent();
            // Initialize UI elements
            TimerBlock.Text = string.Empty;
            LoginTimer.Stop();
        }

        private bool ValidateLogin(string user, string password)
        {
            try
            {
                if (!File.Exists(UserFileName))
                {
                    MessageBox.Show("User database not found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }

                var lines = File.ReadLines(UserFileName);
                foreach (string line in lines)
                {
                    string[] content = line.Split('/');
                    if (content.Length >= 2 &&
                        user == content[0] &&
                        password == content[1])
                    {
                        mainPage = new Form2(content[0], content[1], content[2], content[3], Convert.ToDouble(content[4]));
                        return true;
                    }
                }
                return false;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error accessing user data: {ex.Message}", "Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtUser.Text) || string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                MessageBox.Show("Please enter both username and password", "Warning",
                              MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (failedAttempts >= MaxLoginAttempts)
            {
                MessageBox.Show($"Too many failed attempts. Please wait {LockoutDuration} seconds.",
                              "Account Locked", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (ValidateLogin(txtUser.Text, txtPassword.Text))
            {
                // Successful login
                failedAttempts = 0; // Reset failed attempts
                this.Hide(); // Hide login form

                using (mainPage)
                {
                    mainPage.ShowDialog();
                }

                // Clear fields when returning to login form
                txtUser.Clear();
                txtPassword.Clear();
                this.Show();
            }
            else
            {
                failedAttempts++;
                SystemSounds.Beep.Play();

                if (failedAttempts >= MaxLoginAttempts)
                {
                    // Start lockout timer
                    countdown = LockoutDuration;
                    TimerBlock.Text = countdown.ToString();
                    panel1.Enabled = false;
                    LoginTimer.Start();
                }

                MessageBox.Show($"Invalid username or password. Attempts remaining: {MaxLoginAttempts - failedAttempts}",
                              "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void LoginTimer_Tick(object sender, EventArgs e)
        {
            countdown--;
            TimerBlock.Text = countdown.ToString();

            if (countdown <= 0)
            {
                LoginTimer.Stop();
                panel1.Enabled = true;
                TimerBlock.Text = string.Empty;
                failedAttempts = 0;
                txtUser.Focus(); // Return focus to username field
            }
        }

        private void txtPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnLogin.PerformClick();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}