using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Permutation
{
    class Program
    {
        /*
         * Given a permutation, produce its inverse permutation.
         * Input: [9, 3, 5, 7, 6, 1, 8, 4, 2]
         * Output: [6, 9, 2, 8, 3, 5, 4, 7, 1]
         * 
         * 9 nằm ở vị trí 0+1 = > đặt 0+1 vào vị trí thứ 9-1
         *
         * 3 ở vị trí 1+1 => đặt 0+2 vào vị trí 3-1
         * 
         * 5 ở vị trí 2+1 => đặt 2+1 vào vị trí 5-1
         *
         * ...
         */
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            Console.WriteLine("CodeFight Challenges");

            int[] arrInput = {9, 3, 5, 7, 6, 1, 8, 4, 2};
            Console.Write("Mảng đầu vào : [\t");
            foreach (var item in arrInput)
            {
                Console.Write(item+"\t");
            }
            Console.Write("]");

            var arrNew = inversePermutation(arrInput);
            Console.Write("\nMảng kết quả : [\t");
            foreach (var item in arrNew)
            {
                Console.Write(item + "\t");
            }
            Console.Write("]");



            Console.ReadLine();
        }

        private static int[] inversePermutation(int[] permutation)
        {
            int[] arr = new int[permutation.Length];
            for (int i = 0; i < permutation.Length; i++)
            {
                arr[permutation[i] - 1] = i + 1;
                Console.Write("\nĐặt số {0} vào vị trí thứ {1}",i+1, permutation[i]);
            }
            return arr;
        }
    }
}
