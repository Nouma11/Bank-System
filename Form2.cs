using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Bank_System
{
    public partial class Form2: Form
    {
        private Profile fmProfile;
        private Deposit fmDeposit;
        private Facture fmPayFacture;
        private Withdraw fmWithdraw;
        private Contact fmContact;
        private double _Balance;
        private string _UserName, _Phone, _Email, _password;
        public Form2(string UserName,string Password,string Email,string Phone,Double Balance)
        {
                
            fmProfile = new Profile(UserName,Password, Email, Phone, Balance);
            fmDeposit = new Deposit(UserName, Password, Balance);
            fmPayFacture = new Facture(UserName, Password);
            fmWithdraw = new Withdraw(Balance,UserName);
            fmContact = new Contact();

            _Email = Email;
            _Phone = Phone;
            _UserName = UserName;
            _Balance = Balance;
            _password = Password;
            InitializeComponent();
        }


        

        private void profileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (fmProfile == null || fmProfile.IsDisposed)
            {
                // Create a new instance if it doesn't exist or is disposed
                fmProfile = new Profile(_UserName,_password, _Email, _Phone, _Balance);
                fmProfile.MdiParent = this;
            }

            // Show the form
            fmProfile.Show();
            fmProfile.BringToFront(); // Bring the form to the front if it's already open
        }

        // When closing the form, hide it instead of disposing
        private void HideProfileForm()
        {
            if (fmProfile != null && !fmProfile.IsDisposed)
            {
                fmProfile.Hide(); // Hide the form instead of closing it
            }
        }

        private void depositToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fmDeposit.MdiParent = this;
            fmDeposit.Show();
            
        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void paymentInvoiceToolStripMenuItem_Click(object sender, EventArgs e)
        {

            fmPayFacture.MdiParent = this;
            fmPayFacture.Show();
          

        }
         private void widthrawToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fmWithdraw.MdiParent = this;
            fmWithdraw.Show();
            fmProfile.Refresh();
        }

        private void contactToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fmContact.MdiParent = this;
            fmContact.Show();
        }
    }
}
