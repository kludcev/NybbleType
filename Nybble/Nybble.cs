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
   public partial struct Nybble : IComparable<Nybble>, IConvertible 

    {
        private int val; // storage 
        
         // The maximum value that a Nybble may represent: 15. 
        public const int MaxValue = 15; 
 
        // The minimum value that a Nybble may represent: 0. 
        public const int MinValue = 0;

        
        public Nybble(int i)
        {
            if (i > 15 || i < 0)
                throw new ArgumentOutOfRangeException();

                val = i;
                val = val & 0xF; // retain lower 4 bits 
            
        }

        // Overload binary + for Nybble + Nybble.  
        public static Nybble operator +(Nybble op1, Nybble op2)
        {
            Nybble result = new Nybble {val = op1.val + op2.val};

            if(result.val>15 || result.val<0) 
                throw new ArgumentOutOfRangeException();
           
            result.val = result.val & 0xF; // retain lower 4 bits  

            return result;
        }

        // Overload binary + for Nybble + int.  
        public static Nybble operator +(Nybble op1, int op2)
        {
            Nybble result = new Nybble {val = op1.val + op2};

            if (result.val > 15 || result.val < 0) 
             throw new ArgumentOutOfRangeException(); 
            
            result.val = result.val & 0xF; // retain lower 4 bits  

            return result;
        }

        // Overload binary + for int + Nybble.  
        public static Nybble operator +(int op1, Nybble op2)
        {
            Nybble result = new Nybble {val = op1 + op2.val};

            if (result.val > 15 || result.val < 0)  
                throw new ArgumentOutOfRangeException(); 
            
            result.val = result.val & 0xF; // retain lower 4 bits  

            return result;
        }

        // Overload ++. 
        public static Nybble operator ++(Nybble op)
        {
            var result = new Nybble {val = op.val + 1};


            if (result.val > 15 || result.val < 0)  
                throw new ArgumentOutOfRangeException(); 
           
            result.val = result.val & 0xF; // retain lower 4 bits 

            return result;
        }

        // Overload >. 
        public static bool operator >(Nybble op1, Nybble op2)
        {
            return op1.val > op2.val;
        }

        // Overload <. 
        public static bool operator <(Nybble op1, Nybble op2)
        {
            return op1.val < op2.val;
        }

        // Convert a Nybble into an int. 
        public static implicit operator int(Nybble op)
        {
            return op.val;
        }

        // Convert an int into a Nybble. 
        public static implicit operator Nybble(int op)
        {
            var result = new Nybble {val = op};

            if (result.val > 15 || result.val < 0)  
                throw new ArgumentOutOfRangeException();

            result.val = result.val & 0xF; // retain lower 4 bits 

            return result;
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


        public Nybble Parse(object ob)
        {
            int value = Convert.ToInt32(ob);

            if(value >15 || value <0)
                throw new ArgumentOutOfRangeException();

            return new Nybble(value);
        }

      
    }
}
