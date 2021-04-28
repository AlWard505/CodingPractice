using System;

namespace _05_Combination
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter '*' to multiply two values\nEnter '/' to divide two values\nEnter '-' to subtract one value from another\nEnter '+' to add two values\nEnter '?' to get this message again\nEnter 'End' to end the program");
            string Entry = Console.ReadLine();
            while(Entry != "End")
            {
                if (Entry == "*")
                {
                    Console.WriteLine("enter the value you want to multiply");
                    float valone = float.Parse(Console.ReadLine());
                    Console.WriteLine("enter the multiple");
                    float valtwo = float.Parse(Console.ReadLine());
                    float valthree = valone * valtwo;
                    Console.WriteLine(valthree);
                }
                else if (Entry == "/")
                {
                    Console.WriteLine("enter the value you want to divide");
                    float valone = float.Parse(Console.ReadLine());
                    Console.WriteLine("enter the value you want to divide by");
                    float valtwo = float.Parse(Console.ReadLine());
                    float valthree = valone / valtwo;
                    Console.WriteLine(valthree);
                }
                else if (Entry == "-")
                {
                    Console.WriteLine("enter the value you want to subtract from");
                    float valone = float.Parse(Console.ReadLine());
                    Console.WriteLine("enter the value you want to subtract");
                    float valtwo = float.Parse(Console.ReadLine());
                    float valthree = valone - valtwo;
                    Console.WriteLine(valthree);
                }
                else if (Entry == "+")
                {
                    Console.WriteLine("enter the value you want add to");
                    float valone = float.Parse(Console.ReadLine());
                    Console.WriteLine("enter the value you want to add");
                    float valtwo = float.Parse(Console.ReadLine());
                    float valthree = valone + valtwo;
                    Console.WriteLine(valthree);
                }
                else if (Entry == "?")
                {
                    Console.WriteLine("Enter '*' to multiply two values\nEnter '/' to divide two values\nEnter '-' to subtract one value from another\nEnter '+' to add two values\nEnter '?' to get this message again\nEnter 'End' to end the program");
                }
                Entry = Console.ReadLine();
            }
        }
    }
}
