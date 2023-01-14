using Core.Abstractions;
using Core.Helper;
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
    public class UserServiceTest
    {
        private Mock<IFileWriteRead> _fileWriteRead = new Mock<IFileWriteRead>();
        private Mock<IAutheticationServices> autService = new Mock<IAutheticationServices>();

        private readonly IUserService user;

        public UserServiceTest()
        {
            user = new UserService(autService.Object, _fileWriteRead.Object);
        }


        public List<string> data = new List<string>()
            {
                "alx120,omo@gmail.com,pass12@",
               "alx210,dolly@gmail.com,pass12@"
            };


        [Fact]
        public void GenerateUserIdTest()
        {
            var actual =user.GenerateUserId().Length;
            var expected = 6;
            Assert.Equal(expected, actual);


            string initial = Utilities.GenerateCustomerId();
           
            var actual2 = double.TryParse(initial, out double put);

            bool expected2 = false;
            Assert.Equal(expected2, actual2);
        }

       
        [Fact]
        public void RegisterUserTest()
        {
            _fileWriteRead.Setup(x => x.ReadFile(Files.UserLogin)).Returns(data);

            var actual = user.RegisterUser("", "pass12@");
            var expected = "The email format is Invalid, please enter a valid email";
          



            autService.Setup(x => x.EmailExist("omo@gmail.com")).Returns(true);
            var actual2= user.RegisterUser("omo@gmail.com", "pass12@");
            var expected2 = "This email has already been registered please try using a different emial address";



            var actual3 = user.RegisterUser("mike@gmail.com", "bola12@");
            var expected3 = "OK";



            Assert.Equal(expected, actual);
            Assert.Equal(expected2, actual2);
            Assert.Equal(expected3, actual3);   
        }
      
    }
}
