using System;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace Bank_System
{
    public partial class Deposit : Form
    {
        private double _balance;
        private string _userName, _password;
        private const string UserFileName = @"C:\Users\Med Amine\source\Window Form\Bank System\User.txt";

        public Deposit(string userName, string password, double balance)
        {
            InitializeComponent();
            _userName = userName;
            _password = password;
            _balance = balance;
        }

        private void UpdateBalance(double amount)
        {
            try
            {
                var lines = File.ReadAllLines(UserFileName).ToList();

                for (int i = 0; i < lines.Count; i++)
                {
                    var content = lines[i].Split('/');
                    if (content.Length >= 2 &&
                        _userName == content[0] &&
                        _password == content[1])
                    {
                        content[4] = (_balance + amount).ToString(); // Update balance
                        lines[i] = string.Join("/", content);
                        break;
                    }
                }

                File.WriteAllLines(UserFileName, lines);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error updating balance: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CommonButton_Click(object sender, EventArgs e)
        {
            Button clickedButton = sender as Button;
            if (clickedButton != null)
            {
                if (double.TryParse(clickedButton.Tag.ToString(), out double amount))
                {
                    _balance += amount;
                    UpdateBalance(amount);
                    MessageBox.Show($"Amount deposited successfully: {amount:C}", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Invalid button configuration.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnConfirm1_Click(object sender, EventArgs e)
        {
            if (!double.TryParse(txtAmount.Text, out double amount) || amount <= 0)
            {
                MessageBox.Show("Please enter a valid positive amount.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            _balance += amount;
            UpdateBalance(amount);

            MessageBox.Show($"Amount deposited successfully: {amount:C}", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            txtAmount.Clear();
        }
    }
}