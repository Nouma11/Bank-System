using System;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace Bank_System
{
    public partial class Profile : Form
    {
        private string _userName, _email, _phone;
        private double _balance;
        private const string UserFileName = @"C:\Users\Med Amine\source\Window Form\Bank System\User.txt";
        public Profile(string userName, string password, string email, string phone, double balance)
        {
            InitializeComponent();
            _userName = userName;
            _email = email;
            _phone = phone;
            _balance = balance;
            try
            {
                var lines = File.ReadAllLines(UserFileName).ToList();

                for (int i = 0; i < lines.Count; i++)
                {
                    var content = lines[i].Split('/');
                    if (content.Length >= 2 &&
                        _userName == content[0]
                        )
                    {
                        lbBalance.Text = content[4]; // Update balance
                        break;
                    }
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error updating balance: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            // Initialize UI elements
            txtEmail.Text = email;
            txtName.Text = userName;
            txtPhone.Text = phone;


            // Method to refresh profile data

        }
    }
}