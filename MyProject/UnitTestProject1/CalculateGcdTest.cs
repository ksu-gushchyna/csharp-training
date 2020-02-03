using Microsoft.VisualStudio.TestTools.UnitTesting;
using MyProject;

namespace UnitTestProject1
{
    [TestClass]
    public class CalculateGcdTest
    {
        [TestMethod]
        public void TestMethod1()
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
        public void calculateGcd_should_return_correct_value()
        {
            //arrange
            CalculateGcd calculate = new CalculateGcd();
            int a = 1;
            int b = 100;
            float expected = 1;
            //act 
            float actual = calculate.GetGcd(a, b);
            //assert
            Assert.AreEqual(expected, actual, "is not equal");
        }
    }


}
