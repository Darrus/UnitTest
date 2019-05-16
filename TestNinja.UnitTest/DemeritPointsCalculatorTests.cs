using System;
using NUnit.Framework;
using TestNinja.Fundamentals;

namespace TestNinja.UnitTest
{
    [TestFixture]
    class DemeritPointsCalculatorTests
    {
        DemeritPointsCalculator _calculator;

        [SetUp]
        public void SetUp()
        {
            _calculator = new DemeritPointsCalculator();
        }

        [Test]
        [TestCase(int.MinValue)]
        [TestCase(int.MaxValue)]
        public void CalculateDemeritPoints_SpeedIsOutOfRange_ThrowOutOfRangeException(int speed)
        {
            Assert.That(() => { _calculator.CalculateDemeritPoints(speed); }, Throws.Exception.TypeOf<ArgumentOutOfRangeException>());
        }
    }
}
