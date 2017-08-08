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

            //string myString = string.Format("{0}!", "Bonzai");
            //string myString = string.Format("Make: {0} (Model: {1})", "BMW", "760li");
            //string myString = string.Format("{0:C}", 123.45);
            //string myString = string.Format("{0:N}", 123456789);
            string myString = string.Format("{0:P}", .123);

            Console.WriteLine(myString);
            Console.ReadLine();
        }
    }
}