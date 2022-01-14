using System;
using System.Runtime.InteropServices;

namespace Sources
{
    //This class will encapsulate a 4-bit type called Nybble and provide an object representation of it.
    [ComVisible(true)]
    [Serializable]
    [StructLayout(LayoutKind.Sequential)]
    public struct Nybble : IComparable<Nybble>, IEquatable<Nybble>, IFormattable, IConvertible
    {
        public const byte MaxValue = 15;
        public const byte MinValue = 0;

        private readonly byte _value;

        public Nybble(byte value)
        {
            ThrowIfOverflow(value);

            _value = value;
        }

        public int CompareTo(Nybble nybble)
        {
            return _value - nybble._value;
        }

        public override bool Equals(object obj)
        {
            if (obj is not Nybble nybble)
                return false;

            return _value == nybble._value;
        }

        public override int GetHashCode()
        {
            return _value.GetHashCode();
        }

        public override string ToString()
        {
            return ToString(null, null);
        }

        public string ToString(string? format, IFormatProvider? formatProvider)
        {
            return _value.ToString(format, formatProvider);
        }

        public bool Equals(Nybble nybble)
        {
            return this == nybble;
        }

        #region IConverible implementation

        public TypeCode GetTypeCode()
        {
            return TypeCode.Object;
        }

        public bool ToBoolean(IFormatProvider formatProvider)
        {
            throw new InvalidCastException();
        }

        public char ToChar(IFormatProvider formatProvider)
        {
            throw new InvalidCastException();
        }

        public sbyte ToSByte(IFormatProvider formatProvider)
        {
            return Convert.ToSByte(_value);
        }

        public byte ToByte(IFormatProvider formatProvider)
        {
            return _value;
        }

        public short ToInt16(IFormatProvider formatProvider)
        {
            return Convert.ToInt16(_value);
        }

        public ushort ToUInt16(IFormatProvider formatProvider)
        {
            return Convert.ToUInt16(_value);
        }

        public int ToInt32(IFormatProvider formatProvider)
        {
            return Convert.ToInt32(_value);
        }

        public uint ToUInt32(IFormatProvider formatProvider)
        {
            return Convert.ToUInt32(_value);
        }

        public long ToInt64(IFormatProvider formatProvider)
        {
            return Convert.ToInt64(_value);
        }

        public ulong ToUInt64(IFormatProvider formatProvider)
        {
            return Convert.ToUInt64(_value);
        }

        public float ToSingle(IFormatProvider formatProvider)
        {
            return Convert.ToSingle(_value);
        }

        public double ToDouble(IFormatProvider formatProvider)
        {
            return Convert.ToDouble(_value);
        }

        public decimal ToDecimal(IFormatProvider formatProvider)
        {
            return Convert.ToDecimal(_value);
        }

        public DateTime ToDateTime(IFormatProvider formatProvider)
        {
            throw new InvalidCastException();
        }

        public string ToString(IFormatProvider formatProvider)
        {
            return ToString(null, formatProvider);
        }

        public object ToType(Type conversionType, IFormatProvider formatProvider)
        {
            return Convert.ChangeType(_value, conversionType);
        }

        #endregion

        public static implicit operator int(Nybble nybble)
        {
            return nybble._value;
        }

        public static implicit operator Nybble(int integer)
        {
            return new((byte)integer);
        }

        #region Arithmetic operations

        public static Nybble operator +(Nybble nybble1, Nybble nybble2)
        {
            return new((byte)(nybble1._value + nybble2._value));
        }

        public static Nybble operator +(Nybble nybble, int integer)
        {
            return new((byte)(nybble._value + integer));
        }

        public static Nybble operator +(int integer, Nybble nybble)
        {
            return new((byte)(integer + nybble._value));
        }

        public static Nybble operator ++(Nybble nybble)
        {
            return new((byte)(nybble._value + 1));
        }

        public static Nybble operator -(Nybble nybble1, Nybble nybble2)
        {
            return new((byte)(nybble1._value - nybble2._value));
        }

        public static Nybble operator -(Nybble nybble, int integer)
        {
            return new((byte)(nybble._value - integer));
        }

        public static Nybble operator -(int integer, Nybble nybble)
        {
            return new((byte)(integer - nybble._value));
        }

        public static Nybble operator --(Nybble nybble)
        {
            return new((byte)(nybble._value - 1));
        }

        public static Nybble operator *(Nybble nybble1, Nybble nybble2)
        {
            return new((byte)(nybble1._value * nybble2._value));
        }

        public static Nybble operator *(Nybble nybble, int integer)
        {
            return new((byte)(nybble._value * integer));
        }

        public static Nybble operator *(int integer, Nybble nybble)
        {
            return new((byte)(integer * nybble._value));
        }

        public static Nybble operator /(Nybble nybble1, Nybble nybble2)
        {
            return new((byte)(nybble1._value / nybble2._value));
        }

        public static Nybble operator /(Nybble nybble, int integer)
        {
            return new((byte)(nybble._value / integer));
        }

        public static Nybble operator /(int integer, Nybble nybble)
        {
            return new((byte)(integer / nybble._value));
        }

        public static bool operator >(Nybble nybble1, Nybble nybble2)
        {
            return nybble1._value > nybble2._value;
        }

        public static bool operator >=(Nybble nybble1, Nybble nybble2)
        {
            return nybble1._value >= nybble2._value;
        }

        public static bool operator <=(Nybble nybble1, Nybble nybble2)
        {
            return nybble1._value <= nybble2._value;
        }

        public static bool operator <(Nybble nybble1, Nybble nybble2)
        {
            return nybble1._value < nybble2._value;
        }

        public static bool operator ==(Nybble nybble1, Nybble nybble2)
        {
            return nybble1._value == nybble2._value;
        }

        public static bool operator !=(Nybble nybble1, Nybble nybble2)
        {
            return nybble1._value != nybble2._value;
        }

        #endregion

        private static void ThrowIfOverflow(byte initialValue)
        {
            if (initialValue is > MaxValue or < MinValue)
                throw new OverflowException(nameof(initialValue));
        }
    }
}
