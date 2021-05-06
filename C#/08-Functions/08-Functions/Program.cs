using System;

namespace _08_Functions
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            //this calls a defined funtion with no parameters
            Function();

            Console.WriteLine("enter a number");
            int x = int.Parse(Console.ReadLine());
            Console.WriteLine("enter a number to add to the other number");
            int y = int.Parse(Console.ReadLine());
            //this calls a defined funtion the has parameters and inputs two varibles
            Function2(x, y);

            Console.WriteLine("enter your name");
            string name = Console.ReadLine();
            Console.WriteLine("enter your age");
            string age = Console.ReadLine();
            //this calls a varible and returns a value 
            //the varible is then set to this returned value
            string sentence = Function3(name, age);
            Console.WriteLine(sentence);

        }

        //this defines a function with no parameters
        static void Function()
        {
            Console.WriteLine("this is a function");
        }
        //this defines a function with parameters
        static void Function2(int x,int y)
        {
            Console.WriteLine(x + y);
        }

        static string Function3(string name, string age)
        {
            string sentence = ("my name is " + name + " and i am "+age);
            //this returns the local varible to the line of code the function is used
            return sentence;
        }
    }
}
