using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace isLuckyNumber
{
    class Program
    {
        /*
         * Kiểm tra một số có có phải là số may mắn hay không
         * đầu vào là một số có số các chữ số là số chẵn (1234; 111111)
         * Nếu tổng của số các chữ số nửa đầu bằng tổng các chữ số nửa sau thì là số may mắn
         * Input: 123600
         * Output: true;
         */
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;
            int a;
            int.TryParse(Console.ReadLine(), out a);
            if (isLucky(a))
            {
                Console.WriteLine("Is lucky number");
            }


            Console.ReadLine();
           
        }

        

        static int checkNumber(int n)
        {
            int count = 0;
            while (n > 0)
            {
                n = n / 10;
                count++;
            }
            return count;
        }
        private static bool isLucky(int n)
        {
            int sumInLeftNumber = 0;
            int sumInRightNumber = 0;

            int halfNumber = checkNumber(n) / 2;

            List<int> firstList = new List<int>();

            List<int> secondList = new List<int>();

            string newN = n.ToString();

            for (int i = 0; i < halfNumber; i++)
            {
                firstList.Add(newN[i]);
            };
            for (int j = halfNumber; j < checkNumber(n); j++)
            {
                secondList.Add(newN[j]);
            };

            foreach (int numberInFirstList in firstList)
            {
                sumInLeftNumber = sumInLeftNumber + numberInFirstList;
            }
            foreach (int numberInSecondList in secondList)
            {
                sumInRightNumber = sumInRightNumber + numberInSecondList;
            }

            if (sumInLeftNumber == sumInRightNumber)
                return true;
            else return false;
        }
    }

}

