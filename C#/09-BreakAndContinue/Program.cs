using System;

namespace _09_BreakAndContinue
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 10; i++)
            {
                if (i == 2)
                {
                    //this pauses the code for this one loop
                    continue;
                }

                if (i == 8)
                {
                    //this stops the loop entirely
                    break;
                }
                Console.WriteLine(i);
            }
        }
    }
}
