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
    public class NybbleConvertibleTests
    {
        private const byte NybbleValue = Nybble.MaxValue;

        private Nybble _nybble;

        [SetUp]
        public void Setup()
        {
            _nybble = new Nybble(NybbleValue);
        }

        [Test]
        public void GetTypeCode()
        {
            Assert.That(_nybble.GetTypeCode(), Is.EqualTo(TypeCode.Object));
        }

        [Test]
        public void ToBoolean()
        {
            Assert.That(() => _nybble.ToBoolean(CultureInfo.InvariantCulture), Throws.InstanceOf<InvalidCastException>());
        }

        [Test]
        public void ToChar()
        {
            Assert.That(() => _nybble.ToChar(CultureInfo.InvariantCulture), Throws.InstanceOf<InvalidCastException>());
        }

        [Test]
        public void ToDateTime()
        {
            Assert.That(() => _nybble.ToDateTime(CultureInfo.CurrentCulture), Throws.InstanceOf<InvalidCastException>());
        }

        [Test]
        public void ToSByte()
        {
            Assert.That(_nybble.ToSByte(CultureInfo.InvariantCulture), Is.EqualTo(Convert.ToSByte(NybbleValue)));
        }

        [Test]
        public void ToByte()
        {
            Assert.That(_nybble.ToByte(CultureInfo.InvariantCulture), Is.EqualTo(Convert.ToByte(NybbleValue)));
        }

        [Test]
        public void ToUInt16()
        {
            Assert.That(_nybble.ToUInt16(CultureInfo.InvariantCulture), Is.EqualTo(Convert.ToUInt16(NybbleValue)));
        }

        [Test]
        public void ToInt16()
        {
            Assert.That(_nybble.ToInt16(CultureInfo.InvariantCulture), Is.EqualTo(Convert.ToInt16(NybbleValue)));
        }

        [Test]
        public void ToUInt32()
        {
            Assert.That(_nybble.ToUInt32(CultureInfo.InvariantCulture), Is.EqualTo(Convert.ToUInt32(NybbleValue)));
        }

        [Test]
        public void ToInt32()
        {
            Assert.That(_nybble.ToInt32(CultureInfo.InvariantCulture), Is.EqualTo(Convert.ToInt32(NybbleValue)));
        }

        [Test]
        public void ToUInt64()
        {
            Assert.That(_nybble.ToUInt64(CultureInfo.InvariantCulture), Is.EqualTo(Convert.ToUInt64(NybbleValue)));
        }

        [Test]
        public void ToInt64()
        {
            Assert.That(_nybble.ToInt64(CultureInfo.InvariantCulture), Is.EqualTo(Convert.ToInt64(NybbleValue)));
        }

        [Test]
        public void ToSingle()
        {
            Assert.That(_nybble.ToSingle(CultureInfo.InvariantCulture), Is.EqualTo(Convert.ToSingle(NybbleValue)));
        }

        [Test]
        public void ToDouble()
        {
            Assert.That(_nybble.ToDouble(CultureInfo.InvariantCulture), Is.EqualTo(Convert.ToDouble(NybbleValue)));
        }

        [Test]
        public void ToDecimal()
        {
            Assert.That(_nybble.ToDecimal(CultureInfo.InvariantCulture), Is.EqualTo(Convert.ToDecimal(NybbleValue)));
        }

        [Test]
        public void ToString()
        {
            Assert.That(_nybble.ToString(CultureInfo.CurrentCulture), Is.EqualTo(NybbleValue.ToString()));
        }

        [Test]
        public void ToType()
        {
            Assert.That(_nybble.ToType(typeof(int), CultureInfo.InvariantCulture), Is.EqualTo(Convert.ChangeType(_nybble, typeof(int))));
        }
    }
}
