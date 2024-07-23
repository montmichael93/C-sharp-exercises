using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array_of_multiples
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = 7;
            int length = 5;
            int counter = 0;

            int[] result = new int[length];

            for (int i = 1; i < result.Length; i++, counter++)
            {
                result[counter] = num * i;
                //counter++;  //works the same as adding counter++ up above
            }

            foreach (var item in result)
            {
                Console.WriteLine($"{item}");
            }

            Console.ReadLine();
        }
    }
}
