using System;

namespace Mathmatics
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("pick the first number to add");
            float number1 = float.Parse(Console.ReadLine());
            Console.WriteLine("pick the second number to add");
            float number2 = float.Parse(Console.ReadLine());
            float addednum = number1 + number2;
            Console.WriteLine(addednum);

            Console.WriteLine("pick the number to subtract from");
            float number3 = float.Parse(Console.ReadLine());
            Console.WriteLine("pick the number to subtract");
            float number4 = float.Parse(Console.ReadLine());
            float subtractednum = number3 - number4;
            Console.WriteLine(subtractednum);

            Console.WriteLine("pick the number to multiply from");
            float number5 = float.Parse(Console.ReadLine());
            Console.WriteLine("pick the number to multiply by");
            float number6 = float.Parse(Console.ReadLine());
            float timesednum = number5 * number6;
            Console.WriteLine(timesednum);

            Console.WriteLine("pick the number to divide");
            float number7 = float.Parse(Console.ReadLine());
            Console.WriteLine("pick the number to divide by");
            float number8 = float.Parse(Console.ReadLine());
            float dividednum = number7 / number8;
            Console.WriteLine(dividednum);
        }
    }
}
