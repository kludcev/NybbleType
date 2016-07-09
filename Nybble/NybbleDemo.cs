using System;
using System.Globalization;

namespace Nybble
{
    public class NybbleDemo
    {
        public static void Main()
        {
            try
            {
               
                Nybble a = new Nybble(2);
                Nybble b = new Nybble(12);
                Nybble c = new Nybble(4);
                Nybble d = new Nybble(5);
                Nybble e = 15; 
                Nybble f = null;
                //    Nybble g = new Nybble(120); ArgumentOutOfTheRange ERROR
                //Nybble z = 100; ArgumentOutOfTheRange ERROR
                int t;
                object z = 10;

                Console.WriteLine();

                Console.WriteLine("Object type: {0}", a.GetTypeCode().ToString());
                
                Console.WriteLine("a: " + (int)a);
                Console.WriteLine("b: " + (int)b);
                Console.WriteLine("c: " + (int)c);
                Console.WriteLine("d: " + (int)d);
                Console.WriteLine("e: " + (int)e);
                
                

                // use a Nybble in an if statement 
                if (a < b) Console.WriteLine("a is less than b\n");

                // Add two Nybbles together 
                c = a + b;
                Console.WriteLine("c after c = a + b: " + (int)c);

                // Add an int to a Nybble 
                a += 5;
                Console.WriteLine("a after a += 5: " + (int)a);

                Console.WriteLine();

                // use a Nybble in an int expression 
                t = a * 2 + 3;
                Console.WriteLine("Result of a * 2 + 3: " + t);

                Console.WriteLine();

                // illustrate int assignment and overflow 
                a = 1;
                Console.WriteLine("Result of a = 1: " + (int)a);
                //a = 19;
                //Console.WriteLine("Result of a = 19: " + (int)a); overflow error

                Console.WriteLine();

                // use a Nybble to control a loop     
                Console.WriteLine("Control a for loop with a Nybble.");
                for (a = 0; a < 15; a++)
                    Console.Write((int)a + " ");

                Console.WriteLine();

                //Compare 2 Nybble instanses, "a" and "b"
                Console.WriteLine("Compare two Nybble instances; a = {0}, b = {1} ",(int)a,(int)b);
                if(!a.Equals(b))
                    Console.WriteLine("a doesn't equal to b");
                else Console.WriteLine("a equal to b");
                
                Console.WriteLine();

                //Compare Nybble instance "a" with an object "z"
                Console.WriteLine("Compare Nypple instance with the object z = {0}",z);
                if (!a.Equals(z))
                    Console.WriteLine("a doesn't equal to object z");
                else Console.WriteLine("a equal to object z");

                Console.WriteLine();

                //Parsing string to nybble
                Console.WriteLine("Parse string to Nybble. Enter number from 0 - 15: ");
                string str = Console.ReadLine();
                a = a.Parse(str);
                Console.WriteLine("Parsing was completed. a = {0}",(int)a);

                Console.WriteLine();

                //Convert nybble instance to byte
                Console.WriteLine("Convert nybble a = {0} to byte",a);
                var ci = new CultureInfo("en-US");
                byte l = a.ToByte(ci);
                Console.WriteLine("Completed. Byte l = {0}",l);

            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally {Console.ReadLine();}
        }
    }
}