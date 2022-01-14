using System;
using System.Collections.Generic;
using System.Globalization;
using Sources;

namespace Demo
{
    public class Demo
    {
        public static void Main()
        {
            var a = new Nybble();
            var b = new Nybble(12);
            var c = new Nybble(4);
            var d = new Nybble(5);
            Nybble e = 15;
            object z = 10;

            Console.WriteLine();

            Console.WriteLine($"object type: {a.GetTypeCode()}");

            Console.WriteLine($"a: {a}");
            Console.WriteLine($"b: {b}");
            Console.WriteLine($"c: {c}");
            Console.WriteLine($"d: {d}");
            Console.WriteLine($"e: {e}\n");

            if (a < b)
                Console.WriteLine("a is less than b");

            c = a + b;
            Console.WriteLine($"c after c = a + b: {c}");

            a += 5;
            Console.WriteLine($"a after a += 5: {a}\n");

            var t = a * 2 + 3;
            Console.WriteLine($"result of a * 2 + 3: {t}\n");

            a = 1;
            Console.WriteLine($"result of a = 1: {a}\n");

            Console.WriteLine("Nybble for loop: ");
            for (a = 0; a < 15; a++)
                Console.Write((int)a + " ");

            Console.Write(Environment.NewLine);

            Console.WriteLine($"Compare two Nybble instances; a = {a}, b = {b} ");
            Console.WriteLine(!a.Equals(b) ? "a is not equal to b" : "a equals b");
            Console.Write(Environment.NewLine);

            Console.WriteLine($"Compare Nybble instance with the object z = {z}");
            Console.WriteLine(!a.Equals(z) ? "a is not equal to object z" : "a equals z");
            Console.Write(Environment.NewLine);

            Console.WriteLine($"Convert nybble a = {a} to byte type: {a.ToByte(CultureInfo.InvariantCulture)}\n");

            var sort = new List<Nybble> { 5, 4, 2, 3, 1 };
            Console.WriteLine("Sorting Nybble collection by asc");
            Console.WriteLine($"Input: {string.Join(',', sort)}");

            sort.Sort();
            Console.WriteLine($"Sorted list: {string.Join(',', sort)}");

            Console.ReadLine();
        }
    }
}