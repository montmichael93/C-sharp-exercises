using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Area_Of_A_Triangle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int width = ReadInt("Enter width: ");
            int height = ReadInt("Enter height: ");

            int result = CalcArea(width, height);

            Console.WriteLine($"the area is {result}");

            Console.ReadLine();
        }

        static int CalcArea(int width, int height)
        {
            return (width * height) / 2;
        }

        static int ReadInt(string message)
        {
            Console.Write(message);
            return Convert.ToInt32(Console.ReadLine());
        }
    }
}
