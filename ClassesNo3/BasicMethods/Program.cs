using System;
using static BasicMethods.MathUtilities;

namespace BasicMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(SolveLinearEquation(3, 6));
            Console.WriteLine(GetBiggerNumber(10,7));
            Console.WriteLine(GetBiggerNumber(-20,8));
            
            Console.WriteLine(GCD(56,56));

            Console.WriteLine(IsPrime(17));
            Console.WriteLine(IsPrime(18));

            Console.WriteLine(AreCoprime(8,9));
            Console.WriteLine(AreCoprime(8,10));
        }
    }
}
