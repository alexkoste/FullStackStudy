using System;

namespace HomeWork3
{
    internal class Program
    {
        public delegate void Prnt(string text);

        static void Main(string[] args)
        {
            string message = "Hello World!";
            Prnt print;

            print = PrintGreen;
            print += PrintYellow;

            print(message);
        }

        private static void PrintGreen(string text)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(text);
        }

        private static void PrintYellow(string text)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(text);
        }

    }
}
