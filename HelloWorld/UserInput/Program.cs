using System;

namespace UserInput
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Console.ReadLine() return method STRING so you can not get information from another data types
            Console.WriteLine("Enter your name:");
            string yourName = Console.ReadLine();

            Console.WriteLine("Enter your age");
            int age = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine("Your name is " + yourName);
            Console.WriteLine("Your age is " + age);

        }
    }
}
