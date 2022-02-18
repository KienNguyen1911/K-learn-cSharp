using System;
using System.Linq; // this is system linq
namespace ArrayK
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] cars = { "Kia", "Mercedes", "Toyota", "BMW" };
            Console.WriteLine(cars[1]);

            Console.WriteLine("=================");

            Array.Sort(cars);
            foreach (string i in cars)
            {
                Console.WriteLine(i);
            }

            // System.Linq includes max, min, sum
            int[] myNum = { 1, 2, 5, 7, 8 };
            Console.WriteLine(myNum.Max());
            Console.WriteLine(myNum.Min());
        }
    }
}
