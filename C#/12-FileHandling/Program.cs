using System;
using System.IO;
namespace _12_FileHandling
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the name of the file that you will add to or create without the .txt extension");
            string filename = Console.ReadLine()+".txt";
            Console.WriteLine("enter what you will add to the file");
            string content = Console.ReadLine();
            //checks to see if the file exists
            if (File.Exists(filename))
            {
                //adds what you input onto the end of the file
                File.AppendAllText(filename, "\n" + content);
            }
            else
            {
                //overwrites all content in a file and replaces it with what you input
                //also creates a new file if the one input doesnt exist
                File.WriteAllText(filename, content);
            }

            //reads the content of the file and then prints it out
            Console.WriteLine(File.ReadAllText(filename));

        }
    }
}
