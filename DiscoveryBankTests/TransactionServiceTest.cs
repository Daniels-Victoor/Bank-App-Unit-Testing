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
    public class TransactionServiceTest
    {
        private Mock<IFileWriteRead> _fileWriteRead = new Mock<IFileWriteRead>();
        private Mock<IAccountService> accountService = new Mock<IAccountService>();
        private Mock<ITransactionService> transactionService = new Mock<ITransactionService>();
        private readonly ITransactionService transaction;

        public TransactionServiceTest()
        {
            transaction = new TransactionService( _fileWriteRead.Object, accountService.Object);
        }

        public List<string> data = new List<string>()
           {
             
              "ACC122,CAZ3131,Jugde,Great,0012041336,Saving Account,30/07/2022 23:23:08,500,",
           
           };

        [Fact]
        public void GenerateUserIdTest()
        {
            var actual = transaction.GenerateTransactionId().Length;
            var expected = 8;
            Assert.Equal(expected, actual);

            string initial = transaction.GenerateTransactionId();
            double put;
            var actual2 = double.TryParse(initial, out put);

            bool expected2 = false;
            Assert.Equal(expected2, actual2);
        }


        [Fact]
        public void InitilaDepositTest()
        {
            var check = transaction.InitilaDeposit("799","509876543", "best", "900");
            Assert.True(check);
        }

        [Fact]
        public void DepositToAccountTest()
        {
            var check = transaction.DepositToAccount("809076543", "6000", "add money");
            Assert.True(check);
        }

        [Fact]
        public void withdrawCheckTest()
        {
            //Arrange
            accountService.Setup(x => x.GetAccountById("CAZ0311")).Returns(data);
            //Act

            var actual = transaction.WithdrawFromAcc("CAZ0311", 500, "thanks", "Saving Account");


            Assert.True(actual);
        }

        [Theory]
        [InlineData("CAZ3131", "0012041336", 700, "checked", "Saving Account", "The sender's and reciever's account are the same you can not transfer to the same account")]
        [InlineData("CAZ3131", "001041336",500, "checked", "Saving Account", "OK")]
       
        public void transferTest(string actual1, string actual2, decimal actual3, string actual4, string actual5,string expected )
        {
            _fileWriteRead.Setup(x => x.ReadFile(Files.accountPath)).Returns(data);

            //Arrange
            accountService.Setup(x => x.GetaccountByTypeandId(actual1, actual5)).Returns(actual2);
            accountService.Setup(x => x.GetAccountById(actual1)).Returns(data);
            transactionService.Setup(y => y.DepositToAccount(actual2, actual3.ToString(), actual4)).Returns(true);

            var actual = transaction.transfer("CAZ3131", "0012041336", 700, "checked", "Saving Account");

           Assert.Equal(expected, actual);

        }

    }
}
