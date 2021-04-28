using System;

namespace _04_StamentsAndLoops
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter 1 to print name");
            string word = Console.ReadLine();
            if (word == "1")
            {
                Console.WriteLine("name");
            }

            word = Console.ReadLine();
            while (word != "Key")
            {
                word = Console.ReadLine();
                Console.WriteLine("you did not enter Key");
            }
            Console.WriteLine("you entered the Key");

            for (int i = 0; i <= 10; i++) {
                Console.WriteLine(i);            
            }
        }
    }
}
