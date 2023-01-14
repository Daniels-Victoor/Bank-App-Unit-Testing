using Core.Abstractions;
using Core.Helper;
using System;
using System.Windows.Forms;

namespace DiscoveryBankUi
{
    public partial class RegisterAsAUser : Form
    {
        private IAutheticationServices authetication;
       
        private IUserService userService;
        private ICustomerService customerService;
        private IAccountService accountService;
        private IFileWriteRead readwrite;
        private ITransactionService transactionService;
        public RegisterAsAUser(IAutheticationServices authetication,  IUserService userService, ICustomerService customerService, IAccountService accountService, IFileWriteRead readwrite, ITransactionService transactionService)
        {
            InitializeComponent();
            this.authetication = authetication;
            this.userService = userService;
            this.customerService = customerService;
            this.accountService = accountService;
            this.readwrite = readwrite;
            this.transactionService = transactionService;
        }

        private void RegisterAsAUser_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string loginemail = RegAUserEmailTxt.Text;
            string loginpassword = RegAUserPasswordTxt.Text;


            if (!Validators.ValidateEmail(loginemail) || !Validators.ValidatePassword(loginpassword))
            {
                MessageBox.Show("Please Enter a valid Email or Password");
            }
            else
            {

                string message = userService.RegisterUser(loginemail, loginpassword);

                if (message != "OK")
                {
                    MessageBox.Show(message);
                    RegAUserEmailTxt.Text = "";
                    RegAUserEmailTxt.Focus();
                }
                else
                {
                    this.Hide();
                    RegistrationPage custform = new RegistrationPage(authetication, userService, customerService, accountService, transactionService, readwrite);
                    custform.Show();
                }


            }




        }

        private void RegAUserPasswordTxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void backHomeRegLb_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (MessageBox.Show("Are You Sure You Want To Abort Account Creation?....", "And Go To Home", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Hide();
                LogInBtn home = new LogInBtn(authetication,  userService, customerService, accountService, readwrite, transactionService);
                home.Show();

            }
        }
    }
}
