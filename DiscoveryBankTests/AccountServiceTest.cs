using Core.Abstractions;
using Core.Implimentations;
using Models;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace DiscoveryBankTests
{
    public class AccountServiceTest
    {
        private Mock<IFileWriteRead> _fileWriteRead = new Mock<IFileWriteRead>();
        private Mock<ICustomerService> _customerService = new Mock<ICustomerService>();
        private Mock<IAccountService> _accountService = new Mock<IAccountService>();
        private readonly IAccountService accountService;

        public AccountServiceTest()
            {
                 accountService = new AccountService(_customerService.Object, _fileWriteRead.Object);
            }


        public List<string> data = new List<string>()

        { 
                  "ACC201,CAZ0311,Osadolor,Best,0014254633,Current Account,30/07/2022 12:59:22,,",
                  "ACC122,CAZ3131,Jugde,Great,0012041336,Saving Account,30/07/2022 23:23:08,500,",
                  "ACC011,CAZ0212,Besr,Ogbe,0013665413,Current Account,30/07/2022 23:41:47,,",
                  "ACC102,CAZ3010,Omo,First,0015533012,Current Account,30/07/2022 13:09:53,,"
        };

        public List<string> data2 = new List<string>()

        {
                " JHs1,0015533012,8000,30-07-2022,add money",
                "JHs2,0015533012,-700,30-07-2022,withdraw money",
                "JHs5,0016412536,2000,30-07-2022,transfer moeny",
                "JHs4,0015533012,-2000,30-07-2022,transfer moeny",
                "JHs2,0015003242,9000,30-07-2022,add money,"
        };

        [Fact]
        
        public void GenerateAccountIdTest()
        {
               var actual = accountService.GeneratesAccountId().Length;
               var expected = 6;
               Assert.Equal(expected, actual);

               string initial = accountService.GeneratesAccountId();
               //double put;
               var actual2 = double.TryParse(initial, out double put);

               bool expected2 = false;
               Assert.Equal(expected2, actual2);

        }

        [Fact]
        public void GenerateAccountNumberTest()
        {
     
            var actual = accountService.GenerateAccountNumber().Length;
            var expected = 10;
            Assert.Equal(expected, actual);

            string initial = accountService.GenerateAccountNumber();
            double put;
            var actual2 = double.TryParse(initial, out put);

            bool expected2 = true;
            Assert.Equal(expected2, actual2);
        }



        [Fact]
        
        public void GetAccountByIdTest()
        {
            _fileWriteRead.Setup(x => x.ReadFile(Files.accountPath)).Returns(data);

       
            var actual = accountService.GetAccountById("CAZ0311");
            var actual2 = accountService.GetAccountById("CAZ3131");
           


            var expected = new List<string> { "ACC201,CAZ0311,Osadolor,Best,0014254633,Current Account,30/07/2022 12:59:22,," };
            var expected2 = new List<string> { "ACC122,CAZ3131,Jugde,Great,0012041336,Saving Account,30/07/2022 23:23:08,500," } ;

            Assert.Equal(expected , actual);
            Assert.Equal(expected2, actual2);
        }


        [Theory]
        [InlineData("CAZ0311", "Current Account", "0014254633")]
        [InlineData("CAZ3131", "Saving Account", "0012041336")]
        [InlineData("CAZ3131", "Current Account", "")]
        public void GetAccountByIdAndTypeTest(string actual1, string actual2, string expected)
        {
            
            _fileWriteRead.Setup(x => x.ReadFile(Files.accountPath)).Returns(data);



            var actual = accountService.GetaccountByTypeandId(actual1, actual2);
        
            Assert.Equal(expected, actual);
        }


        [Theory]
        [InlineData("0014254633", "Osadolor,Best,0014254633")]
        [InlineData("001425463", "")]
        public void ConfirmAccTest(string act, string expected)
        {
            
            _fileWriteRead.Setup(x => x.ReadFile(Files.accountPath)).Returns(data);

            var actual = accountService.ConfirmAcc(act);
        
           
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void CheckBalanceTest()
        {

            _fileWriteRead.Setup(x => x.ReadFile(Files.accountPath)).Returns(data);
            _fileWriteRead.Setup(x => x.ReadFile(Files.TransactionPath)).Returns(data2);

            _accountService.Setup(y => y.GetaccountByTypeandId("CAZ3010", "Current Account")).Returns("0015533012");

             // var cust =
             var actual = accountService.CheckBalance("", "");
             var actual2 = accountService.CheckBalance("CAZ3010", "Current Account");

            var expected = 0;
            var expected2 = 5300;
            Assert.Equal(expected, actual);
           Assert.Equal(expected2, actual2);
        }


        [Fact]

        public void createNewAccountTest()
        {
            List<string> data3 = new List<string>()
            {
                "DOR66,Chinedu,Otuka,chineduotuka@gmail.com,08135130055,ajah"
            };

            
            _customerService.Setup(x => x.GetCustomerDetails("DOR66")).Returns("DOR66,Chinedu,Otuka,chineduotuka@gmail.com,08135130055,ajah");

           

            var actual = accountService.CreateNewAccount("DOR66", "200", "Current Account");

            Assert.True(actual);
        }
    }
}
