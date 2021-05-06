using System;

namespace _04_StamentsAndLoops
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter 1 to print name, 2 to print house and anything else to print car");
            string word = Console.ReadLine();
            //checks to see if a varible equals a certain value
            if (word == "1")
            {
                Console.WriteLine("name");
            }
            //checks to see if the varible is a different value if the first check fails
            else if (word == "2")
            {
                Console.WriteLine("house");
            }
            //if both checks fails this will run 
            else
            {
                Console.WriteLine("car");
            }
            Console.WriteLine("Enter Key to continue");
            word = Console.ReadLine();
            //this will run code until the varible equals "key"
            while (word != "Key")
            {
                Console.WriteLine("you did not enter Key");
                word = Console.ReadLine();
            }
            Console.WriteLine("you entered the Key");
            //this will run the code until i is equal to 10
            //the first part defines the local varible
            //the second part defines when it will stop
            //the third part defines what will happen after each loop
            for (int i = 0; i <= 10; i++) {
                Console.WriteLine(i);            
            }
        }
    }
}
