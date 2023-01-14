namespace DiscoveryBankUi
{
    partial class RegistrationPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegistrationPage));
            this.panel1 = new System.Windows.Forms.Panel();
            this.RegHomePageBack = new System.Windows.Forms.LinkLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.BtnCreateAcc = new System.Windows.Forms.Button();
            this.gender_gbx_txt = new System.Windows.Forms.GroupBox();
            this.current_acc_rtn = new System.Windows.Forms.RadioButton();
            this.saving_acc_rtn = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.Customer_Phone_txt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Customer_lname_txt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.Customer_fname_txt = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.gender_gbx_txt.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Honeydew;
            this.panel1.Controls.Add(this.RegHomePageBack);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(322, 449);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // RegHomePageBack
            // 
            this.RegHomePageBack.AutoSize = true;
            this.RegHomePageBack.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.RegHomePageBack.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.RegHomePageBack.Location = new System.Drawing.Point(90, 396);
            this.RegHomePageBack.Name = "RegHomePageBack";
            this.RegHomePageBack.Size = new System.Drawing.Size(156, 19);
            this.RegHomePageBack.TabIndex = 2;
            this.RegHomePageBack.TabStop = true;
            this.RegHomePageBack.Text = "GO TO HOMEPAGE";
            this.RegHomePageBack.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.RegHomePageBack_LinkClicked);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Rockwell Nova Cond", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(85, 173);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(167, 36);
            this.label1.TabIndex = 1;
            this.label1.Text = "DISCOVERY BANK";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(3, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(319, 221);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.BtnCreateAcc);
            this.panel2.Controls.Add(this.gender_gbx_txt);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.Customer_Phone_txt);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.Customer_lname_txt);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.Customer_fname_txt);
            this.panel2.Location = new System.Drawing.Point(327, 2);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(314, 449);
            this.panel2.TabIndex = 3;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint_1);
            // 
            // BtnCreateAcc
            // 
            this.BtnCreateAcc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(44)))), ((int)(((byte)(93)))));
            this.BtnCreateAcc.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnCreateAcc.Font = new System.Drawing.Font("Perpetua Titling MT", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnCreateAcc.ForeColor = System.Drawing.Color.White;
            this.BtnCreateAcc.Location = new System.Drawing.Point(55, 358);
            this.BtnCreateAcc.Margin = new System.Windows.Forms.Padding(2);
            this.BtnCreateAcc.Name = "BtnCreateAcc";
            this.BtnCreateAcc.Size = new System.Drawing.Size(191, 38);
            this.BtnCreateAcc.TabIndex = 24;
            this.BtnCreateAcc.Text = "Create Account";
            this.BtnCreateAcc.UseVisualStyleBackColor = false;
            this.BtnCreateAcc.Click += new System.EventHandler(this.button1_Click);
            // 
            // gender_gbx_txt
            // 
            this.gender_gbx_txt.Controls.Add(this.current_acc_rtn);
            this.gender_gbx_txt.Controls.Add(this.saving_acc_rtn);
            this.gender_gbx_txt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(44)))), ((int)(((byte)(93)))));
            this.gender_gbx_txt.Location = new System.Drawing.Point(17, 241);
            this.gender_gbx_txt.Margin = new System.Windows.Forms.Padding(2);
            this.gender_gbx_txt.Name = "gender_gbx_txt";
            this.gender_gbx_txt.Padding = new System.Windows.Forms.Padding(2);
            this.gender_gbx_txt.Size = new System.Drawing.Size(256, 68);
            this.gender_gbx_txt.TabIndex = 20;
            this.gender_gbx_txt.TabStop = false;
            this.gender_gbx_txt.Text = "Select Type Of Account";
            // 
            // current_acc_rtn
            // 
            this.current_acc_rtn.AutoSize = true;
            this.current_acc_rtn.Location = new System.Drawing.Point(3, 45);
            this.current_acc_rtn.Margin = new System.Windows.Forms.Padding(2);
            this.current_acc_rtn.Name = "current_acc_rtn";
            this.current_acc_rtn.Size = new System.Drawing.Size(108, 19);
            this.current_acc_rtn.TabIndex = 19;
            this.current_acc_rtn.Text = "Saving Account";
            this.current_acc_rtn.UseVisualStyleBackColor = true;
            // 
            // saving_acc_rtn
            // 
            this.saving_acc_rtn.AutoSize = true;
            this.saving_acc_rtn.Checked = true;
            this.saving_acc_rtn.Location = new System.Drawing.Point(3, 24);
            this.saving_acc_rtn.Margin = new System.Windows.Forms.Padding(2);
            this.saving_acc_rtn.Name = "saving_acc_rtn";
            this.saving_acc_rtn.Size = new System.Drawing.Size(113, 19);
            this.saving_acc_rtn.TabIndex = 18;
            this.saving_acc_rtn.TabStop = true;
            this.saving_acc_rtn.Text = "Current Account";
            this.saving_acc_rtn.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(44)))), ((int)(((byte)(93)))));
            this.label3.Location = new System.Drawing.Point(11, 147);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 15);
            this.label3.TabIndex = 15;
            this.label3.Text = "Phone No:";
            // 
            // Customer_Phone_txt
            // 
            this.Customer_Phone_txt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Customer_Phone_txt.Font = new System.Drawing.Font("Segoe UI Variable Display", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Customer_Phone_txt.Location = new System.Drawing.Point(10, 174);
            this.Customer_Phone_txt.Margin = new System.Windows.Forms.Padding(2);
            this.Customer_Phone_txt.Name = "Customer_Phone_txt";
            this.Customer_Phone_txt.Size = new System.Drawing.Size(257, 29);
            this.Customer_Phone_txt.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(44)))), ((int)(((byte)(93)))));
            this.label2.Location = new System.Drawing.Point(11, 96);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 15);
            this.label2.TabIndex = 13;
            this.label2.Text = "Last Name";
            // 
            // Customer_lname_txt
            // 
            this.Customer_lname_txt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Customer_lname_txt.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Customer_lname_txt.Location = new System.Drawing.Point(11, 117);
            this.Customer_lname_txt.Margin = new System.Windows.Forms.Padding(2);
            this.Customer_lname_txt.Name = "Customer_lname_txt";
            this.Customer_lname_txt.Size = new System.Drawing.Size(257, 25);
            this.Customer_lname_txt.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(44)))), ((int)(((byte)(93)))));
            this.label4.Location = new System.Drawing.Point(11, 50);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 15);
            this.label4.TabIndex = 11;
            this.label4.Text = "First Name";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Perpetua Titling MT", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(44)))), ((int)(((byte)(93)))));
            this.label7.Location = new System.Drawing.Point(55, 18);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(179, 15);
            this.label7.TabIndex = 8;
            this.label7.Text = "Account Opening Foam";
            // 
            // Customer_fname_txt
            // 
            this.Customer_fname_txt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Customer_fname_txt.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Customer_fname_txt.Location = new System.Drawing.Point(11, 67);
            this.Customer_fname_txt.Margin = new System.Windows.Forms.Padding(2);
            this.Customer_fname_txt.Name = "Customer_fname_txt";
            this.Customer_fname_txt.Size = new System.Drawing.Size(257, 25);
            this.Customer_fname_txt.TabIndex = 6;
            // 
            // RegistrationPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(637, 449);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "RegistrationPage";
            this.Text = "RegistrationPage";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.gender_gbx_txt.ResumeLayout(false);
            this.gender_gbx_txt.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.LinkLabel RegHomePageBack;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button BtnCreateAcc;
        private System.Windows.Forms.GroupBox gender_gbx_txt;
        private System.Windows.Forms.RadioButton current_acc_rtn;
        private System.Windows.Forms.RadioButton saving_acc_rtn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Customer_Phone_txt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Customer_lname_txt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox Customer_fname_txt;
    }
}