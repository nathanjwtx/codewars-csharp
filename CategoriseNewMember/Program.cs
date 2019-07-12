using System;
using System.Collections.Generic;

namespace CategoriseNewMember
{
    class Program
    {
        static void Main(string[] args)
        {
            var result = Kata.OpenOrSenior(new int[][] {new int[] {18, 20}, new int[] {45, 2}, new int[] {61, 12}, new int[] {37, 6}, new int[] {21, 21}, new int[] {78, 9}});
            
            foreach (var v in result)
            {
                Console.WriteLine(v);
            }
        }
    }

    public class Kata
    {
        public static IEnumerable<string> OpenOrSenior(int[][] data)
        {
            string[] result = new string[data.Length];

            for (var i = 0; i < data.Length; i++)
            {
                if (data[i][0] >= 55 && data[i][1] > 7)
                {
                    result[i] = "Senior";
                }
                else
                {
                    result[i] = "Open";
                }
            }
            
            return result;
        }
    }
}
