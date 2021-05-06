using System;

namespace _02_Varibles
{
    class Program
    {
        static void Main(string[] args)
        {
            //defines a varible
            string varible1 = "howdie planet";            
            Console.WriteLine(varible1);

            //changes varible to input
            varible1 = Console.ReadLine();
            Console.WriteLine(varible1);
        }
    }
}
