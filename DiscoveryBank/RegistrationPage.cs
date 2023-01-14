using Core.Abstractions;
using Core.Helper;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace DiscoveryBankUi
{
    public partial class RegistrationPage : Form
    {
        private IAutheticationServices authetication;
        private IUserService userService;
        private ICustomerService customerService;
        private IAccountService accountServices;
        private ITransactionService transactionService;
        private IFileWriteRead readwrite;

        public RegistrationPage(IAutheticationServices autheticationServices, IUserService userService, ICustomerService customerService, IAccountService accountService, ITransactionService transactionService, IFileWriteRead readwrite)
        {
            InitializeComponent();
            this.authetication = autheticationServices;
            this.userService = userService;
            this.customerService = customerService;
            accountServices = accountService;
            this.transactionService = transactionService;
            this.readwrite = readwrite;
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void RegistrationPage_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string fname = Customer_fname_txt.Text;
            string lname = Customer_lname_txt.Text;
            if (!Validators.ValidateName(fname) && !Validators.ValidateName(lname))

            {
                MessageBox.Show("Please Check Your Name Format");
            }
            else
            {
                List<string> costumerDits = new List<string>();
                costumerDits.Add(fname);
                costumerDits.Add(lname);
                costumerDits.Add(Customer_Phone_txt.Text);


                //collecting costumer account information
                string acctype = "";
                bool isChecked = current_acc_rtn.Checked;
                if (isChecked)
                    acctype = current_acc_rtn.Text;
                else
                    acctype = saving_acc_rtn.Text;
                //string initamount = Customer_initamount_txt.Text;
                string initamount = "";
                //registering costumer details
                string costid = customerService.addNewCustomer(costumerDits);
                if (costid != "ERROR:")
                {
                    if (accountServices.CreateNewAccount(costid, initamount, acctype))
                    {

                        string costumerdata = customerService.GetCustomerDetails(costid);
                        string costEmail = costumerdata.Split(",")[3];
                        authetication.SetLog(costEmail);

                        MessageBox.Show("Congratulations Your Account Has Been Opened Click On OK! To Go To Your Dashboard ");
                        // Transactions newdash = new Transactions(authetication,validators,customerService,accountServices);
                        Transactions newdash = new Transactions(authetication,userService, customerService, accountServices, transactionService, readwrite);
                        newdash.Show();
                        this.Hide();
                    }
                }
            }


        }

        private void RegHomePageBack_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (MessageBox.Show("Are You Sure You Want To Abort Account Creation?....", "And Go To Home", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Hide();
                LogInBtn home = new LogInBtn(authetication,  userService, customerService, accountServices, readwrite, transactionService);
                home.Show();
            }
        }
    }
}
