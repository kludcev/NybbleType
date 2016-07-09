/*============================================================
** 
** Class:  Nybble 
**
** 
** Purpose: This class will encapsulate a 4-bit type called Nybble and provide an
**          Object representation of it.
**
** Author: Cyril Lutzow, 2016; github.com/CyrilvonLutzow
**
===========================================================*/
using System;
using System.Runtime.InteropServices;


namespace Nybble
{// ComVisible(true) allows this class to be accessed from another environments. Example: http://jumbloid.blogspot.ru/2009/12/making-net-dll-com-visible.html
    // StructLayout - This attribute forcing CLR to layout fields of the type in memory sequantualy. https://habrahabr.ru/post/114953/
    [ComVisible(true), Serializable, StructLayout(LayoutKind.Sequential)] 
   public class Nybble : IComparable, IConvertible 

    {


        private int val; // storage 
        
         // The maximum value that a Nybble may represent: 15. 
        public const int MaxValue = 15; 
 
        // The minimum value that a Nybble may represent: 0. 
        public const int MinValue = 0;

        
        public Nybble(int i)
        {
            if (i > 15 || i < 0)
            {
                throw new ArgumentOutOfRangeException();
            }
            else
            {
                val = i;
                val = val & 0xF; // retain lower 4 bits 
            }
        }

        public Nybble()
        {
            val = 0;
        }

        // Overload binary + for Nybble + Nybble.  
        public static Nybble operator +(Nybble op1, Nybble op2)
        {
            Nybble result = new Nybble();

            result.val = op1.val + op2.val;

            if(result.val>15 || result.val<0) {throw new ArgumentOutOfRangeException();}
           
            result.val = result.val & 0xF; // retain lower 4 bits  

            return result;
        }

        // Overload binary + for Nybble + int.  
        public static Nybble operator +(Nybble op1, int op2)
        {
            Nybble result = new Nybble();

            result.val = op1.val + op2;

            if (result.val > 15 || result.val < 0) { throw new ArgumentOutOfRangeException(); }
            
            result.val = result.val & 0xF; // retain lower 4 bits  

            return result;
        }

        // Overload binary + for int + Nybble.  
        public static Nybble operator +(int op1, Nybble op2)
        {
            Nybble result = new Nybble();

            result.val = op1 + op2.val;

            if (result.val > 15 || result.val < 0) { throw new ArgumentOutOfRangeException(); }
            
            result.val = result.val & 0xF; // retain lower 4 bits  

            return result;
        }

        // Overload ++. 
        public static Nybble operator ++(Nybble op)
        {
            var result = new Nybble();

            result.val = op.val + 1;

            if (result.val > 15 || result.val < 0) { throw new ArgumentOutOfRangeException(); }
           
            result.val = result.val & 0xF; // retain lower 4 bits 

            return result;
        }

        // Overload >. 
        public static bool operator >(Nybble op1, Nybble op2)
        {
            if (op1.val > op2.val) return true;
            else return false;
        }

        // Overload <. 
        public static bool operator <(Nybble op1, Nybble op2)
        {
            if (op1.val < op2.val) return true;
            else return false;
        }

        // Convert a Nybble into an int. 
        public static implicit operator int(Nybble op)
        {
            return op.val;
        }

        // Convert an int into a Nybble. 
        public static implicit operator Nybble(int op)
        {
            var result = new Nybble();

            result.val = op;

            if (result.val > 15 || result.val < 0) { throw new ArgumentOutOfRangeException(); }

            result.val = result.val & 0xF; // retain lower 4 bits 

            return result;
        }

        public int CompareTo(object obj) // Icomparable implementation
        {
            if (obj == null)
                return 1;
            
            if (!(obj is Nybble))
                throw new ArgumentException("Argument must be Nybble");
            
            return val - (((Nybble)obj).val); 
        }

        public int CompareTo(Nybble nybble)
        {
            return val - nybble.val;
        }
        public override bool Equals(Object obj)
        {
            if (!(obj is Nybble))
            {
                return false;
            }
            return val == ((Nybble)obj).val;
        }

        public bool Equals(Nybble nybble)
        {
            return val == nybble.val;
        }


        public Nybble Parse(string s)
        {

            return new Nybble(Convert.ToInt32(s));
        }

        #region Iconvertible implementation

        public TypeCode GetTypeCode()
        {
            TypeCode type;
            TypeCode.TryParse("Nybble", out type);
            return type;
            // return TypeCode.TryParse("Nybble",)
        }

        public bool ToBoolean(IFormatProvider provider)
        {
            return Convert.ToBoolean(val);
        }


        public char ToChar(IFormatProvider provider)
        {
            return Convert.ToChar(val); 
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
            return Convert.ToDateTime(val);
        }

        public string ToString(IFormatProvider provider)
        {
            return ((IConvertible)val).ToString(provider);
        }

        public object ToType(Type conversionType, IFormatProvider provider)
        {
            return ((IConvertible)val).ToType(conversionType, provider);

        }
#endregion
    }
}
