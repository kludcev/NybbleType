using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using Sources;

namespace Tests
{
    public class NybbleComparerTests
    {
        private Nybble[] _unsortedNybbles;
        private Nybble[] _sortedNybbles;

        [SetUp]
        public void Setup()
        {
            var randomNybble = new Nybble((byte)new Random().Next(Nybble.MinValue, Nybble.MaxValue));

            _unsortedNybbles = new[] { new Nybble(Nybble.MaxValue), randomNybble, new Nybble() };
            _sortedNybbles = new[] { new Nybble(), randomNybble, new Nybble(Nybble.MaxValue) };
        }

        [Test]
        public void Sort()
        {
            Assert.That(() => Array.Sort(_unsortedNybbles), Throws.Nothing);
            Assert.That(_unsortedNybbles, Is.EquivalentTo(_sortedNybbles));
        }
    }
}
