using System;

namespace String
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // string length
            string txt = "asdfGHjkl";
            Console.WriteLine("The length of txt is " + txt.Length);

            // uperCase, lowerCase
            Console.WriteLine(txt.ToUpper());
            Console.WriteLine(txt.ToLower());

            // concat
            string txt1 = "12341234";
            string text = string.Concat(txt, txt1);
            Console.WriteLine(text); // Don't have space between 2 variables

            string fulltext = $"Full text is: {txt} {txt1}";
            Console.WriteLine(fulltext);

            Console.WriteLine(txt[0]); // Ouput: a

            int charPos = text.IndexOf('2');
            string word = text.Substring(charPos); // get from charPos
            Console.WriteLine(word);

            // Special characters
            string txt3 = "My name is \"Kien\", Hello everybody";
            string txt4 = "it \'s alright";
            string txt5 = "dau nay \\ , duoc goi la backslash";

            Console.WriteLine(txt3 + "\n" + txt4 + "\n" + txt5);
        }
    }
}
