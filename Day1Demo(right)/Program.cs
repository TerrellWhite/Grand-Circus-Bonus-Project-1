using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day1Demo_right_
{
    class Program
    {
        static void Main(string[] args)
        {
            // this program will read two numbers, then show the sum of the numbers

            //input
            int Input1;
            int Input2;

            Console.WriteLine("Please enter a number ");
            Input1 = int.Parse(Console.ReadLine()); //int.parse converts str in to int
            Console.WriteLine("Please enter a number ");
            Input2 = Convert.ToInt32(Console.ReadLine()); //Convert.ToInt32 does the same
            //processing
            int Result = Input1 + Input2;
            //output
            Console.WriteLine($"The result of adding {Input1} and {Input2} is {Result}"); //$allows you to embedd code in string        
        }
    }
}
