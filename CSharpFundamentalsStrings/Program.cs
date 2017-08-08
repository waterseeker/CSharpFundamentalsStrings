using System;

namespace CSharpFundamentalsStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            //string myString = "Go to your c:\\ drive";
            //string myString = "My \"SortedDictionary called\" life";
            //string myString = "What if I need \n a new line?";

            string myString = string.Format("{0}!", "Bonzai");

            Console.WriteLine(myString);
            Console.ReadLine();
        }
    }
}