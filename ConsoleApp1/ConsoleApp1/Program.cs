using System;
using System.Threading;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Hello World!");
                Thread.Sleep(new TimeSpan(0, 0, 10));
            }
        }
    }
}
