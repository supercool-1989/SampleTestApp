using System;
using System.Text;

namespace SampleTestApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var p1Output = new StringBuilder();
            /*Problem 1*/
            for (int i = 1; i <= 100; i++)
            {
                if (i % 3 == 0 && i % 5 == 0)
                    p1Output.Append("fizzbuzz");
                else if (i % 3 == 0)
                    p1Output.Append("fizz");
                else if (i % 5 == 0)
                    p1Output.Append("buzz");

            }
            Console.WriteLine("problem 1 output: " + p1Output);

            /*Problem 2*/
            var p2Output = new StringBuilder();
            Console.Write("Please enter text to reverse : ");
            var p2Input = Console.ReadLine();

            var inpString = p2Input.ToString().ToCharArray();

            for (int i = inpString.Length - 1; i >= 0; i--)
            {
                p2Output.Append(inpString[i]);
            }
            Console.WriteLine("problem 2 output: " + p2Output);
            Console.ReadKey();

        }
    }
}
