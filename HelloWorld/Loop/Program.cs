using System;

namespace Loop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            while (i <= 5)
            {
                Console.Write(i +" ");
                i++;
            }
            
            Console.WriteLine("========================================");
            for ( int a = 0; a < 10; a ++)
            {
                Console.Write(a +" ");
            }

            string[] fruits = { "banana", "orange", "apple", "grapefruit" };
            foreach (string s in fruits)
            {
                Console.WriteLine(s);
            }

            // sum from a to b
            int d = int.Parse(Console.ReadLine());
            int f = int.Parse(Console.ReadLine());
            int answer = 0;
            for (int h = d; h <= f; h++)
            {
                answer += h;
            }
            Console.WriteLine(answer);
        }
    }
}
