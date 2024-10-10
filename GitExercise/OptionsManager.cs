using System;
using System.IO.IsolatedStorage;
using System.Reflection.Metadata.Ecma335;

namespace GitExercise
{
    public static class OptionsManager
    {
        public static string[] OptionsList = {
            "a - Add",
            "s - Subtract",

            "dr - Divide Manager",
            "ex - Exit",
            "m - Multiply",
            "d - Divide",
            "sabs - SubtractAbs"

            "m - Multiply",
                "pow - Power",
                "log - Logaritham",
                "fact - Sum of 2 factorials"


        };

        public static void Add(double a, double b)
        {
            Console.WriteLine($"{a} + {b} = {a + b}");
        }

        public static void Multiply(double a, double b)
        {
            Console.WriteLine($"{a} x {b} = {a * b}");
        }

        public static void Subtract(double a, double b)
        {
            Console.WriteLine($"{a} - {b} = {a - b}");
        }


        public static void Divide(double a, double b)
        {
            Console.WriteLine($"{a} : {b} = {a / b}");
        }

        public static void SubtractAbs(double a, double b)
        {
            Console.WriteLine($"|{a} - {b}| = {Math.Abs(a - b)}");
        }
        private static long CalculateFact(int a)
        {
            long result = a;
            for (int i = a - 1 ; i >= 1; i--)
            {
                result= result *i;

            }
            return result;

        }
    }
}
