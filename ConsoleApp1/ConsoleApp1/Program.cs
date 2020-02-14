using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Out.WriteLine("Input a string to be echoed:");
            string input = Console.In.ReadLine();
            Console.Out.WriteLine("echo: " + input);
            Console.ReadKey();
        }
    }
}
