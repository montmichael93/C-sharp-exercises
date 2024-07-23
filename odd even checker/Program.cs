using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace odd_even_checker
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1 = 10;
            int num2 = 2;
            int remainder = num1 % num2;

            Console.WriteLine(remainder);

            num1++;

            remainder = num1 % num2;

            Console.WriteLine(remainder);

            Console.ReadLine();

        }
    }
}
