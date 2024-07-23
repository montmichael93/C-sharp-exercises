using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Password_Checker
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter Password: ");
            string password = Console.ReadLine();

            Console.Write("Enter Password Again: ");
            string passwordCheck = Console.ReadLine();

            if (!password.Equals(string.Empty) && passwordCheck.Equals(string.Empty))
            {
                if (password.Equals(passwordCheck))
                {
                    Console.WriteLine("Passwords Match!");
                }
            }
            else
            {
                Console.WriteLine("please enter password");
            }

            Console.ReadLine();
        }
    }
}
