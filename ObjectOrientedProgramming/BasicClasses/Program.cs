using System;

namespace BasicClasses
{
    public class Person
    {
        private int Height; //field
        private int Weight; //field 
        public Person(int height, int weight) //constructor
        {
            if (height <= 0 || weight <= 0)
                throw new ArgumentException("The height and weight must be positive");

            Height = height;
            Weight = weight;
        }
        public int BMI() //method
        {
            return 10000 * Weight / (Height * Height);
        }
        public string Classification() //method
        {
            int bmi = BMI();
            if (bmi < 18)
                return "Underweight";
            if (bmi < 24)
                return "Normal";
            if (bmi < 30)
                return "Overweight";
            return "Obese";
        }
        public string Recommendation() //method
        {
            int bmi = BMI();
            if (bmi < 18)
                return "You should eat more";
            if (bmi < 24)
                return "Good job";
            if (bmi < 30)
                return "You should eat less";
            return "Stop eating";
        }
        public int GetHeight()
        {
            return Height;
        }
        public int GetWeight()
        {
            return Weight;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Person marcin = new Person(178, 78);

            Console.WriteLine($"BMI for {marcin.GetWeight()} weight and {marcin.GetHeight()} height is {marcin.BMI()}");
            Console.WriteLine($"Classification is {marcin.Classification()}");
            Console.WriteLine($"Recommendation is {marcin.Recommendation()}");
        }
    }
}
