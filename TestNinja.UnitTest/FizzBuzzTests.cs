using NUnit.Framework;
using TestNinja.Fundamentals;

namespace TestNinja.UnitTest
{
    [TestFixture]
    public class FizzBuzzTests
    {
        [Test]
        public void GetOutput_DivisbleByFizzCondition_ReturnFizz()
        {
            int number = 3;
            var result = FizzBuzz.GetOutput(number);
            Assert.That(result, Is.EqualTo("Fizz"));
        }

        [Test]
        public void GetOutput_DivisbleByBuzzCondition_ReturnBuzz()
        {
            int number = 5;
            var result = FizzBuzz.GetOutput(number);
            Assert.That(result, Is.EqualTo("Buzz"));
        }

        [Test]
        public void GetOutput_DivisbleByFizzAndBuzzCondition_ReturnFizzBuzz()
        {
            int number = 15;
            var result = FizzBuzz.GetOutput(number);
            Assert.That(result, Is.EqualTo("FizzBuzz"));
        }

        [Test]
        public void GetOutput_NotDivisbleByFizzOrBuzzCondition_ReturnInputAsString()
        {
            int number = 4;
            var result = FizzBuzz.GetOutput(number);
            Assert.That(result, Is.EqualTo(number.ToString()));
        }
    }
}