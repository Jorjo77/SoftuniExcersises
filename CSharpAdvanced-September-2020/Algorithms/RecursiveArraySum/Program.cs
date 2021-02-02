using System;
using System.Linq;

namespace RecursiveArraySum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int startIndex = 0;
            Console.WriteLine(SumArray(input, startIndex));
        }

        private static int SumArray(int[] input, int index)
        {
            if (index==input.Length)
            {
                return 0;
            }

            int result = input[index] + SumArray(input, index + 1);
            return result;
        }
    }
}
