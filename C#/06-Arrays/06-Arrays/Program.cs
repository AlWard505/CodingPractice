using System;

namespace _06_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] Names = { "stan", "greg", "steve" };
            for(int i = 0;i < Names.Length; i++)
            {
                Console.WriteLine(Names[i]);
            }
        }
    }
}
