using Core.Abstractions;
using Models;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace DiscoveryBankUi
{
    public partial class InitialDeposit : Form
    {
        private IFileWriteRead readwrite;
        private IAccountService accountService;
        public InitialDeposit(IFileWriteRead readwrite, IAccountService accountService)
        {
            InitializeComponent();
            this.readwrite = readwrite;
            this.accountService = accountService;
        }

        private void deposit_btn_Click(object sender, EventArgs e)
        {
            //setting variables
            List<string> data = new List<string>();
            string path = Files.LoginSessionPath;
            string custId = "";
            // string acctId = "";
            string initailAmount = add_acc_init_amt_txt.Text;

            // getting login user data
            data = readwrite.ReadFile(path);

            foreach (var item in data)
            {
                custId = item.Split(",")[0];
            }

            //getting setting account type
            data = accountService.GetAccountById(custId);
            string accType = "";
            foreach (var item in data)
            {
                accType = item.Split(",")[5];
            }
            if (accType == "Saving Account")
            {
                accType = "Current Account";
            }
            else
            {
                accType = "Saving Account";
            }

            //creating a new account
            if (MessageBox.Show($"Confirm The Opening of {accType} with sum {initailAmount}", "Deposit Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (accountService.CreateNewAccount(custId, initailAmount, accType))
                {
                    MessageBox.Show("Was created Successfully Login Again to see newly created account");
                    this.Hide();
                }
            }



        }
    }
}
