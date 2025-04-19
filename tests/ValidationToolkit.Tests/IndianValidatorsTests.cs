using Xunit;
using ValidationToolkit.Validators;

namespace ValidationToolkit.Tests
{
    public class IndianValidatorsTests
    {
        [Theory]
        [InlineData("ABCDE1234F", true)]
        [InlineData("ABCDE1234", false)]
        [InlineData("abcde1234f", false)]
        public void TestPAN(string input, bool expected)
        {
            Assert.Equal(expected, IndianValidators.IsValidPAN(input));
        }

        [Theory]
        [InlineData("123456789012", true)]
        [InlineData("12345678901", false)]
        [InlineData("abcdefgh1234", false)]
        public void TestAadhar(string input, bool expected)
        {
            Assert.Equal(expected, IndianValidators.IsValidAadhar(input));
        }

        [Theory]
        [InlineData("9876543210", true)]
        [InlineData("1234567890", false)]
        [InlineData("987654321", false)]
        public void TestMobile(string input, bool expected)
        {
            Assert.Equal(expected, IndianValidators.IsValidIndianMobile(input));
        }
    }
}
