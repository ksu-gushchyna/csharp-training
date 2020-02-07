using Microsoft.VisualStudio.TestTools.UnitTesting;
using MyProject;

namespace UnitTestProject1
{
    [TestClass]
    public class PrimeNumberTest
    {
        [TestMethod]
        public void primeNumber_happy_pass()
        {
            //arrange
            PrimeNumber primeNumber = new PrimeNumber();
            int inputNumber = 79;
            string expected = "Yes";
            ////act 
            string actual = primeNumber.IsNumberPrime(inputNumber);
            ////assert
            Assert.AreEqual(expected, actual, "is not equal");
        }

        [TestMethod]
        public void primeNumber_should_return_negative_result_for_zero()
        {
            //arrange
            PrimeNumber primeNumber = new PrimeNumber();
            int inputNumber = 0;
            string expected = "No";
            ////act 
            string actual = primeNumber.IsNumberPrime(inputNumber);
            ////assert
            Assert.AreEqual(expected, actual, "is not equal");
        }

        [TestMethod]
        public void primeNumber_should_return_negative_result_for_not_prime_numbers()
        {
            //arrange
            PrimeNumber primeNumber = new PrimeNumber();
            int inputNumber = 10;
            string expected = "No";
            ////act 
            string actual = primeNumber.IsNumberPrime(inputNumber);
            ////assert
            Assert.AreEqual(expected, actual, "is not equal");
        }
    }
}
