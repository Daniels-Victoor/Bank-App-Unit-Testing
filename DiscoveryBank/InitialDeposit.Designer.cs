namespace DiscoveryBankUi
{
    partial class InitialDeposit
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
            this.label4 = new System.Windows.Forms.Label();
            this.add_acc_init_amt_txt = new System.Windows.Forms.TextBox();
            this.deposit_btn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(44)))), ((int)(((byte)(93)))));
            this.label4.Location = new System.Drawing.Point(120, 23);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(156, 15);
            this.label4.TabIndex = 18;
            this.label4.Text = "Enter Initial Deposit Amount";
            // 
            // add_acc_init_amt_txt
            // 
            this.add_acc_init_amt_txt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.add_acc_init_amt_txt.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.add_acc_init_amt_txt.Location = new System.Drawing.Point(78, 62);
            this.add_acc_init_amt_txt.Margin = new System.Windows.Forms.Padding(2);
            this.add_acc_init_amt_txt.Name = "add_acc_init_amt_txt";
            this.add_acc_init_amt_txt.Size = new System.Drawing.Size(257, 25);
            this.add_acc_init_amt_txt.TabIndex = 19;
            // 
            // deposit_btn
            // 
            this.deposit_btn.BackColor = System.Drawing.Color.White;
            this.deposit_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.deposit_btn.Font = new System.Drawing.Font("Perpetua Titling MT", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.deposit_btn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(44)))), ((int)(((byte)(93)))));
            this.deposit_btn.Location = new System.Drawing.Point(142, 109);
            this.deposit_btn.Margin = new System.Windows.Forms.Padding(2);
            this.deposit_btn.Name = "deposit_btn";
            this.deposit_btn.Size = new System.Drawing.Size(112, 28);
            this.deposit_btn.TabIndex = 20;
            this.deposit_btn.Text = "Deposit";
            this.deposit_btn.UseVisualStyleBackColor = false;
            this.deposit_btn.Click += new System.EventHandler(this.deposit_btn_Click);
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(412, 158);
            this.panel1.TabIndex = 21;
            // 
            // InitialDeposit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(412, 158);
            this.Controls.Add(this.deposit_btn);
            this.Controls.Add(this.add_acc_init_amt_txt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panel1);
            this.Name = "InitialDeposit";
            this.Text = "InitialDeposit";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox add_acc_init_amt_txt;
        private System.Windows.Forms.Button deposit_btn;
        private System.Windows.Forms.Panel panel1;
    }
}