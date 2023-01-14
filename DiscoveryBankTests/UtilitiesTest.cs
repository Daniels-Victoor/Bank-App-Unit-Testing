using Core.Helper;
using System;
using Xunit;

namespace DiscoveryBankTests
{
    public class UtilitiesTest
    {

        [Fact]
        public void UtilitiesTests()
        {
           
            var actual = Utilities.GenerateRandomNumber(7, "001").Length;
            var expected = 10;
            Assert.Equal(expected, actual);

            string initial = Utilities.GenerateRandomNumber(7, "001");
            //double put;
            var actual2 = double.TryParse(initial, out double put);

            bool expected2 = true;
            Assert.Equal(expected2, actual2);

        }


        [Fact]
        public void GenerateCustomerIdTest()
        {
            var actual = Utilities.GenerateCustomerId().Length;
            var expected = 7;
            Assert.Equal(expected, actual);

            string initial = Utilities.GenerateCustomerId();
            double put;
            var actual2 = double.TryParse(initial, out put);

            bool expected2 = false;
            Assert.Equal(expected2, actual2);
        }



        [Fact]
        public void RemoveDigitsTest()
        {
            var actual = Utilities.RemoveDigits("Best9");
            var actual2 = Utilities.RemoveDigits("_Best");
            var expected = "Best";
            Assert.Equal(expected,actual);
            Assert.Equal(expected, actual2);
        }

        [Fact]
        public void ChangeToTitleTest()
        {
            var actual = Utilities.ChangeToTitle("best");
            var expected = "Best";
            Assert.Equal(expected, actual);
        }
    }
}
