using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FibonacciSequence3
{
    class Program
    {
        public static void FibonacciRecursive
            (
            int firstnumber,
            int secondnumber,
            int counter,
            int lenght
            )
        {
            if (counter <= lenght)
            {
                Console.Write("{0} ", firstnumber);
                FibonacciRecursive(secondnumber, firstnumber + secondnumber, counter + 1, lenght);
            }
        }

        public static void Main(string[] args)
        {
            Console.Write("Enter the length of the Fibonacci Series: ");
            int lenght = Convert.ToInt32(Console.ReadLine());
            FibonacciRecursive(0, 1, 1, lenght);
            Console.ReadKey();
        }
    }
}
