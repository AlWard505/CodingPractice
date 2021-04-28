using System;

namespace _04_Statments
{
    class Program
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine();
            if (word == "1")
            {
                Console.WriteLine("it worked");
            }
            while (word != "Key")
            {
                word = Console.ReadLine();
                Console.WriteLine("you did not enter Key");
            }
            Console.WriteLine("you entered the Key");
        }
    }
}
