using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NybbleDemo
{
    class Demo
    {
        static void Main(string[] args)
        {
            try
            {

                Nybble.Nybble a = new Nybble.Nybble(2);
                Nybble.Nybble e = 15 + a;
                Nybble.Nybble b = new Nybble.Nybble(15);
                Nybble.Nybble c = new Nybble.Nybble(4);
                Nybble.Nybble d = new Nybble.Nybble(5);
                Nybble.Nybble f = new Nybble.Nybble(120);
                int t;

                Console.WriteLine("a: " + (int)a);
                Console.WriteLine("b: " + (int)b);


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
                a = 19;
                Console.WriteLine("Result of a = 19: " + (int)a);

                Console.WriteLine();

                // use a Nybble to control a loop     
                Console.WriteLine("Control a for loop with a Nybble.");
                for (a = 0; a < 10; a++)
                    Console.Write((int)a + " ");

                Console.WriteLine();

                e = 10;
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex);


            }
            finally { Console.ReadLine(); }
        }
    }
}
