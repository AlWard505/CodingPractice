using System;

namespace _08_Functions
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Function();
            Console.WriteLine("enter a number");
            int x = int.Parse(Console.ReadLine());
            Console.WriteLine("enter a number to add to the other number");
            int y = int.Parse(Console.ReadLine());
            Function2(x, y);

        }
        static void Function()
        {
            Console.WriteLine("this is a function");
        }
        static void Function2(int x,int y)
        {
            Console.WriteLine(x + y);
        }
    }
}
