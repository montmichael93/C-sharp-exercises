using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fizz_Buzz_Game
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool threeDiv = false;
            bool fiveDiv = false;

            for (int i = 1; i <= 100; i++)
            {
                threeDiv = i % 3 == 0;
                fiveDiv = i % 5 == 0;

                if (threeDiv && fiveDiv)
                {
                    Console.WriteLine("FizzBuzz");
                }
                else if (threeDiv)
                {
                    Console.WriteLine("Fizz");
                }
                else if (fiveDiv)
                {
                    Console.WriteLine("Buzz");
                }
                else
                {
                    Console.WriteLine(i);
                }
            }
            Console.ReadLine();
        }
    }
}

//Note using using the same expression written out multiple times uses more memory, 
//it is much more efficient to store the expression in a variable and use the variable multiple times