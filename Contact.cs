using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bank_System
{
    public partial class Contact: Form
    {
        public Contact()
        {
            InitializeComponent();
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtcontact.Text))
            {
                MessageBox.Show("You can't Send Empty Message", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            txtcontact.Clear();
            MessageBox.Show("Message Send To Our Team Succefuly", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
