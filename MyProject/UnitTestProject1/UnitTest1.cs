using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MyProject;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            //arrange
            Class1 class1 = new Class1();
            int a = -2;
            int b = 3;
            double expected = 6;
            //act
            double actual = class1.GetSquare(a, b);
            //assert
            Assert.AreEqual(expected, actual, 0.01, "incorrect data");
        }


        [TestMethod]
        public void TestMethodException()
        {
            //arrange
            Class1 class1 = new Class1();
            int a = -2;
            int b = 3;

            //act assert
            double actual = class1.GetSquare(a, b);

            Assert.ThrowsException<System.ArgumentOutOfRangeException>(() => class1.A = a);
        }
    }
}
