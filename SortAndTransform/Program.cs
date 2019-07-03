using System;

namespace SortAndTransform
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = {97, 2, 25, 24};
            Console.WriteLine(SortAndTransform(numbers));
        }

        private static string SortAndTransform(int[] numbers)
        {
            string result = string.Empty;
            string stringOne = String.Empty;

            result = Convert.ToChar(numbers[0]).ToString();

            return result;
        }
    }
}