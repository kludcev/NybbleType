using NUnit.Framework;
using Sources;

namespace Tests
{
    public class NybbleArithmeticOperationsTests
    {
        private const byte FirstNybbleValue = 5;
        private const byte SecondNybbleValue = FirstNybbleValue;
        private const byte ThirdNybbleValue = 10;

        private Nybble _firstNybble;
        private Nybble _secondNybble;
        private Nybble _thirdNybble;

        [SetUp]
        public void Setup()
        {
            _firstNybble = new Nybble(FirstNybbleValue);
            _secondNybble = new Nybble(SecondNybbleValue);
            _thirdNybble = new Nybble(ThirdNybbleValue);
        }

        [Test]
        public void Add()
        {
            Assert.That(_firstNybble + _secondNybble, Is.EqualTo(_thirdNybble));
        }

        [Test]
        public void Subtract()
        {
            Assert.That(_thirdNybble - _secondNybble, Is.EqualTo(_firstNybble));
        }

        [Test]
        public void Multiply()
        {
            Assert.That(_firstNybble * new Nybble(2), Is.EqualTo(_thirdNybble));
        }

        [Test]
        public void Divide()
        {
            Assert.That(_thirdNybble / _secondNybble, Is.EqualTo(new Nybble(2)));
        }

        [Test]
        public void Equal()
        {
            Assert.That(_firstNybble == _secondNybble, Is.True);
        }

        [Test]
        public void NotEqual()
        {
            Assert.That(_secondNybble != _thirdNybble, Is.True);
        }

        [Test]
        public void LessThan()
        {
            Assert.That(_firstNybble < _thirdNybble, Is.True);
            Assert.That(_firstNybble <= _thirdNybble, Is.True);
        }

        [Test]
        public void BiggerThan()
        {
            Assert.That(_thirdNybble > _firstNybble, Is.True);
            Assert.That(_thirdNybble >= _firstNybble, Is.True);
        }

        [Test]
        public void IncrementDecrement()
        {
            Assert.That(++_firstNybble, Is.EqualTo(new Nybble(FirstNybbleValue + 1)));
            Assert.That(--_secondNybble, Is.EqualTo(new Nybble(SecondNybbleValue - 1)));
        }
    }
}