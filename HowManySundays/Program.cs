using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HowManySundays
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("{0}", howManySundays(3, "Saturday"));
            Console.ReadLine();
        }
         private static string[] E = new string[] { "Sunday", "Monday", "Tuesday", "Wednesday", "Thurday", "Friday", "Saturday" };
        /// <summary>
        /// Tính số ngày chủ nhật sau số ngày nhất định
        /// </summary>
        /// <param name="n">Số ngày</param>
        /// <param name="startDay">ngày bắt đầu</param>
        /// <returns></returns>
         private static int howManySundays(int n, string startDay)
        {
            int startIndex = 0;

            for (int i = 0; i < E.Length; i++)
            {
                if (E[i] == (startDay))
                {
                    startIndex = i;
                    break;
                }
            }
            return (n + startIndex) / E.Length;
        }
    }
}
