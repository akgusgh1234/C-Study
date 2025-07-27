using System;
using static System.Console;

namespace ConsoleApp1
{
    internal class MainApp
    {
        static void Main(string[] args)
        {
            if (args.Length == 0)
            {
                Console.WriteLine("사용법 : Hello.exe");
                return;
            }
            WriteLine("Hello, {0}!", args[0]);
        }
    }
}
