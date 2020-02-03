using Microsoft.VisualStudio.TestTools.UnitTesting;
using MyProject;

namespace UnitTestProject1
{
    [TestClass]
    public class CalculateGcdTest
    {
        [TestMethod]
        public void calculateGcd_should_throw_exception_for_boundary_values()
        {
            //arrange
            CalculateGcd calculate = new CalculateGcd();
            int a = 0;
            int b = 0;
            //act            
            //assert
            Assert.ThrowsException<System.ArgumentException>(() => calculate.GetGcd(a, b));
        }

        [TestMethod]
        public void calculateGcd_should_throw_exception_for_negative_values()
        {
            //arrange
            CalculateGcd calculate = new CalculateGcd();
            int a = 10;
            int b = -10;
            //act            
            //assert
            Assert.ThrowsException<System.ArgumentException>(() => calculate.GetGcd(a, b));
        }

        [TestMethod]
        public void calculateGcd_should_return_correct_value_when_first_value_higher()
        {
            //arrange
            CalculateGcd calculate = new CalculateGcd();
            int a = 36;
            int b = 12;
            float expected = 12;
            //act 
            float actual = calculate.GetGcd(a, b);
            //assert
            Assert.AreEqual(expected, actual, "is not equal");
        }

        [TestMethod]
        public void calculateGcd_should_return_correct_value_when_second_value_higher()
        {
            //arrange
            CalculateGcd calculate = new CalculateGcd();
            int a = 12;
            int b = 36;
            float expected = 12;
            //act 
            float actual = calculate.GetGcd(a, b);
            //assert
            Assert.AreEqual(expected, actual, "is not equal");
        }
    }
}
