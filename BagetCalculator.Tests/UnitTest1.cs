using BagetCalculator;
using System;
using Xunit;

namespace BagetCalculator.Tests
{
    public class BagetPriceCalculatorTests
    {
        private readonly BagetPriceCalculator calculator;

        public BagetPriceCalculatorTests()
        {
            calculator = new BagetPriceCalculator();
        }

        [Fact]
        public void Calculate_SimpleCase_ReturnsCorrectCost()
        {
            decimal width = 40;
            decimal height = 50;
            string manufacturer = "Россия";
            string material = "Дерево";
            bool hasGlass = false;
            bool needsStretching = false;
            bool hasPaspartu = false;

            decimal cost = calculator.Calculate(width, height, manufacturer, material,
                                             hasGlass, needsStretching, hasPaspartu);

            Assert.Equal(900m, cost);
        }

        [Fact]
        public void Calculate_WithAllOptions_ReturnsCorrectCost()
        {
            decimal width = 60;
            decimal height = 80;
            string manufacturer = "Италия";
            string material = "Алюминий";
            bool hasGlass = true;
            bool needsStretching = true;
            bool hasPaspartu = true;
            decimal paspartuWidth = 10;

            decimal cost = calculator.Calculate(width, height, manufacturer, material,
                                             hasGlass, needsStretching, hasPaspartu, paspartuWidth);

            Assert.True(cost > 0);
        }

        [Fact]
        public void Calculate_InvalidSize_ThrowsException()
        {
            Assert.Throws<ArgumentException>(() =>
                calculator.Calculate(0, 50, "Россия", "Дерево", false, false, false));
        }

        [Fact]
        public void Calculate_InvalidManufacturer_ThrowsException()
        {
            Assert.Throws<ArgumentException>(() =>
                calculator.Calculate(40, 50, "Китай", "Дерево", false, false, false));
        }

        [Fact]
        public void GetManufacturers_ReturnsCorrectList()
        {
            var manufacturers = calculator.GetManufacturers();

            Assert.Equal(3, manufacturers.Count);
            Assert.Contains("Россия", manufacturers);
            Assert.Contains("Италия", manufacturers);
            Assert.Contains("Германия", manufacturers);
        }

        [Fact]
        public void GetMaterials_ForRussia_ReturnsCorrectList()
        {
            var materials = calculator.GetMaterials("Россия");

            Assert.Equal(3, materials.Count);
            Assert.Contains("Дерево", materials);
            Assert.Contains("Пластик", materials);
            Assert.Contains("Алюминий", materials);
        }
    }
}
