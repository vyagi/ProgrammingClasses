using System;

namespace StringsClasses
{
    class Program
    {
        static void Main(string[] args)
        {
            //RecognizeGender();
            Console.WriteLine("What's your name");
            string name = Console.ReadLine();

            if (name.Length > 5)
            {
                Console.WriteLine("Your name is so long...");
            }
            else
            {
                Console.WriteLine("You have a nice short name");
            }
        }

        private static void RecognizeGender()
        {
            Console.WriteLine("What's your name");
            string name = Console.ReadLine();

            if (name.EndsWith("a") && name != "Kuba")
            {
                Console.WriteLine("Your a woman");
            }
            else
            {
                Console.WriteLine("Your a man");
            }
        }
    }
}
