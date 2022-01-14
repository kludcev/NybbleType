using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using Sources;

namespace Tests
{
    public class NybbleObjectBaseMethodsTests
    {
        private const byte InitValue = 10;

        private Nybble _nybble;

        [SetUp]
        public void Setup()
        {
            _nybble = new Nybble(InitValue);
        }

        [Test]
        public void GetHashCode()
        {
            Assert.That(_nybble.GetHashCode(), Is.EqualTo(InitValue));
        }

        
        [Test]
        public void EqualsCheckWithRandomObjectIsFalse()
        {
            Assert.That(_nybble.Equals(new object()), Is.False);
        }

        [Test]
        public void Equals()
        {
            Assert.That(_nybble.Equals((object)new Nybble(InitValue)), Is.True);
        }

        [Test]
        public void EqualsGeneric()
        {
            Assert.That(_nybble.Equals(new Nybble(InitValue)), Is.True);
        }

        [Test]
        public void EqualsGenericWithDifferentValue()
        {
            Assert.That(_nybble.Equals(new Nybble(Nybble.MinValue)), Is.False);
        }

        [Test]
        public void ToString()
        {
            Assert.That(_nybble.ToString(), Is.EqualTo(InitValue.ToString()));
        }
    }
}
