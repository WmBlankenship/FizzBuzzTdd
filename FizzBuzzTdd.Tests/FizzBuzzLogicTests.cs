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
            var fBLogic = new FBLogic(); 
            Assert.AreEqual("Fizz", fBLogic.GetOutput(3));
            Assert.AreEqual("Fizz", fBLogic.GetOutput(6));
            Assert.AreEqual("Fizz", fBLogic.GetOutput(9));
        }

        [Test]
        public void GetOutputForNumberDivisibleByJustFiveReturnsBuzz()
        {
            var fBLogic = new FBLogic(); 
            Assert.AreEqual("Buzz", fBLogic.GetOutput(5));
            Assert.AreEqual("Buzz", fBLogic.GetOutput(10));
            Assert.AreEqual("Buzz", fBLogic.GetOutput(20));
        }

        [Test]
        public void GetOutputForNumberDivisibleByThreeAndFiveReturnsFizzBuzz()
        {
            var fBLogic = new FBLogic(); 
            Assert.AreEqual("FizzBuzz", fBLogic.GetOutput(15));
            Assert.AreEqual("FizzBuzz", fBLogic.GetOutput(30));
            Assert.AreEqual("FizzBuzz", fBLogic.GetOutput(45));
        }

        [Test]
        public void GetOutputForNumberDivisbleByNeitherReturnsNumber()
        {
            var fBLogic = new FBLogic(); 
            Assert.AreEqual("7", fBLogic.GetOutput(7));
            Assert.AreEqual("23", fBLogic.GetOutput(23));
            Assert.AreEqual("37", fBLogic.GetOutput(37));
        }
    }
}
