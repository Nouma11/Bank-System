using System;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace Bank_System
{
    public partial class Withdraw : Form
    {
        private double _balance, _amount;
        private string Sender, Reciver, UserItself;
        private const string UserFileName = @"C:\Users\Med Amine\source\Window Form\Bank System\User.txt";

        public Withdraw(double balance, string user)
        {
            InitializeComponent();
            _balance = balance;
            UserItself = user;
        }

        private bool Exist(string user)
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
                    if (content.Length >= 1 && user == content[0])
                    {
                        return true;
                    }
                }
                return false;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error accessing user data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        private void UpdateBalance()
        {
            try
            {
                var lines = File.ReadAllLines(UserFileName).ToList();
                bool senderUpdated = false, receiverUpdated = false;

                for (int i = 0; i < lines.Count; i++)
                {
                    var content = lines[i].Split('/');
                    if ( content[0] == Sender)
                    {
                        content[4] = (_balance - _amount).ToString();
                        lines[i] = string.Join("/", content);
                        senderUpdated = true;
                    }
                    if ( content[0] == Reciver)
                    {
                        content[4] = (_balance + _amount).ToString();
                        lines[i] = string.Join("/", content);
                        receiverUpdated = true;
                    }

                    if (senderUpdated && receiverUpdated)
                        break;
                }

                File.WriteAllLines(UserFileName, lines);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error updating balance: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool HasMoney(double balance, double amount)
        {
            return balance >= amount;
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            if (!double.TryParse(txtAmount.Text, out double amount) || amount <= 0)
            {
                MessageBox.Show("Please enter a valid positive amount.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string recipient = txtUser.Text.Trim();

            if (!Exist(recipient))
            {
                MessageBox.Show("User Not Found", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (!HasMoney(_balance, amount))
            {
                MessageBox.Show("You don't have enough money.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (recipient == UserItself)
            {
                MessageBox.Show("You can't withdraw to the same account.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            _amount = amount;
            Sender = UserItself;
            Reciver = recipient;

            UpdateBalance();
            MessageBox.Show("Withdrawal done successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            txtAmount.Clear();
            txtUser.Clear();
        }
    }
}