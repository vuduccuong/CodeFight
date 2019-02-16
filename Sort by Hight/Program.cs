using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sort_by_Hight
{
    class Program
    {
        /*
         * Có một số người đứng dưới một hàng cây
         * Hãy sắp xếp người theo chiều cao tăng dần (vị trí của cây không được thay đổi)
         *
         * Input: [1,3,-1,4,-1,-1,2,9]
         * Output:[1,2,-1,3,-1,-1,4,9]
         */
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;
            int[] arrNumber = new[] { 1, 3, -1, 4, -1, -1, 2, 9 };
            Console.Write("Mảng đầu vào : [\t");
            for (int i = 0; i < arrNumber.Length; i++)
            {
                Console.Write(arrNumber[i] + "\t");
            }
            Console.Write("]\n");

            var sortArr = sortByHeight(arrNumber);

            Console.Write("Mảng sắp xếp : [\t");
            for (int i = 0; i < sortArr.Length; i++)
            {
                Console.Write(sortArr[i] + "\t");
            }
            Console.Write("]");
            Console.ReadLine();
        }

        private static int[] sortByHeight(int[] a)
        {
            int swap = 0;

            for (int i = 0; i < a.Length; i++)
            {
                for (int j = i; j < a.Length; j++)
                {
                    if (a[i] == -1 || a[j] == -1)
                    {
                        continue;
                    }
                    else if (a[i] > a[j])
                    {

                        swap = a[i];
                        a[i] = a[j];
                        a[j] = swap;

                    }
                }
            }
            return a;
        }
    }
}
