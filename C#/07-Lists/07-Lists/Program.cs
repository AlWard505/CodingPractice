using System;
using System.Collections.Generic;
namespace _07_Lists
{
    class Program
    {
        static void Main(string[] args)
        {
            //this defines the list and the type of contents 
            List<string> Names = new List<string>();
            Console.WriteLine("enter names and then type End when you're finished\nthe code will then sort the names you gave");
            string input = Console.ReadLine();
            while (input != "End")
            {
                //this will add a value to the list
                Names.Add(input);
                input = Console.ReadLine();
            }
            Console.WriteLine("heres the order you entered the names");
            //this will run a piece of code for every value in the list
            foreach(string i in Names)
            {
                //this will print the value that i relates to
                Console.WriteLine(i);
            }
            Console.WriteLine("here is them alphabetically");
            //this will sort the names alphabetically
            Names.Sort();
            foreach (string i in Names)
            {
                Console.WriteLine(i);
            }
        }
    }
}
