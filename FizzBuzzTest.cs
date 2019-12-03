using NUnit.Framework;
using System.Collections.Generic;
namespace FizzBuzz
{
    public class Tests
    {
        FizzBuzz fizzBuzz = new FizzBuzz();

        [Test]
        public void OutputsOnlyStrings()
        {
            Assert.That(fizzBuzz.Results(), Is.All.InstanceOf<string>());
        }

        [Test]
        public void Outputs100Strings()
        {
            Assert.That(fizzBuzz.Results(), Has.Exactly(100).Items);
        }

        [Test]
        public void ValuesIncrease()
        {
            List<string> results = fizzBuzz.Results();
            Assert.AreEqual("1", results[0]);
            Assert.AreEqual("2", results[1]);
            Assert.AreEqual("7", results[6]);
            Assert.AreEqual("22", results[21]);
            Assert.AreEqual("97", results[96]);
        }

        [Test]
        public void MultiplesOfThreeReturnFizz()
        {
            List<string> results = fizzBuzz.Results();
            Assert.AreEqual("Fizz", results[2]);
            Assert.AreEqual("Fizz", results[5]);
            Assert.AreEqual("Fizz", results[8]);
            Assert.AreEqual("Fizz", results[20]);
        }

        [Test]
        public void MultiplesOfFiveReturnBuzz()
        {
            List<string> results = fizzBuzz.Results();
            Assert.AreEqual("Buzz", results[4]);
            Assert.AreEqual("Buzz", results[9]);
            Assert.AreEqual("Buzz", results[19]);
            Assert.AreEqual("Buzz", results[99]);
        }

        [Test]
        public void MultiplesOfThreeAndFiveReturnFizzBuzz()
        {
            List<string> results = fizzBuzz.Results();
            Assert.AreEqual("FizzBuzz", results[14]);
            Assert.AreEqual("FizzBuzz", results[29]);
            Assert.AreEqual("FizzBuzz", results[59]);
            Assert.AreEqual("FizzBuzz", results[89]);
        }    }
}