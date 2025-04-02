namespace Bank_System
{
    partial class Deposit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Deposit));
            this.label1 = new System.Windows.Forms.Label();
            this.tbDeposit = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnConfirm1 = new System.Windows.Forms.Button();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label3 = new System.Windows.Forms.Label();
            this.btn500 = new System.Windows.Forms.Button();
            this.btn400 = new System.Windows.Forms.Button();
            this.btn300 = new System.Windows.Forms.Button();
            this.btn250 = new System.Windows.Forms.Button();
            this.btn200 = new System.Windows.Forms.Button();
            this.btn150 = new System.Windows.Forms.Button();
            this.btn100 = new System.Windows.Forms.Button();
            this.btn50 = new System.Windows.Forms.Button();
            this.btn40 = new System.Windows.Forms.Button();
            this.btn30 = new System.Windows.Forms.Button();
            this.btn20 = new System.Windows.Forms.Button();
            this.btn10 = new System.Windows.Forms.Button();
            this.tbDeposit.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(260, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(218, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Deposit Menue";
            // 
            // tbDeposit
            // 
            this.tbDeposit.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.tbDeposit.Controls.Add(this.tabPage1);
            this.tbDeposit.Controls.Add(this.tabPage2);
            this.tbDeposit.Font = new System.Drawing.Font("Constantia", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbDeposit.HotTrack = true;
            this.tbDeposit.Location = new System.Drawing.Point(42, 117);
            this.tbDeposit.Name = "tbDeposit";
            this.tbDeposit.SelectedIndex = 0;
            this.tbDeposit.Size = new System.Drawing.Size(693, 408);
            this.tbDeposit.TabIndex = 2;
            this.tbDeposit.UseWaitCursor = true;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnConfirm1);
            this.tabPage1.Controls.Add(this.txtAmount);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Location = new System.Drawing.Point(4, 33);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(685, 371);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Manual Deposit";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.UseWaitCursor = true;
            // 
            // btnConfirm1
            // 
            this.btnConfirm1.Location = new System.Drawing.Point(243, 229);
            this.btnConfirm1.Name = "btnConfirm1";
            this.btnConfirm1.Size = new System.Drawing.Size(173, 45);
            this.btnConfirm1.TabIndex = 3;
            this.btnConfirm1.Text = "Confirm";
            this.btnConfirm1.UseVisualStyleBackColor = true;
            this.btnConfirm1.UseWaitCursor = true;
            this.btnConfirm1.Click += new System.EventHandler(this.btnConfirm1_Click);
            // 
            // txtAmount
            // 
            this.txtAmount.Location = new System.Drawing.Point(161, 160);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(343, 28);
            this.txtAmount.TabIndex = 2;
            this.txtAmount.UseWaitCursor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(255, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(149, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "Fill Your Amount";
            this.label2.UseWaitCursor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.btn500);
            this.tabPage2.Controls.Add(this.btn400);
            this.tabPage2.Controls.Add(this.btn300);
            this.tabPage2.Controls.Add(this.btn250);
            this.tabPage2.Controls.Add(this.btn200);
            this.tabPage2.Controls.Add(this.btn150);
            this.tabPage2.Controls.Add(this.btn100);
            this.tabPage2.Controls.Add(this.btn50);
            this.tabPage2.Controls.Add(this.btn40);
            this.tabPage2.Controls.Add(this.btn30);
            this.tabPage2.Controls.Add(this.btn20);
            this.tabPage2.Controls.Add(this.btn10);
            this.tabPage2.Location = new System.Drawing.Point(4, 33);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(685, 371);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Automatic Deposit";
            this.tabPage2.UseVisualStyleBackColor = true;
            this.tabPage2.UseWaitCursor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(255, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(164, 21);
            this.label3.TabIndex = 12;
            this.label3.Text = "Chose The Amount";
            this.label3.UseWaitCursor = true;
            // 
            // btn500
            // 
            this.btn500.Location = new System.Drawing.Point(461, 275);
            this.btn500.Name = "btn500";
            this.btn500.Size = new System.Drawing.Size(84, 69);
            this.btn500.TabIndex = 11;
            this.btn500.Tag = "500";
            this.btn500.Text = "500 $";
            this.btn500.UseVisualStyleBackColor = true;
            this.btn500.UseWaitCursor = true;
            this.btn500.Click += new System.EventHandler(this.CommonButton_Click);
            // 
            // btn400
            // 
            this.btn400.Location = new System.Drawing.Point(339, 275);
            this.btn400.Name = "btn400";
            this.btn400.Size = new System.Drawing.Size(84, 69);
            this.btn400.TabIndex = 10;
            this.btn400.Tag = "400";
            this.btn400.Text = "400 $";
            this.btn400.UseVisualStyleBackColor = true;
            this.btn400.UseWaitCursor = true;
            this.btn400.Click += new System.EventHandler(this.CommonButton_Click);
            // 
            // btn300
            // 
            this.btn300.Location = new System.Drawing.Point(223, 275);
            this.btn300.Name = "btn300";
            this.btn300.Size = new System.Drawing.Size(84, 69);
            this.btn300.TabIndex = 9;
            this.btn300.Tag = "300";
            this.btn300.Text = "300 $";
            this.btn300.UseVisualStyleBackColor = true;
            this.btn300.UseWaitCursor = true;
            this.btn300.Click += new System.EventHandler(this.CommonButton_Click);
            // 
            // btn250
            // 
            this.btn250.Location = new System.Drawing.Point(113, 275);
            this.btn250.Name = "btn250";
            this.btn250.Size = new System.Drawing.Size(84, 69);
            this.btn250.TabIndex = 8;
            this.btn250.Tag = "250";
            this.btn250.Text = "250 $";
            this.btn250.UseVisualStyleBackColor = true;
            this.btn250.UseWaitCursor = true;
            this.btn250.Click += new System.EventHandler(this.CommonButton_Click);
            // 
            // btn200
            // 
            this.btn200.Location = new System.Drawing.Point(461, 181);
            this.btn200.Name = "btn200";
            this.btn200.Size = new System.Drawing.Size(84, 69);
            this.btn200.TabIndex = 7;
            this.btn200.Tag = "200";
            this.btn200.Text = "200 $";
            this.btn200.UseVisualStyleBackColor = true;
            this.btn200.UseWaitCursor = true;
            this.btn200.Click += new System.EventHandler(this.CommonButton_Click);
            // 
            // btn150
            // 
            this.btn150.Location = new System.Drawing.Point(339, 181);
            this.btn150.Name = "btn150";
            this.btn150.Size = new System.Drawing.Size(84, 69);
            this.btn150.TabIndex = 6;
            this.btn150.Tag = "150";
            this.btn150.Text = "150 $";
            this.btn150.UseVisualStyleBackColor = true;
            this.btn150.UseWaitCursor = true;
            this.btn150.Click += new System.EventHandler(this.CommonButton_Click);
            // 
            // btn100
            // 
            this.btn100.Location = new System.Drawing.Point(223, 181);
            this.btn100.Name = "btn100";
            this.btn100.Size = new System.Drawing.Size(84, 69);
            this.btn100.TabIndex = 5;
            this.btn100.Tag = "100";
            this.btn100.Text = "100 $";
            this.btn100.UseVisualStyleBackColor = true;
            this.btn100.UseWaitCursor = true;
            this.btn100.Click += new System.EventHandler(this.CommonButton_Click);
            // 
            // btn50
            // 
            this.btn50.Location = new System.Drawing.Point(113, 181);
            this.btn50.Name = "btn50";
            this.btn50.Size = new System.Drawing.Size(84, 69);
            this.btn50.TabIndex = 4;
            this.btn50.Tag = "50";
            this.btn50.Text = "50 $";
            this.btn50.UseWaitCursor = true;
            this.btn50.Click += new System.EventHandler(this.CommonButton_Click);
            // 
            // btn40
            // 
            this.btn40.Location = new System.Drawing.Point(461, 89);
            this.btn40.Name = "btn40";
            this.btn40.Size = new System.Drawing.Size(84, 69);
            this.btn40.TabIndex = 3;
            this.btn40.Tag = "40";
            this.btn40.Text = "40 $";
            this.btn40.UseVisualStyleBackColor = true;
            this.btn40.UseWaitCursor = true;
            this.btn40.Click += new System.EventHandler(this.CommonButton_Click);
            // 
            // btn30
            // 
            this.btn30.Location = new System.Drawing.Point(339, 89);
            this.btn30.Name = "btn30";
            this.btn30.Size = new System.Drawing.Size(84, 69);
            this.btn30.TabIndex = 2;
            this.btn30.Tag = "30";
            this.btn30.Text = "30 $";
            this.btn30.UseVisualStyleBackColor = true;
            this.btn30.UseWaitCursor = true;
            this.btn30.Click += new System.EventHandler(this.CommonButton_Click);
            // 
            // btn20
            // 
            this.btn20.Location = new System.Drawing.Point(223, 89);
            this.btn20.Name = "btn20";
            this.btn20.Size = new System.Drawing.Size(84, 69);
            this.btn20.TabIndex = 1;
            this.btn20.Tag = "20";
            this.btn20.Text = "20 $";
            this.btn20.UseVisualStyleBackColor = true;
            this.btn20.UseWaitCursor = true;
            this.btn20.Click += new System.EventHandler(this.CommonButton_Click);
            // 
            // btn10
            // 
            this.btn10.Location = new System.Drawing.Point(113, 89);
            this.btn10.Name = "btn10";
            this.btn10.Size = new System.Drawing.Size(84, 69);
            this.btn10.TabIndex = 0;
            this.btn10.Tag = "10";
            this.btn10.Text = "10 $";
            this.btn10.UseVisualStyleBackColor = true;
            this.btn10.UseWaitCursor = true;
            this.btn10.Click += new System.EventHandler(this.CommonButton_Click);
            // 
            // Deposit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Moccasin;
            this.ClientSize = new System.Drawing.Size(800, 576);
            this.Controls.Add(this.tbDeposit);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Deposit";
            this.Text = "Deposit";
            this.tbDeposit.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl tbDeposit;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnConfirm1;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn500;
        private System.Windows.Forms.Button btn400;
        private System.Windows.Forms.Button btn300;
        private System.Windows.Forms.Button btn250;
        private System.Windows.Forms.Button btn200;
        private System.Windows.Forms.Button btn150;
        private System.Windows.Forms.Button btn100;
        private System.Windows.Forms.Button btn50;
        private System.Windows.Forms.Button btn40;
        private System.Windows.Forms.Button btn30;
        private System.Windows.Forms.Button btn20;
        private System.Windows.Forms.Button btn10;
    }
}