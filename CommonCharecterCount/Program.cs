using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonCharecterCount
{
    class Program
    {
        /*
         * Cho 2 chuỗi string. Đếm số ký tự chung trong chúng

        *Example

        *For s1 = "aabcc" and s2 = "adcaa", the output should be
        *commonCharacterCount(s1, s2) = 3.

        *Strings have 3 common characters - 2 "a"s and 1 "c".
         */
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            string firstString = "aabcc";
            string secondString = "adcaa";
            Console.WriteLine("Số ký tự giống nhau là : {0}", commonCharacterCount(firstString, secondString));
            Console.ReadLine();
        }
        /*
         * Ý tưởng: Tạo một biến đếm
         * Lặp string 1:
         * duyệt từng phần tử của string 1
         * lặp string 2:
         * duyệt từng phần tử của string 2;
         * Nếu phần tử thứ i trong string 1 = phần tử thứ j trong string 2
         * đếm ++,
         * Xoá phần tử thứ j trong sring2,
         * j++
         * thoát vòng lặp
         * i++
         *thoát vòng lặp
         * Trả về biến đếm
         */
        private static int commonCharacterCount(string firstString, string secondString)
        {
            int count = 0;
            for (int i = 0; i < firstString.Length; i++)
            {
                for (int j = 0; j < secondString.Length; j++)
                {
                    if (firstString[i]==secondString[j])
                    {
                        secondString = secondString.Remove(j, 1);
                        count++;
                        break;
                    }
                }
            }

            return count;
        }
    }
}
