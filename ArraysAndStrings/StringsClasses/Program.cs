using System;
namespace StringsClasses
{
    class Program
    {
        static void Main(string[] args)
        {
            //RecognizeGender();
            //CheckLength();
            //string test = "2,5,8,10";
            //int[] testResult = ConvertToArray(test);
            Console.WriteLine(ToSentence("thiS SenTence HAs craPPy Casing"));
        }
        public static string ToSentence(string input)
        {
            string temp = input.ToLower();
            return 
                temp.Substring(0, 1).ToUpper() + 
                temp.Substring(1);
        }
        public static int[] ConvertToArray(string input)
        {
            string[] temp = input.Split(",");
            int[] result = new int[temp.Length];
            for (int i = 0; i < temp.Length; i++)
            {
                result[i] = int.Parse(temp[i]);
            }
            return result;
        }
        private static void CheckLength()
        {
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
