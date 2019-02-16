using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SlipByValue
{
    class Program
    {
        /// <summary>
        /// Chọn caffe thừ máy bán hàng tự động
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            System.Diagnostics.Stopwatch st = new System.Diagnostics.Stopwatch();
            st.Reset();
            st.Start();
            string cf = myCoffee(2);
            st.Stop(); // kết thúc đo thời gian
            long timeelapsed = st.ElapsedMilliseconds; // thời gian thực hiện
            Console.WriteLine(cf + "\nThoi gian thuc hien {0}", timeelapsed);
            Console.ReadLine();
        }
        private static string myCoffee(int number)
        {
            return (number == 1) ? "French Roast" : (number == 2) ? "Colombian" : "Kona";
        }
        static string myCoffee1(int n) =>
            n < 2 ? "French Roast" : n < 3 ? "Colombian" : "Kona";
    }
   
}
