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

            Console.WriteLine("enter your name");
            string name = Console.ReadLine();
            Console.WriteLine("enter your age");
            string age = Console.ReadLine();
            string sentence = Function3(name, age);
            Console.WriteLine(sentence);

        }
        static void Function()
        {
            Console.WriteLine("this is a function");
        }
        static void Function2(int x,int y)
        {
            Console.WriteLine(x + y);
        }

        static string Function3(string name, string age)
        {
            string sentence = ("my name is " + name + " and i am "+age);
            return sentence;
        }
    }
}
