using Core.Abstractions;
using Models;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace DiscoveryBankUi
{
    public partial class Transactions : Form
    {
        private IAutheticationServices authetication;
        private IUserService userService;
        private ICustomerService customerService;
        private IAccountService accountService;
        private ITransactionService transactionService;
        private IFileWriteRead readwrite;


        public Transactions(IAutheticationServices autheticationServices, IUserService userService, ICustomerService customerService, IAccountService accountService, ITransactionService transactionService, IFileWriteRead readwrite)
        {
            InitializeComponent();
            authetication = autheticationServices;
            this.userService = userService;
            this.customerService = customerService;
            this.accountService = accountService;
            this.transactionService = transactionService;
            this.readwrite = readwrite;
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void depositBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (depositAmtTxt.Text == "")
                {
                    MessageBox.Show("Please  Enter an Amount You Want To Deposit To");
                    depositAmtTxt.Focus();
                }
                else if (depositamountTxt.Text == "0")
                {
                    MessageBox.Show("Please The Amount Is To Small To Make");
                    depositAmtTxt.Focus();
                }
                else if (AccNumTxt1.Text == "")
                {
                    MessageBox.Show("Please Enter the account number You Want To Deposit TO");
                    AccNumTxt1.Focus();
                }
                else if (DescTxt.Text == "")
                {
                    MessageBox.Show("Please Enter a Description");
                    DescTxt.Focus();
                }
                else
                {

                    string accNumber = AccNumTxt1.Text;
                    string accdetails = accountService.ConfirmAcc(accNumber);
                    if (accdetails != "")
                    {
                        if (MessageBox.Show($"Confirm Deposit of {depositAmtTxt.Text} to {accdetails}", "Deposit Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            string reciever = accNumber;
                            string amount = depositAmtTxt.Text;
                            string remark = DescTxt.Text;

                            if (transactionService.DepositToAccount(reciever, amount, remark))
                            {
                                MessageBox.Show("Deposit was Successful");
                                depositAmtTxt.Text = "";
                                AccNumTxt1.Text = "";
                                DescTxt.Text = "";
                                depositAmtTxt.Focus();
                            }

                        }
                    }
                    else
                    {
                        MessageBox.Show("Invalid Account number please check and correct it");
                        depositAmtTxt.Focus();
                    }


                }
            }
            catch (FormatException)
            {

                MessageBox.Show("Invalid Amount Format");
            }


        }

        private void button1_Click(object sender, EventArgs e)
        {
            InitialDeposit acf = new InitialDeposit(readwrite, accountService);
            acf.Show();

        }

        private void Transactions_Load(object sender, EventArgs e)
        {
            // getting user data to display
            List<string> data = new List<string>();
            string path = Files.LoginSessionPath;
            data = readwrite.ReadFile(path);
            string line = data[data.Count - 1];

            //setting user data for dashboard
            string id = line.Split(",")[0];
            string Firstname = line.Split(",")[1];
            string lastname = line.Split(",")[2];
            string email = line.Split(",")[3];
            string phonenumber = line.Split(",")[4];

            // displaying email
            userNameEmail.Text = "user: " + email;
            usernamedate.Text = DateTime.Now.ToString("f");

            try
            {
                //setting up name patch
                string initials1 = Firstname.Substring(0, 1);
                string initials2 = lastname.Substring(0, 1);
                labelin.Text = initials1 + initials2;
            }
            catch (ArgumentOutOfRangeException)
            {

                MessageBox.Show("LastName Not Entered");
            }

            //getting account details of costumer
            List<string> accdits = new List<string>();
            accdits = accountService.GetAccountById(id);
            if (accdits.Count == 2)
            {
                createaccbtn.Enabled = false;
            }
            //displaying account details
            acd.Text = Firstname + "!";

            foreach (var item in accdits)
            {
                //string acctype = item.Split(",")[3];
                if (item.Split(",")[5] == "Current Account")
                {
                    acd1.Text = item.Split(",")[5];
                    acd2.Text = item.Split(",")[4];
                }
                if (item.Split(",")[5] == "Saving Account")
                {
                    acd3.Text = item.Split(",")[5];
                    acd4.Text = item.Split(",")[4];
                }


            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void withrawBtn_Click(object sender, EventArgs e)
        {
            string acctype = withdrawal_acount_type.Text;
            string amount = withdrawal_amnt_txt.Text;
            string remark = DescriptionTxt.Text;

            string id = authetication.GetLoginUserById();

            if (withdrawal_acount_type.Text != "Saving Account" && withdrawal_acount_type.Text != "Current Account")
            {
                MessageBox.Show("Invalid Account type selection");
                withdrawal_acount_type.Focus();
            }
            else if (amount == "0") { MessageBox.Show("the amount is too small to withdraw"); withdrawal_amnt_txt.Focus(); }
            else if (amount == "") { MessageBox.Show("Please specify an amount"); withdrawal_amnt_txt.Focus(); }
            else if (remark == "") { MessageBox.Show("please enter a remark"); DescriptionTxt.Focus(); }
            else
            {
                //checking if user is over withdrawal limit

                decimal balance = accountService.CheckBalance(id, acctype);

                try
                {

                    decimal amountToWithdraw = decimal.Parse(amount);

                    if (amountToWithdraw > balance)
                    {
                        MessageBox.Show("Insufficient Balance");
                    }

                    if ((balance - amountToWithdraw) < 1000)
                    {
                        MessageBox.Show("Insufficient Balance the minimum balance is #1000");
                    }
                    else
                    {
                        amount = "-" + amount;
                        amountToWithdraw = decimal.Parse(amount);
                        if (transactionService.WithdrawFromAcc(id, amountToWithdraw, remark, acctype))
                        {
                            MessageBox.Show("withdrawal was successful");
                            withdrawal_amnt_txt.Text = "";
                            DescriptionTxt.Text = "";
                            withdrawal_acount_type.Text = "Select Account";


                        }
                    }
                }
                catch (FormatException)
                {

                    MessageBox.Show("Invalid Amount Format");
                }

               


            }
        }

        private void TrnferBtn_Click(object sender, EventArgs e)
        {
            //getting costumer id
            List<string> data = new List<string>();
            string path = Files.LoginSessionPath;
            data = readwrite.ReadFile(path);
            string line = data[data.Count - 1];
            string id = line.Split(",")[0];
            try
            {

                //verifying input
                if (comboBox2.Text != "Saving Account" && comboBox2.Text != "Current Account")
                { MessageBox.Show("Please select the account you want to transfer from"); }
                else if (TransferRecieveraccTxt.Text == "") { MessageBox.Show("please enter the receiver's account number"); TransferRecieveraccTxt.Focus(); }
                else if (TransferAmtTxt.Text == "") { MessageBox.Show("please enter the amount you want to transfer"); TransferAmtTxt.Focus(); }
                else if (TransferAmtTxt.Text == "0") { MessageBox.Show("The transfer amount is too small"); TransferAmtTxt.Focus(); }
                else if (TransferDesTxt.Text == "") { MessageBox.Show("please enter a narrative"); TransferDesTxt.Focus(); }


                //input is OK!
                else
                {
                    decimal balance = accountService.CheckBalance(id, comboBox2.Text);
                    decimal amountToTransfer = decimal.Parse(TransferAmtTxt.Text);
                    // restricting minimum balance
                    if (comboBox2.Text == "Saving Account" && (balance - amountToTransfer) <= 1000)
                    {
                        MessageBox.Show("Unable to transfer the minimum balance for savings account is 1000 Naira");
                        TransferAmtTxt.Focus();
                    }
                    else if (balance < amountToTransfer)
                    {
                        MessageBox.Show("Unable to transfer Insufficient Balance");
                        TransferAmtTxt.Focus();
                    }
                    else
                    {
                        if (MessageBox.Show($"Confirm the transfer of {TransferAmtTxt.Text} to {TransferRecieveraccTxt.Text}", "Transfer Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            string respond = transactionService.transfer(id, TransferRecieveraccTxt.Text, amountToTransfer, TransferDesTxt.Text, comboBox2.Text);
                            if (respond == "OK")
                            {
                                MessageBox.Show("Transfer was successful ");
                                comboBox2.Text = "";
                                TransferRecieveraccTxt.Text = "";
                                TransferAmtTxt.Text = "";
                                TransferDesTxt.Text = "";
                                comboBox2.Focus();
                            }
                            else
                            {
                                MessageBox.Show(respond);
                            }
                        }

                    }

                }
            }
            catch (FormatException)
            {

                MessageBox.Show("Invalid Amount Format");
            }
        }

        private void LogOutBtn_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show($"Are You Sure You Want to Logout", " Confirm Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                LogInBtn newhome = new LogInBtn(authetication, userService, customerService, accountService, readwrite, transactionService);
                this.Hide();
                newhome.Show();
            }
        }

        private void AccBalBtn_Click(object sender, EventArgs e)
        {
            List<string> data = new List<string>();
            string path = Files.LoginSessionPath;
            data = readwrite.ReadFile(path);
            string line = data[data.Count - 1];
            //getting logged in costumer email
            string id = line.Split(",")[0]; ;
            //showing balance
            decimal savingbalance = accountService.CheckBalance(id, "Saving Account");
            decimal currentbalance = accountService.CheckBalance(id, "Current Account");
            savingLb.Text = savingbalance.ToString();
            currentLb.Text = currentbalance.ToString();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            List<string> data = new List<string>();
            string path = Files.LoginSessionPath;
            data = readwrite.ReadFile(path);
            string line = data[data.Count - 1];
            string id = line.Split(",")[0];
            string accType = comboBox1.Text;

            data.Clear();
            data = transactionService.GetAccountStatement(id, accType);



            try
            {
                foreach (var item in data)
                {
                    listView1.Items.Add(new ListViewItem(new string[] { item.Split(",")[3].ToString(), item.Split(",")[2], item.Split(",")[4], item.Split(",")[1] }));
                }
            }
            catch (IndexOutOfRangeException)
            {

                MessageBox.Show("There Is No Record For Such Account");
            }
        }

        private void tabPage3_Click(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void withdrawal_acount_type_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
