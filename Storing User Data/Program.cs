using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Storing_User_Data
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var name = "Michael";
            var number = 0123456789;
            var string_number = "0123456789";
            var age = 25;

            Console.WriteLine(name);
            Console.WriteLine(number); //Zeros in the front of integers do not get compiled, store as string instead
            Console.WriteLine(age); 
            Console.WriteLine(string_number);
            Console.ReadLine();
        }
    }
}
