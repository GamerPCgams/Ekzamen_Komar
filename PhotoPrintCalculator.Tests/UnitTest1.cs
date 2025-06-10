using System;
using PhotoPrintCalculator;
using Xunit;

namespace PhotoPrintCalculator.Tests
{
    public class PhotoPrintCalculatorTests
    {
        private readonly PhotoPrintCalculator calculator;

        public PhotoPrintCalculatorTests()
        {
            calculator = new PhotoPrintCalculator();
        }

        [Theory]
        [InlineData("9x12", 5, 250)]
        [InlineData("12x15", 10, 800)]
        [InlineData("18x24", 3, 360)]
        public void CalculateOrderCost_ValidInput_ReturnsCorrectCost(string size, int quantity, decimal expected)
        {
            decimal result = calculator.CalculateOrderCost(size, quantity);

            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData("9x12", 25, 1125)] 
        [InlineData("12x15", 30, 2160)] 
        public void CalculateOrderCost_MoreThan20Photos_AppliesDiscount(string size, int quantity, decimal expected)
        {
            decimal result = calculator.CalculateOrderCost(size, quantity);

            Assert.Equal(expected, result);
        }

        [Fact]
        public void CalculateOrderCost_InvalidSize_ThrowsException()
        {
            string invalidSize = "10x15";

            Assert.Throws<ArgumentException>(() => calculator.CalculateOrderCost(invalidSize, 5));
        }

        [Fact]
        public void CalculateOrderCost_ZeroQuantity_ThrowsException()
        {
            Assert.Throws<ArgumentException>(() => calculator.CalculateOrderCost("9x12", 0));
        }

        [Fact]
        public void GetAvailableSizes_ReturnsCorrectSizes()
        {
            var sizes = calculator.GetAvailableSizes();

            Assert.Equal(3, sizes.Length);
            Assert.Contains("9x12", sizes);
            Assert.Contains("12x15", sizes);
            Assert.Contains("18x24", sizes);
        }

        [Theory]
        [InlineData("9x12", true)]
        [InlineData("12x15", true)]
        [InlineData("18x24", true)]
        [InlineData("10x15", false)]
        public void IsSizeAvailable_ChecksCorrectly(string size, bool expected)
        {
            bool result = calculator.IsSizeAvailable(size);

            Assert.Equal(expected, result);
        }
    }
}
