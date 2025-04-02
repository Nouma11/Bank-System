namespace Bank_System
{
    partial class Facture
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Facture));
            this.label1 = new System.Windows.Forms.Label();
            this.spcPay = new System.Windows.Forms.SplitContainer();
            this.label3 = new System.Windows.Forms.Label();
            this.rdOreedoo = new System.Windows.Forms.RadioButton();
            this.rdTelecome = new System.Windows.Forms.RadioButton();
            this.rdOrange = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.txtCode = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.spcPay)).BeginInit();
            this.spcPay.Panel1.SuspendLayout();
            this.spcPay.Panel2.SuspendLayout();
            this.spcPay.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(290, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(177, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "Pay Facture";
            // 
            // spcPay
            // 
            this.spcPay.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.spcPay.Location = new System.Drawing.Point(63, 130);
            this.spcPay.Name = "spcPay";
            // 
            // spcPay.Panel1
            // 
            this.spcPay.Panel1.Controls.Add(this.label3);
            this.spcPay.Panel1.Controls.Add(this.rdOreedoo);
            this.spcPay.Panel1.Controls.Add(this.rdTelecome);
            this.spcPay.Panel1.Controls.Add(this.rdOrange);
            // 
            // spcPay.Panel2
            // 
            this.spcPay.Panel2.Controls.Add(this.label4);
            this.spcPay.Panel2.Controls.Add(this.label2);
            this.spcPay.Panel2.Controls.Add(this.btnConfirm);
            this.spcPay.Panel2.Controls.Add(this.txtCode);
            this.spcPay.Size = new System.Drawing.Size(577, 293);
            this.spcPay.SplitterDistance = 191;
            this.spcPay.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(20, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(145, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Chose Company";
            // 
            // rdOreedoo
            // 
            this.rdOreedoo.AutoSize = true;
            this.rdOreedoo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdOreedoo.Location = new System.Drawing.Point(23, 213);
            this.rdOreedoo.Name = "rdOreedoo";
            this.rdOreedoo.Size = new System.Drawing.Size(101, 24);
            this.rdOreedoo.TabIndex = 2;
            this.rdOreedoo.TabStop = true;
            this.rdOreedoo.Tag = "Oreedoo";
            this.rdOreedoo.Text = "Oreedoo";
            this.rdOreedoo.UseVisualStyleBackColor = true;
            // 
            // rdTelecome
            // 
            this.rdTelecome.AutoSize = true;
            this.rdTelecome.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdTelecome.Location = new System.Drawing.Point(24, 147);
            this.rdTelecome.Name = "rdTelecome";
            this.rdTelecome.Size = new System.Drawing.Size(111, 24);
            this.rdTelecome.TabIndex = 1;
            this.rdTelecome.TabStop = true;
            this.rdTelecome.Tag = "Telecome";
            this.rdTelecome.Text = "Telecome";
            this.rdTelecome.UseVisualStyleBackColor = true;
            // 
            // rdOrange
            // 
            this.rdOrange.AutoSize = true;
            this.rdOrange.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdOrange.Location = new System.Drawing.Point(23, 83);
            this.rdOrange.Name = "rdOrange";
            this.rdOrange.Size = new System.Drawing.Size(91, 24);
            this.rdOrange.TabIndex = 0;
            this.rdOrange.TabStop = true;
            this.rdOrange.Tag = "Orange";
            this.rdOrange.Text = "Orange";
            this.rdOrange.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(53, 254);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(243, 18);
            this.label4.TabIndex = 5;
            this.label4.Text = "!! Code Format  ### - ### - ###";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(87, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(170, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Put Fature Code";
            // 
            // btnConfirm
            // 
            this.btnConfirm.Location = new System.Drawing.Point(84, 164);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(173, 45);
            this.btnConfirm.TabIndex = 4;
            this.btnConfirm.Text = "Confirm";
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.UseWaitCursor = true;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // txtCode
            // 
            this.txtCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCode.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.txtCode.Location = new System.Drawing.Point(23, 99);
            this.txtCode.Name = "txtCode";
            this.txtCode.Size = new System.Drawing.Size(302, 30);
            this.txtCode.TabIndex = 0;
            this.txtCode.Text = "### - ### - ###";
            this.txtCode.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtCode.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtCode_MouseClick);
            // 
            // Facture
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Moccasin;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.spcPay);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Facture";
            this.Text = "Facture";
            this.spcPay.Panel1.ResumeLayout(false);
            this.spcPay.Panel1.PerformLayout();
            this.spcPay.Panel2.ResumeLayout(false);
            this.spcPay.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spcPay)).EndInit();
            this.spcPay.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.SplitContainer spcPay;
        private System.Windows.Forms.RadioButton rdOreedoo;
        private System.Windows.Forms.RadioButton rdTelecome;
        private System.Windows.Forms.RadioButton rdOrange;
        private System.Windows.Forms.TextBox txtCode;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
    }
}