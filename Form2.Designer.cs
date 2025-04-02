namespace Bank_System
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.msBank = new System.Windows.Forms.MenuStrip();
            this.profileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.depositToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.widthrawToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.paymentInvoiceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contactToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.msBank.SuspendLayout();
            this.SuspendLayout();
            // 
            // msBank
            // 
            this.msBank.AllowMerge = false;
            this.msBank.BackColor = System.Drawing.Color.Moccasin;
            this.msBank.Dock = System.Windows.Forms.DockStyle.None;
            this.msBank.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.msBank.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
            this.msBank.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.msBank.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.profileToolStripMenuItem,
            this.depositToolStripMenuItem,
            this.widthrawToolStripMenuItem,
            this.paymentInvoiceToolStripMenuItem,
            this.contactToolStripMenuItem,
            this.logOutToolStripMenuItem});
            this.msBank.Location = new System.Drawing.Point(305, 9);
            this.msBank.Name = "msBank";
            this.msBank.Size = new System.Drawing.Size(762, 33);
            this.msBank.TabIndex = 1;
            // 
            // profileToolStripMenuItem
            // 
            this.profileToolStripMenuItem.Name = "profileToolStripMenuItem";
            this.profileToolStripMenuItem.Size = new System.Drawing.Size(76, 29);
            this.profileToolStripMenuItem.Text = "&Profile";
            this.profileToolStripMenuItem.Click += new System.EventHandler(this.profileToolStripMenuItem_Click);
            // 
            // depositToolStripMenuItem
            // 
            this.depositToolStripMenuItem.Name = "depositToolStripMenuItem";
            this.depositToolStripMenuItem.Size = new System.Drawing.Size(88, 29);
            this.depositToolStripMenuItem.Text = "&Deposit";
            this.depositToolStripMenuItem.Click += new System.EventHandler(this.depositToolStripMenuItem_Click);
            // 
            // widthrawToolStripMenuItem
            // 
            this.widthrawToolStripMenuItem.Name = "widthrawToolStripMenuItem";
            this.widthrawToolStripMenuItem.Size = new System.Drawing.Size(102, 29);
            this.widthrawToolStripMenuItem.Text = "&Withdraw";
            this.widthrawToolStripMenuItem.Click += new System.EventHandler(this.widthrawToolStripMenuItem_Click);
            // 
            // paymentInvoiceToolStripMenuItem
            // 
            this.paymentInvoiceToolStripMenuItem.Name = "paymentInvoiceToolStripMenuItem";
            this.paymentInvoiceToolStripMenuItem.Size = new System.Drawing.Size(155, 29);
            this.paymentInvoiceToolStripMenuItem.Text = "Payment &Invoice";
            this.paymentInvoiceToolStripMenuItem.Click += new System.EventHandler(this.paymentInvoiceToolStripMenuItem_Click);
            // 
            // contactToolStripMenuItem
            // 
            this.contactToolStripMenuItem.Name = "contactToolStripMenuItem";
            this.contactToolStripMenuItem.Size = new System.Drawing.Size(87, 29);
            this.contactToolStripMenuItem.Text = "&Contact";
            this.contactToolStripMenuItem.Click += new System.EventHandler(this.contactToolStripMenuItem_Click);
            // 
            // logOutToolStripMenuItem
            // 
            this.logOutToolStripMenuItem.Name = "logOutToolStripMenuItem";
            this.logOutToolStripMenuItem.Size = new System.Drawing.Size(91, 29);
            this.logOutToolStripMenuItem.Text = "Log Out";
            this.logOutToolStripMenuItem.Click += new System.EventHandler(this.logOutToolStripMenuItem_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Moccasin;
            this.ClientSize = new System.Drawing.Size(1257, 702);
            this.Controls.Add(this.msBank);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.msBank;
            this.Name = "Form2";
            this.Text = "Nouma Bank";
            this.msBank.ResumeLayout(false);
            this.msBank.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip msBank;
        private System.Windows.Forms.ToolStripMenuItem profileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem depositToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem widthrawToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem paymentInvoiceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem contactToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logOutToolStripMenuItem;
    }
}