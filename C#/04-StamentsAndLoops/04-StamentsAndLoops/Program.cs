using System;

namespace _04_StamentsAndLoops
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter 1 to print name, 2 to print house and anything else to print car");
            string word = Console.ReadLine();

            if (word == "1")
            {
                Console.WriteLine("name");
            }

            else if (word == "2")
            {
                Console.WriteLine("house");
            }

            else
            {
                Console.WriteLine("car");
            }
            Console.WriteLine("Enter Key to continue");
            word = Console.ReadLine();
            while (word != "Key")
            {
                Console.WriteLine("you did not enter Key");
                word = Console.ReadLine();
            }
            Console.WriteLine("you entered the Key");

            for (int i = 0; i <= 10; i++) {
                Console.WriteLine(i);            
            }
        }
    }
}
