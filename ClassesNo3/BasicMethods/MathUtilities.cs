using System;
using System.Collections.Generic;
using System.Text;

namespace BasicMethods
{
    public static class MathUtilities
    {
        public static double SolveLinearEquation(double a, double b)
        {
            return a == 0 ? 0 : -b / a;
        }
        public static int GetBiggerNumber(int a, int b)
        {
            return a > b ? a : b;
        }
        public static int GCD(int a, int b)
        {
            while(a != b)
            {
                if (a > b)
                    a -= b;
                else
                    b -= a;
            }
            return a;
        }
        public static bool IsPrime(int a)
        {
            if (a < 2)
                return false;

            for (int i = 2; i < a; i++)
            {
                if (a % i == 0)
                    return false;
            }
            return true;
        }
    }
}
