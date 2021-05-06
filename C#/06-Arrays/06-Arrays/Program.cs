using System;

namespace _06_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            // this defines an array and the contents
            string[] Names = { "stan", "greg", "steve" };
            // this for loop will run an amount of times equal to the length of the array
            for(int i = 0;i < Names.Length; i++)
            {
                //this will print the value that i is equal to 
                //if i is equal to 1 it will print "greg"
                Console.WriteLine(Names[i]);
            }
        }
    }
}
