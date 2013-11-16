using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FizzBuzzTdd.Tests;

namespace FizzBuzzTdd.Tests
{
    [TestFixture]
    public class Class1
    {
        [Test]
        public void GetOutForNumberDivisibleByJustThreeReturnsFizz()
        {
            Assert.AreEqual(Class2.GetOutput(3), "Fizz");
            Assert.AreEqual(Class2.GetOutput(6), "Fizz");
            Assert.AreEqual(Class2.GetOutput(9), "Fizz");
        }

        [Test]
        public void GetOutputForNumberDivisibleByJustFiveReturnsBuzz()
        {
            Assert.AreEqual(Class2.GetOutput(5), "Buzz");
            Assert.AreEqual(Class2.GetOutput(10), "Buzz");
            Assert.AreEqual(Class2.GetOutput(20), "Buzz");
        }

        [Test]
        public void GetOutputForNumberDivisibleByThreeAndFiveReturnsFizzBuzz()
        {
            Assert.AreEqual(Class2.GetOutput(15), "FizzBuzz");
            Assert.AreEqual(Class2.GetOutput(30), "FizzBuzz");
            Assert.AreEqual(Class2.GetOutput(45), "FizzBuzz");
        }

        [Test]
        public void GetOutputForNumberDivisbleByNeitherReturnsNumber()
        {
            Assert.AreEqual(Class2.GetOutput(7), "7");
            Assert.AreEqual(Class2.GetOutput(23), "23");
            Assert.AreEqual(Class2.GetOutput(37), "37");
        }
    }
}
