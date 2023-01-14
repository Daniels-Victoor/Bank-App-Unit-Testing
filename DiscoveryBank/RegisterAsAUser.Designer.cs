namespace DiscoveryBankUi
{
    partial class RegisterAsAUser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegisterAsAUser));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.backHomeRegLb = new System.Windows.Forms.LinkLabel();
            this.RegAUserEmailTxt = new System.Windows.Forms.TextBox();
            this.RegAUserPasswordTxt = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(225, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(194, 76);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Rockwell", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.DarkRed;
            this.label1.Location = new System.Drawing.Point(157, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(383, 36);
            this.label1.TabIndex = 1;
            this.label1.Text = "Set Up Your Log In Details";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Rockwell Nova", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.DarkRed;
            this.label2.Location = new System.Drawing.Point(104, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(145, 22);
            this.label2.TabIndex = 2;
            this.label2.Text = "Enter Your Email";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Rockwell Nova", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.DarkRed;
            this.label3.Location = new System.Drawing.Point(104, 176);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(188, 22);
            this.label3.TabIndex = 3;
            this.label3.Text = "Create Your Password";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Rockwell Nova Cond", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.ForeColor = System.Drawing.Color.DarkRed;
            this.button1.Location = new System.Drawing.Point(174, 269);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(127, 35);
            this.button1.TabIndex = 4;
            this.button1.Text = "PROCEED";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // backHomeRegLb
            // 
            this.backHomeRegLb.ActiveLinkColor = System.Drawing.Color.DarkRed;
            this.backHomeRegLb.AutoSize = true;
            this.backHomeRegLb.Font = new System.Drawing.Font("Rockwell Nova", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.backHomeRegLb.LinkColor = System.Drawing.Color.Red;
            this.backHomeRegLb.Location = new System.Drawing.Point(451, 307);
            this.backHomeRegLb.Name = "backHomeRegLb";
            this.backHomeRegLb.Size = new System.Drawing.Size(127, 22);
            this.backHomeRegLb.TabIndex = 5;
            this.backHomeRegLb.TabStop = true;
            this.backHomeRegLb.Text = "Go Back Home";
            this.backHomeRegLb.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.backHomeRegLb_LinkClicked);
            // 
            // RegAUserEmailTxt
            // 
            this.RegAUserEmailTxt.Location = new System.Drawing.Point(144, 139);
            this.RegAUserEmailTxt.Name = "RegAUserEmailTxt";
            this.RegAUserEmailTxt.Size = new System.Drawing.Size(396, 23);
            this.RegAUserEmailTxt.TabIndex = 6;
            // 
            // RegAUserPasswordTxt
            // 
            this.RegAUserPasswordTxt.Location = new System.Drawing.Point(144, 210);
            this.RegAUserPasswordTxt.Name = "RegAUserPasswordTxt";
            this.RegAUserPasswordTxt.Size = new System.Drawing.Size(396, 23);
            this.RegAUserPasswordTxt.TabIndex = 7;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(616, 76);
            this.panel1.TabIndex = 8;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.backHomeRegLb);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.RegAUserPasswordTxt);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.RegAUserEmailTxt);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 76);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(616, 359);
            this.panel2.TabIndex = 9;
            // 
            // RegisterAsAUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(616, 435);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "RegisterAsAUser";
            this.Text = "RegisterAsAUser";
            this.Load += new System.EventHandler(this.RegisterAsAUser_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.LinkLabel backHomeRegLb;
        private System.Windows.Forms.TextBox RegAUserEmailTxt;
        private System.Windows.Forms.TextBox RegAUserPasswordTxt;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
    }
}