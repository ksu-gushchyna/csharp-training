using Microsoft.VisualStudio.TestTools.UnitTesting;
using MyProject;

namespace UnitTestProject1
{
    [TestClass]
    public class SummOfNumbTest
    {
        [TestMethod]
        public void summOfNumb_happy_pass()
        {
            //arrange
            SummOfNumb summ = new SummOfNumb();
            int inputNumber = 12345;
            int expected = 15;
            //act 
            int actual = summ.GetSumm(inputNumber);
            //assert
            Assert.AreEqual(expected, actual, $"summ of {inputNumber} numbers is not equal to {expected}");
        }

        [TestMethod]
        public void summOfNumb_negative_pass()
        {
            //arrange
            SummOfNumb summ = new SummOfNumb();
            int inputNumber = 12345;
            int expected = 15;
            //act 
            int actual = summ.GetSumm(inputNumber);
            //assert
            Assert.AreEqual(expected, actual, $"summ of {inputNumber} numbers is not equal to {expected}");
        }
    }
}
