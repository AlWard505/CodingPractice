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
                    continue;
                }

                if (i == 8)
                {
                    break;
                }
                Console.WriteLine(i);
            }
        }
    }
}
