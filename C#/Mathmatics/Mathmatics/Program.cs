using System;

namespace Mathmatics
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("pick the first number to add");
            int number1 = int.Parse(Console.ReadLine());
            Console.WriteLine("pick the second number to add");
            int number2 = int.Parse(Console.ReadLine());
            int addednum = number1 + number2;
            Console.WriteLine(addednum);
        }
    }
}
