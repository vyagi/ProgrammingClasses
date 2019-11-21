using System;
namespace ArrarysClasses
{
    class Program
    {
        static void Main(string[] args)
        {
            //FirstExample();
            //SecondExample();
            //ThirdExample();


        }

        private static void ThirdExample()
        {
            double[] weekTemperatures = { 8.7, 9, 6, 5.3, 5, 5, 1 };
            double[] reverted = new double[7];

            for (int i = 0; i < weekTemperatures.Length; i++)
            {
                reverted[i] = weekTemperatures[6 - i];
            }

            DisplayArray(reverted);
        }

        private static void SecondExample()
        {
            double[] weekTemperatures = { 8.7, 9, 6, 5.3, 5, 5, 1 };
            double sum = 0;
            foreach (double temperature in weekTemperatures)
            {
                sum += temperature;
            }

            double averageTemperature = sum / weekTemperatures.Length;

            Console.WriteLine($"Average temperature is {averageTemperature}");
        }

        private static void FirstExample()
        {
            int[] myArray = new int[3];
            DisplayArray(myArray);

            myArray[0] = 10;
            myArray[1] = 18;
            myArray[2] = 21;

            DisplayArray(myArray);

            for (int i = 0; i < myArray.Length; i++)
                myArray[i] = myArray[i] + 3;

            DisplayArray(myArray);
        }
        private static void DisplayArray<T>(T[] array) //this dirty trick with Generics will be explained later
        {
            foreach (var item in array)
                Console.WriteLine(item);
        }
    }
}
