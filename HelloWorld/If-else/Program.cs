using System;

namespace If_else
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int minute = 60;
            string result = (minute > 59) ? "That\'s right" : "That\'s false";
            Console.WriteLine(result);

            // even number and odd number
            Console.Write("Enter any number: ");
            int n =  Convert.ToInt32(Console.ReadLine());
            if(n%2==0)
            {
                Console.WriteLine("n is even number");
            } else
            {
                Console.WriteLine("n is odd number");
            }

            // ><=0 number
            int z = Convert.ToInt32(Console.ReadLine());
            if (z > 0)
            {
                Console.WriteLine("n is a positive number");
            } 
            else if(z==0)
            {
                Console.WriteLine("n is equal to 0");
            }
            else
            {
                Console.WriteLine("n is a negative number");
            }

            // compare between a and b
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            if (a>=b)
            {
                Console.WriteLine("a is greater than or equal to b");
            } else
            {
                Console.WriteLine("a is smaller than b");
            }


        }
    }
}
