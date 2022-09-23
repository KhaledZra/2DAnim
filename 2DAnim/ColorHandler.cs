using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2DAnim
{
    internal class ColorHandler
    {
        public static void PrintYellow(string input)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write(input);
            Console.ResetColor();
        }

        public static void PrintBlue(string input)
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write(input);
            Console.ResetColor();
        }

        public static void PrintRed(string input)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write(input);
            Console.ResetColor();
        }

        public static void PrintGreen(string input)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write(input);
            Console.ResetColor();
        }
    }
}
