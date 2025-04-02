using System;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace Bank_System
{
    public partial class Facture : Form
    {
        private string _UserName, _Password;
        private const string FactureFileName = @"C:\Users\Med Amine\source\Window Form\Bank System\Facture_File.txt";

        public Facture(string UserName, string Password)
        {
            InitializeComponent();
            _UserName = UserName;
            _Password = Password;
        }

        private string GetCompany()
        {
            return rdOrange.Checked ? rdOrange.Tag.ToString() :
                   rdOreedoo.Checked ? rdOreedoo.Tag.ToString() :
                   rdTelecome.Tag.ToString();
        }

        private (bool Exists, bool Paid, string Company) FindFacture(string code)
        {
            foreach (string line in File.ReadLines(FactureFileName))
            {
                string[] content = line.Split('/');
                if (content.Length < 5) continue;

                if (content[0] == _UserName && content[1] == _Password && content[2] == code)
                {
                    bool isPaid = content[4] == "1";
                    return (true, isPaid, content[3]);
                }
            }
            return (false, false, string.Empty);
        }

        private void UpdateFacture(string code)
        {
            string[] lines = File.ReadAllLines(FactureFileName);
            for (int i = 0; i < lines.Length; i++)
            {
                string[] content = lines[i].Split('/');
                if (content.Length >= 5 &&
                    content[0] == _UserName &&
                    content[1] == _Password &&
                    content[2] == code)
                {
                    content[4] = "1"; // Mark as paid
                    lines[i] = string.Join("/", content);
                    File.WriteAllLines(FactureFileName, lines);
                    return;
                }
            }
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            string code = txtCode.Text.Trim();
            string selectedCompany = GetCompany();

            if (string.IsNullOrEmpty(code))
            {
                MessageBox.Show($"Please enter your invoice code for {selectedCompany} company.", "Info",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            var (exists, isPaid, company) = FindFacture(code);

            if (!exists)
            {
                MessageBox.Show("This code does not exist.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (company != selectedCompany)
            {
                MessageBox.Show($"This code does not belong to {selectedCompany} company.", "Info",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (isPaid)
            {
                MessageBox.Show($"This invoice is already paid in {selectedCompany}.", "Info",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            UpdateFacture(code);
            MessageBox.Show($"Invoice successfully paid in {selectedCompany}.", "Success",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void txtCode_MouseClick(object sender, MouseEventArgs e)
        {
            txtCode.Clear();
            txtCode.ForeColor = Color.Black;
        }
    }
}
