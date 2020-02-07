using Microsoft.VisualStudio.TestTools.UnitTesting;
using MyProject;

namespace UnitTestProject1
{
    [TestClass]
    public class RowAmountTest
    {
        [TestMethod]
        public void rowAmount_happy_pass()
        {
            //arrange
            RowAmount rowAmount = new RowAmount();
            int n = 3;
            int expected = 9;
            //act 
            int actual = rowAmount.GetSummOfFactorials(n);
            //assert
            Assert.AreEqual(expected, actual, $"summ of factorials is not correct");
        }

        [TestMethod]
        public void rowAmount_for_1_should_return_correct_value()
        {
            //arrange
            RowAmount rowAmount = new RowAmount();
            int n = 1;
            int expected = 19;
            //act 
            int actual = rowAmount.GetSummOfFactorials(n);
            //assert
            Assert.AreEqual(expected, actual, $"summ of factorials is not correct");
        }

    }
}
