using System;

namespace Nybble
{
   public partial struct Nybble
   {
       #region Iconvertible implementation

       public TypeCode GetTypeCode()
       {
           return Type.GetTypeCode(typeof(Nybble));
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
           return Convert.ToSByte(val);
       }

       public byte ToByte(IFormatProvider provider)
       {
           return Convert.ToByte(val);
       }

       public short ToInt16(IFormatProvider provider)
       {
           return Convert.ToInt16(val);
       }

       public ushort ToUInt16(IFormatProvider provider)
       {
           return Convert.ToUInt16(val);
       }

       public int ToInt32(IFormatProvider provider)
       {
           return Convert.ToInt32(val);
       }

       public uint ToUInt32(IFormatProvider provider)
       {
           return Convert.ToUInt32(val);
       }

       public long ToInt64(IFormatProvider provider)
       {
           return Convert.ToInt64(val);
       }

       public ulong ToUInt64(IFormatProvider provider)
       {
           return Convert.ToUInt64(val);
       }

       public float ToSingle(IFormatProvider provider)
       {
           return Convert.ToSingle(val);
       }

       public double ToDouble(IFormatProvider provider)
       {
           return Convert.ToDouble(val);
       }

       public decimal ToDecimal(IFormatProvider provider)
       {
           return Convert.ToDecimal(val);
       }

       public DateTime ToDateTime(IFormatProvider provider)
       {
           throw new InvalidCastException();
       }

        public string ToString(IFormatProvider provider)
       {
           //return ((IConvertible)val).ToString(provider);
           return ToString();
       }

       public object ToType(Type conversionType, IFormatProvider provider)
       {
           throw new InvalidCastException();

       }

       public override string ToString()
       {
           return "zalupa";
       }

       #endregion
   }


}
