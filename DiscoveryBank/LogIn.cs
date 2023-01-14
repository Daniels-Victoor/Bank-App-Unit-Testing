using Core.Abstractions;
using System;
using System.Windows.Forms;

namespace DiscoveryBankUi
{
    public partial class LogInBtn : Form
    {
        private IAutheticationServices authetication;
   
        private IUserService userService;
        private ICustomerService customerService;
        private IAccountService accountService;
        private ITransactionService transactionService;
        private IFileWriteRead readwrite;
        public LogInBtn(IAutheticationServices autheticationServices, IUserService userService, ICustomerService customerService, IAccountService accountService, IFileWriteRead readwrite, ITransactionService transactionService)
        {
            InitializeComponent();
            authetication = autheticationServices;
            this.userService = userService;
            this.customerService = customerService;
            this.accountService = accountService;
            this.readwrite = readwrite;
            this.transactionService = transactionService;
        }

        private void LoginInEmailTxt_TextChanged(object sender, EventArgs e)
        {

        }

        //to log in from the login page
        private void BtnLog_Click(object sender, EventArgs e)
        {
            string LogInEmail = LoginInEmailTxt.Text;
            string LoginPassword = LoginPasswordTxt.Text;

            string logInMethod = authetication.LogIn(LogInEmail, LoginPassword);
            if (logInMethod != "OK")
            {
                MessageBox.Show(logInMethod);
            }
            else
            {
                authetication.SetLog(LogInEmail);
                Transactions trans = new Transactions(authetication, userService, customerService, accountService, transactionService, readwrite);
                trans.Show();
                LogInBtn home = new LogInBtn(authetication, userService, customerService, accountService, readwrite, transactionService);
                home.Hide();
            }
        }

        private void RegANewAccLinkText_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            RegisterAsAUser createAUser = new RegisterAsAUser(authetication, userService, customerService, accountService, readwrite, transactionService);
            createAUser.Show();

        }
    }
}
