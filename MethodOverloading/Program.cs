﻿namespace MethodOverloading
{
    public class Program
    {
        public static int Add(int numOne, int numTwo)
        {
            return numOne + numTwo;
        }

        public static decimal Add(decimal numOne, decimal numTwo)
        {
            return numOne + numTwo;
        }

        public static string Add(int numOne, int numTwo, bool isCurrency)
        {
            var sum= numOne + numTwo;

            if (isCurrency == true && sum > 1)
            {
                return $"{sum} dollars";
            }
            else if (isCurrency && sum == 1)
            {
                return $"{sum} dollar";
            }
            else if (isCurrency == true && sum < 1)
            {
                return $"{sum} dollars";}
            else
            {
                return sum.ToString();
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine(Add(2, 2, isCurrency: true));
            Console.WriteLine(Add(3, 4));
            Console.WriteLine(Add(2.5m, 3.5m));
        }
    }
}
