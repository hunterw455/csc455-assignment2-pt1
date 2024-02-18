using Microsoft.VisualStudio.TestTools.UnitTesting;
using LearnMyCalculatorApp;

namespace LearnMyCalculatorApp.Tests
{
    [TestClass]
    public class CalculatorTests
    {
        [TestMethod]
        public void CalculatorNullTest()
        {
            var calculator = new Calculator();
            Assert.IsNotNull(calculator);
        }
        
        [TestMethod]
        public void AddTest()
        {
            // Arrange
            var calculator = new Calculator();

            // Act
            var actual = calculator.Add(1, 1);

            // Assert
            Assert.AreEqual(2, actual);
        }
    }
}