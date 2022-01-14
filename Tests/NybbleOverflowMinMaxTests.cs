using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using Sources;

namespace Tests
{
    public class NybbleOverflowMinMaxTests
    {
        [Test]
        public void Max()
        {
            Assert.That(() =>
            {
                new Nybble(Nybble.MaxValue);
            }, Throws.Nothing);
        }

        [Test]
        public void BiggerThanMax()
        {
            Assert.That(() =>
            {
                new Nybble(Nybble.MaxValue + 1);
            }, Throws.InstanceOf<OverflowException>());
        }

        [Test]
        public void Min()
        {
            Assert.That(() =>
            {
                new Nybble(Nybble.MinValue);
            }, Throws.Nothing);
        }
    }
}
