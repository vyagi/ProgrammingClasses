using System;
using System.Linq;

namespace LinqBasics
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] grades = { 3.5, 5, 5, 2, 4, 4.5, 2, 3, 5, 4.5, 3.5 };
            //Features1(grades);
            //Features2(grades);

            string[] names = { "Eve", "Abdulla", "Boris", "Kateryna" };

            var sorted = names.OrderBy(x => x);
            foreach (var item in sorted)
            {
                Console.WriteLine(item);
            }
            var namesExist = names.Any(x => x.EndsWith("a"));

            var allNamesLong = names.All(x => x.Length > 1);

        }

        private static void Features2(double[] grades)
        {
            var myGoodGrades = grades
                            .Where(x => x > 3.5)
                            .OrderByDescending(x => x);

            var myFirstGrade = grades.First();
            var myLastGrade = grades.Last();
            var howManyTwos = grades.Count(x => x == 2);
            var myFavouriteGrades = grades.Skip(3).Take(3);

            var ectsPoints = grades
                .Where(x => x > 2)
                .Select(x => x * 2)
                .OrderBy(x => x);

            foreach (var item in ectsPoints)
                Console.WriteLine(item);
        }

        private static void Features1(double[] grades)
        {
            double max = grades.Max();

            var positiveGrades = grades.Where(x => x > 2);
            foreach (var grade in positiveGrades)
                Console.WriteLine(grade);

            var evenGrades = grades.Where(x => x % 2 == 0);
            foreach (var grade in evenGrades)
                Console.WriteLine(grade);

            Console.WriteLine(grades.Average());
        }
    }
}
