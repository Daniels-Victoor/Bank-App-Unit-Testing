using Core.Helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace DiscoveryBankTests
{
    public class ValidatorsTest
    {
        [Fact]
        public void ValidateNameTest()
        {
            //arrange
            bool actual = Validators.ValidateName("Best");
            bool actul2 = Validators.ValidateName("best");

            //act
            bool expected = true;
            bool expected2 = false;

            //assert
            Assert.Equal(expected, actual);
            Assert.Equal(expected2, actul2);
        }
        [Fact]
        public void ValidateEmailTest()
        {
            //arrange
            bool actual = Validators.ValidateEmail("ogbeidebest.ob@gmail.com");
            bool actual2 = Validators.ValidateEmail("Bset232");

            //act
            bool expected = true;
            bool expected2 = false;

            //assert
            Assert.Equal(expected, actual);
            Assert.Equal(expected2, actual2);
        }

        [Fact]
        public void ValidatePasswordTest()
        {
            //arrange
            bool actual = Validators.ValidatePassword("pass12@");
            bool actual2 = Validators.ValidatePassword("password123");

            //act
            bool expected = true;
            bool expected2 = false;

            //assert
            Assert.Equal(expected, actual);
            Assert.Equal(expected2, actual2);
        }
      
      
    }
}
