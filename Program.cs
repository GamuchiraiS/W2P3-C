using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P3
{
    class Program
    {
        static void Main(string[] args)
        {
            //From the Fibonacci sequence the first and second
            //number are always going to be 
            //0 and 1 so we code that
            int FirstNumber = 0;
            int SecondNumber = 1;
            int ThirdNumber;
            int NumbersShown;

            Console.WriteLine("How many numbers from the Fibonacci series must be shown?");
            NumbersShown = Convert.ToInt32(Console.ReadLine());
            //prints the first and second number
            Console.WriteLine(FirstNumber);
            Console.WriteLine(SecondNumber);
            //create sequence
            for (int i = 2; i < NumbersShown; i++)
            {
                ThirdNumber = FirstNumber + SecondNumber;
                Console.WriteLine(ThirdNumber + "");
                FirstNumber = SecondNumber;
                SecondNumber = ThirdNumber;
            }
            Console.ReadLine();
        }
    }
}
