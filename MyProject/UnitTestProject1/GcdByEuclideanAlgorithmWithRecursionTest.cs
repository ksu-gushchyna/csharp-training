﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MyProject;

namespace UnitTestProject1
{
    [TestClass]
    public class GcdByEuclideanAlgorithmWithRecursionTest
    {
        [TestMethod]
        public void GcdByEuclideanAlgorithmWithRecursion_should_return_correct_value_when_first_number_more_than_second_one()
        {
            //arrange
            GcdByEuclideanAlgorithmWithRecursion gcdByEuclideanAlgorithmWithRecursion = new GcdByEuclideanAlgorithmWithRecursion();
            int firstNumb = 106;
            int secondNumb = 16;
            int expected = 2;

            //act
            int actual = gcdByEuclideanAlgorithmWithRecursion.GetGcd(firstNumb, secondNumb);

            //assert
            Assert.AreEqual(expected, actual, "not equal");

        }

        [TestMethod]
        public void GcdByEuclideanAlgorithmWithRecursion_should_return_correct_value_when_second_number_more_than_first_one()
        {
            //arrange
            GcdByEuclideanAlgorithmWithRecursion gcdByEuclideanAlgorithmWithRecursion = new GcdByEuclideanAlgorithmWithRecursion();
            int firstNumb = 16;
            int secondNumb = 106;
            int expected = 2;

            //act
            int actual = gcdByEuclideanAlgorithmWithRecursion.GetGcd(firstNumb, secondNumb);

            //assert
            Assert.AreEqual(expected, actual, "not equal");
        }


    }
}
