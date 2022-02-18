using System;

namespace Operators
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter any number x");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter any number y");
            int y = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("x + y = " +(x + y));
            Console.WriteLine("x + y = "+(x - y));
            Console.WriteLine("x + y = " +(x * y));
            Console.WriteLine("x + y = " + (x / y));
            Console.WriteLine("x % y = " + (x % y));
            Console.WriteLine("x++ =" + (x++));
            Console.WriteLine("x-- =" + (x--));

            Console.WriteLine("-----------------------------");
            // ??? : &=, |=, ^=, >>=, <<=

            int z = 10;
            Console.WriteLine(z >= 9 && z < 11); // True
            Console.WriteLine(z > 9 || z < 8);  //True
            Console.WriteLine(!(z >= 9 && z < 11)); // False
             

        }
    }
}
