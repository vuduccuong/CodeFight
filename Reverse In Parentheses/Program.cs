using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reverse_In_Parentheses
{
    class Program
    {
        static void Main(string[] args)
        {
            string a = "123(bda)34";
            int startIndex = a.IndexOf('(');
            int endIndex = a.IndexOf(')');
            List<string> stringReverse=new List<string>();

            for (int i = startIndex+1; i < endIndex; i++)
            {
                stringReverse.Add(a[i].ToString());
            }

            List<string> arrReverse = new List<string>();
            for (int i = stringReverse.Count()-1; i >= 0; i--)
            {
                arrReverse.Add(stringReverse[i]);
            }

            string newString = string.Join(",", stringReverse.ToArray()).Replace(",","");
            string oldString = string.Join(",", arrReverse.ToArray()).Replace(",","");

            Console.WriteLine(newString.ToString());
            Console.WriteLine(oldString.ToString());

            string b = a.Replace(newString.ToString(), oldString.ToString());

            for (int i = 0; i < b.Length; i++)
            {
                Console.WriteLine(b[i]);
            }
            Console.ReadLine();
        }
    }
}
