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

        public bool ToBoolean(IFormatProvider provider)
        {
            throw new InvalidCastException();
        }

        public char ToChar(IFormatProvider provider)
        {
            throw new InvalidCastException();
        }

        public sbyte ToSByte(IFormatProvider provider)
        {
            return Convert.ToSByte(_value);
        }

        public byte ToByte(IFormatProvider provider)
        {
            return _value;
        }

        public short ToInt16(IFormatProvider provider)
        {
            return Convert.ToInt16(_value);
        }

        public ushort ToUInt16(IFormatProvider provider)
        {
            return Convert.ToUInt16(_value);
        }

        public int ToInt32(IFormatProvider provider)
        {
            return Convert.ToInt32(_value);
        }

        public uint ToUInt32(IFormatProvider provider)
        {
            return Convert.ToUInt32(_value);
        }

        public long ToInt64(IFormatProvider provider)
        {
            return Convert.ToInt64(_value);
        }

        public ulong ToUInt64(IFormatProvider provider)
        {
            return Convert.ToUInt64(_value);
        }

        public float ToSingle(IFormatProvider provider)
        {
            return Convert.ToSingle(_value);
        }

        public double ToDouble(IFormatProvider provider)
        {
            return Convert.ToDouble(_value);
        }

        public decimal ToDecimal(IFormatProvider provider)
        {
            return Convert.ToDecimal(_value);
        }

        public DateTime ToDateTime(IFormatProvider provider)
        {
            throw new InvalidCastException();
        }

        public string ToString(IFormatProvider provider)
        {
            return ToString(null, provider);
        }

        public object ToType(Type conversionType, IFormatProvider provider)
        {
            return Convert.ChangeType(_value, conversionType);
        }

        #endregion

        public static implicit operator int(Nybble op)
        {
            return op._value;
        }

        public static implicit operator Nybble(int op)
        {
            return new((byte)op);
        }

        #region Arithmetic operations

        public static Nybble operator +(Nybble op1, Nybble op2)
        {
            return new((byte)(op1._value + op2._value));
        }

        public static Nybble operator +(Nybble op1, int op2)
        {
            return new((byte)(op1._value + op2));
        }

        public static Nybble operator +(int op1, Nybble op2)
        {
            return new((byte)(op1 + op2._value));
        }

        public static Nybble operator ++(Nybble op)
        {
            return new((byte)(op._value + 1));
        }

        public static Nybble operator -(Nybble op1, Nybble op2)
        {
            return new((byte)(op1._value - op2._value));
        }

        public static Nybble operator -(Nybble op1, int op2)
        {
            return new((byte)(op1._value - op2));
        }

        public static Nybble operator -(int op1, Nybble op2)
        {
            return new((byte)(op1 - op2._value));

        }

        public static Nybble operator --(Nybble op)
        {
            return new((byte)(op._value - 1));
        }

        public static Nybble operator *(Nybble op1, Nybble op2)
        {
            return new((byte)(op1._value * op2._value));
        }

        public static Nybble operator *(Nybble op1, int op2)
        {
            return new((byte)(op1._value * op2));
        }

        public static Nybble operator *(int op1, Nybble op2)
        {
            return new((byte)(op1 * op2._value));
        }

        public static Nybble operator /(Nybble op1, Nybble op2)
        {
            return new((byte)(op1._value / op2._value));
        }

        public static Nybble operator /(Nybble op1, int op2)
        {
            return new((byte)(op1._value / op2));
        }

        public static Nybble operator /(int op1, Nybble op2)
        {
            return new((byte)(op1 / op2._value));
        }

        public static bool operator >(Nybble op1, Nybble op2)
        {
            return op1._value > op2._value;
        }

        public static bool operator >=(Nybble op1, Nybble op2)
        {
            return op1._value >= op2._value;
        }

        public static bool operator <=(Nybble op1, Nybble op2)
        {
            return op1._value <= op2._value;
        }

        public static bool operator <(Nybble op1, Nybble op2)
        {
            return op1._value < op2._value;
        }

        public static bool operator ==(Nybble op1, Nybble op2)
        {
            return op1._value == op2._value;
        }

        public static bool operator !=(Nybble op1, Nybble op2)
        {
            return op1._value != op2._value;
        }

        #endregion

        private static void ThrowIfOverflow(byte initialValue)
        {
            if (initialValue is > MaxValue or < MinValue)
                throw new OverflowException(nameof(initialValue));
        }
    }
}
