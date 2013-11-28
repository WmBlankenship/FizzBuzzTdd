using NUnit.Framework;
using System;
using System.Linq;
using FizzBuzzLogic;

namespace FizzBuzzTdd.Tests
{
    [TestFixture]
    public class FizzBuzzLogicTests
    {
        [Test]
        public void GetOutForNumberDivisibleByJustThreeReturnsFizz()
        {
            Assert.AreEqual("Fizz", FBLogic.GetOutput(3));
            Assert.AreEqual("Fizz", FBLogic.GetOutput(6));
            Assert.AreEqual("Fizz", FBLogic.GetOutput(9));
        }

        [Test]
        public void GetOutputForNumberDivisibleByJustFiveReturnsBuzz()
        {
            Assert.AreEqual("Buzz", FBLogic.GetOutput(5));
            Assert.AreEqual("Buzz", FBLogic.GetOutput(10));
            Assert.AreEqual("Buzz", FBLogic.GetOutput(20));
        }

        [Test]
        public void GetOutputForNumberDivisibleByThreeAndFiveReturnsFizzBuzz()
        {
            Assert.AreEqual("FizzBuzz", FBLogic.GetOutput(15));
            Assert.AreEqual("FizzBuzz", FBLogic.GetOutput(30));
            Assert.AreEqual("FizzBuzz", FBLogic.GetOutput(45));
        }

        [Test]
        public void GetOutputForNumberDivisbleByNeitherReturnsNumber()
        {
            Assert.AreEqual("7", FBLogic.GetOutput(7));
            Assert.AreEqual("23", FBLogic.GetOutput(23));
            Assert.AreEqual("37", FBLogic.GetOutput(37));
        }
    }
}
