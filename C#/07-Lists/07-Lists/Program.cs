using System;
using System.Collections.Generic;
namespace _07_Lists
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> Names = new List<string>();
            Console.WriteLine("enter names and then type End when you're finished\nthe code will then sort the names you gave");
            string input = Console.ReadLine();
            while (input != "End")
            {
                Names.Add(input);
                input = Console.ReadLine();
            }
            Console.WriteLine("heres the order you entered the names");
            foreach(string i in Names)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("here is them alphabetically");
            Names.Sort();
            foreach (string i in Names)
            {
                Console.WriteLine(i);
            }
        }
    }
}
