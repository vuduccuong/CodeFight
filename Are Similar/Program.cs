using System;

namespace Are_Similar
{
    internal class Program
    {
        /*
         * Hai mảng được coi là giống nhau nếu hoán đổi tối đa 1 cặp ở mảng này thì được mảng kia
         * input: [1,2,3] và [2,1,3]
         * output: true (vì hoán đổi số 1 và 2 ở mảng 1 thì được mảng 2
         */

        private static void Main(string[] args)
        {
            int[] a = { 832, 998, 148, 570, 533, 561, 894, 147, 455, 279 };
            int[] b = { 832, 570, 148, 998, 533, 561, 455, 147, 894, 279 };
            Console.Write(areSimilar(a, b));
            Console.ReadLine();
        }

        private static bool areSimilar(int[] a, int[] b)
        {
            var difference = 0;//Số điểm khác biệt giữa A và B
            var firstNumber = 0;//2 biến này để lưu 2 vị trí mà A và B cần swap (nếu có)
            var secondNumber = 0;
            for (int i = 0; i < a.Length; i += 1)
                if (a[i] != b[i])
                {
                    difference += 1;
                    if (difference == 1)
                        firstNumber = i;
                    else
                    if (difference == 2)
                        secondNumber = i;
                }
            if (difference == 0)
                return true;
            if (difference != 2)
                return false;
            if (a[firstNumber] != b[secondNumber])
                return false;
            if (a[secondNumber] != b[firstNumber])
                return false;
            return true;
        }
    }
}