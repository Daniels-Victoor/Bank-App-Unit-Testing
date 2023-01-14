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
    public class CustomerServiceTest
    {

        private readonly Mock<IFileWriteRead> _fileWriteRead = new Mock<IFileWriteRead>();
      

        public CustomerServiceTest()
        {

        }

        public List<string> data = new List<string>()
           
            {
                 " CAZ0221,Dolly,Bolly,dolly@gmail.com,090923675,",
                    "CAZ3131,Jugde,Great,jugde@gmail.com,09087654,"
            };


        [Theory]
        [InlineData("dolly@gmail.com", " CAZ0221,Dolly,Bolly,dolly@gmail.com,090923675,")]
        [InlineData("dadyo@gmail.com", "")]

        public void CustomerByemailTest(string actual, string expected)
        {


            _fileWriteRead.Setup(x => x.ReadFile(Files.CustomerPath)).Returns(data);

            CustomerService customer = new CustomerService(_fileWriteRead.Object);

            //Act
            var actual1 = customer.getCostumerByEmail(actual);
            

            //Assert
            
            Assert.Equal(expected, actual1);
        }



        [Theory]
        [InlineData(" CAZ0221", " CAZ0221,Dolly,Bolly,dolly@gmail.com,090923675,")]
        [InlineData("Acc345", "")]
        public void GetCustomerDetailsTest(string actual1, string expected)
        {
            _fileWriteRead.Setup(x => x.ReadFile(Files.CustomerPath)).Returns(data);

            CustomerService customer = new CustomerService(_fileWriteRead.Object);

            var actual = customer.GetCustomerDetails(actual1);
           
            Assert.Equal(expected, actual);
       

        }

        [Fact]

        public void addNewCustomerTest()
        {
            _fileWriteRead.Setup(x => x.ReadFile(Files.CustomerPath)).Returns(data);

            CustomerService customer = new CustomerService(_fileWriteRead.Object);
        }
    }
}
