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
    public class AuthenticationTest

    {

        public Mock<IFileWriteRead> _fileWriteRead = new Mock<IFileWriteRead>();
        public Mock<ICustomerService> _customerService= new Mock<ICustomerService>();
        public Mock<IAutheticationServices> _authentication = new Mock<IAutheticationServices>();


        private readonly IAutheticationServices aut;

        public AuthenticationTest()
        {
            aut = new AutheticationServices(_fileWriteRead.Object, _customerService.Object);
        }

        public List<string> data = new List<string>()
            {
                "alx120,omo@gmail.com,pass12@",
               "alx210,dolly@gmail.com,pass12@"
            };

        public List<string> data2 = new List<string>()
            {
               "CAZ3131,Jugde,Great,jugde@gmail.com,09087654,,",
                "CAZ3131,Jugde,Great,jugde@gmail.com,09087654,,",
                "CAZ0212,Besr,Ogbe,bestr@gmail.clom,o09099,,"

            };

        [Theory]
        [InlineData("omo@gmail.com","pass12@", true)]
        [InlineData("pass12@", "omo@gmail.com", false)]
        public void AuthLogInCredentailTest(string actual, string actual1,bool expected)
        
        {
            _fileWriteRead.Setup(x => x.ReadFile(Files.UserLogin)).Returns(data);

            var actual2 = aut.AuthLogInCredentails(actual, actual1);
          
            Assert.Equal(expected, actual2);

        }

        [Theory]
        [InlineData("best@gmail.com", "pass12@", "OK")]
        [InlineData("best@gmail.com", "", "The Password Field Is Empty Check And Try Again")]
        [InlineData("", "best", "The Email Field Is Empty Check And Try Again")]
        public void CheckIfEmpty(string actual1, string actual2, string expected)
        {
       
            var  actual =  aut.checkEmpty(actual1, actual2);
        
          
            Assert.Equal(expected, actual);
     
        }

        [Theory]
        [InlineData("omo@gmail.com", "pass12@", "OK")]
        [InlineData("best@gmail.com", "pass12@", "Incorrect login details")]
        [InlineData("best", "pass12@", "The E-mail is Invalid Please Use A Valid E-mail")]
        [InlineData("best@gmail.com", "", "The Password Field Is Empty Check And Try Again")]
        public void LoginTest(string actual1, string actual2, string expected)
        {

           _fileWriteRead.Setup(x => x.ReadFile(Files.UserLogin)).Returns(data);



            var actual = aut.LogIn( actual1, actual2);
           


            Assert.Equal(expected,actual);
          
        }

        [Theory]
        [InlineData("alx120", true)]
        [InlineData("best", false)]
        public void EmailExistTest(string actual1, bool expected)
        {
            
            _fileWriteRead.Setup(x => x.ReadFile(Files.UserLogin)).Returns(data);

            var actual = aut.EmailExist(actual1);
           


            Assert.Equal(expected, actual);
       
        }

        [Fact]
        public void GetLoginUserByIdTest()
        {

           _fileWriteRead.Setup(x => x.ReadFile(Files.LoginSessionPath)).Returns(data);

            var actual = aut.GetLoginUserById();


            Assert.NotNull(actual);
        }


    
    }
}
