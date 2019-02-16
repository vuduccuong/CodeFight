using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alternating_Sums
{
    class Program
    {
        /*
         * chia người vào 2 team.
         * Có 1 hàng các bạn học sinh,
         * Mảng đầu vào là cân nặng của từng bạn học sinh
         * Hãy chia làm 2 đội theo yêu cầu: người thứ 1 đi vào team 1, người thứ 2 đi vào team 2, người thứ 3 vào team 1,...
         *
         * Trả về 1 mảng mới gồm 2 phần tử là tổng cân nặng của từng team
         * 
         * Input: [50, 60, 60, 45, 70]
         * Output:[180, 105]
         */
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.Write("Mảng đầu vào: [\t");
            int[] a = { 50, 60, 60, 45, 70 };
            for (int i = 0; i < a.Length; i++)
            {
                Console.Write(a[i] + "\t");
            }
            Console.Write("]\n");
            Console.Write("Mảng kết quả: [\t");
            for (int i = 0; i < alternatingSums(a).Length; i++)
            {
                Console.Write(alternatingSums(a)[i]+"\t");
            }
            Console.Write("]");

            Console.ReadLine();
        }

        private static int[] alternatingSums(int[] a)
        {
            int teamOne = 0;
            int teamTwo = 0;
            List<int> Result = new List<int>();
            for (int i = 0; i < a.Length; i += 2)
            {
                teamOne = teamOne + a[i];
            }
            for (int j = 1; j < a.Length; j += 2)
            {
                teamTwo = teamTwo + a[j];
            }
            Result.Add(teamOne);
            Result.Add(teamTwo);

            return Result.ToArray();
        }
    }
}
