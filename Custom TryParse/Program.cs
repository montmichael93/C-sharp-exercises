using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Custom_TryParse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number: ");
            if (TryParse(Console.ReadLine(), out int result))
            {
                Console.WriteLine("Yay" + result);
            }
            else
            {
                Console.WriteLine("Oh No!");
            }

            Console.ReadLine();
        }

        static bool TryParse(string input, out int result)
        {
            try
            {
                result = Convert.ToInt32(input);
                return true;
            }
            catch (Exception)
            {
                result = -1;
                return false;
            }
        }
    }
}
