using System;
using System.Collections.Generic;
using System.Text;

namespace HelloWorld
{
    internal class variables
    {
        static void Main(string[] args)
        {
            // type variableName = value
            /* types of variables
                int
                double
                char
                string
                bool
             */
            int myNum = 19;
            Console.WriteLine(myNum);
            // or
            int myNumber;
            myNumber = 20;
            Console.WriteLine(myNumber);

            double myDouble = 19.11D;
            Console.WriteLine(myDouble);

            char myLetter = 'K';
            Console.WriteLine(myLetter);

            string firstName = "Nguyen";
            string lastName = "Kien";      
            string fullName = firstName + ' ' + lastName;
            Console.WriteLine(fullName);

            // Declare many variables
            int a = 1, b = 2, c = 3;
            Console.WriteLine(a + b + c);

            // Data Types

            bool yay = true;
            bool nay = false;

            // Type Casting
            int random = 19;
            Console.WriteLine(Convert.ToString(random));

            double myDble = 19.11;
            int myintt = (int)myDble;
            Console.WriteLine("This is double number " + myDble);
            //Console.WriteLine("This is integer number" + myintt);

            Console.WriteLine(Convert.ToInt32(myDble)); // convert double to int

           




        }
    }
}
