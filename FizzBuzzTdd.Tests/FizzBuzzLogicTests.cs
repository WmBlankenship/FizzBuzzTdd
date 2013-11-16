using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FizzBuzzLogic;

namespace FizzBuzzTdd.Tests
{
    [TestFixture]
    public class FizzBuzzLogicTests
    {
        [Test]
        public void GetOutForNumberDivisibleByJustThreeReturnsFizz()
        {
            Assert.AreEqual(FBLogic.GetOutput(3), "Fizz");
            Assert.AreEqual(FBLogic.GetOutput(6), "Fizz");
            Assert.AreEqual(FBLogic.GetOutput(9), "Fizz");
        }

        [Test]
        public void GetOutputForNumberDivisibleByJustFiveReturnsBuzz()
        {
            Assert.AreEqual(FBLogic.GetOutput(5), "Buzz");
            Assert.AreEqual(FBLogic.GetOutput(10), "Buzz");
            Assert.AreEqual(FBLogic.GetOutput(20), "Buzz");
        }

        [Test]
        public void GetOutputForNumberDivisibleByThreeAndFiveReturnsFizzBuzz()
        {
            Assert.AreEqual(FBLogic.GetOutput(15), "FizzBuzz");
            Assert.AreEqual(FBLogic.GetOutput(30), "FizzBuzz");
            Assert.AreEqual(FBLogic.GetOutput(45), "FizzBuzz");
        }

        [Test]
        public void GetOutputForNumberDivisbleByNeitherReturnsNumber()
        {
            Assert.AreEqual(FBLogic.GetOutput(7), "7");
            Assert.AreEqual(FBLogic.GetOutput(23), "23");
            Assert.AreEqual(FBLogic.GetOutput(37), "37");
        }
    }
}
