using System;

namespace Matha
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // max, min, abs, round, sqrt
            int x = 9, y = 11;
            Console.WriteLine(Math.Max(x, y));
            Console.WriteLine(Math.Min(x, y));
            Console.WriteLine(Math.Sqrt(x));
            Console.WriteLine(Math.Abs(-10));
            Console.WriteLine(Math.Round(3.4));

        }
    }
}
