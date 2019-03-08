using System;

namespace Max_of_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            var arr = new int[] { 1, 3, 2 };
            Console.WriteLine(maxOfSumChain(arr, 2));
            Console.ReadLine();
        }

        private static int maxOfSumChain(int[] arr, int k)
        {
            var result = 0;
            var sum = 0;
            for (var i = 0; i < k - 1; i++)
            {
                sum += arr[i];
            }
            for (var i = k - 1; i < arr.Length; i++)
            {
                sum += arr[i];
                if (sum > result)
                {
                    result = sum;
                }
                sum -= arr[i - k + 1];
            }
            return result;
        }
    }
}
