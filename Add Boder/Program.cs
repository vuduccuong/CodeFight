using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Add_Boder
{
    class Program
    {
        /*
         * Đưa ra một ma trận hình chữ nhật của các ký tự, thêm một đường viền của các dấu sao (*) cho nó.
         * Input: ["abc",
                   "ded"]
         * Output: ["*****",
                    "*abc*",
                    "*ded*",
                    "*****"]
         */
        static void Main(string[] args)
        {
            string[] inputStr = { "abc", "ded" };

            var outputStr = addBorder(inputStr);
        }

        private static string[] addBorder(string[] picture)
        {
            string[] newArr = new string[picture.Length + 2];
            string firstNlast = "";
            for (int i = 0; i < picture[0].Length + 2; i++)
            {
                firstNlast += "*";
            }

            newArr[0] = firstNlast;
            for (int i = 0; i < picture.Length; i++)
            {
                picture[i] = picture[i].Insert(0, "*");
                picture[i] += "*";
            }

            for (int i = 1; i < picture.Length + 1; i++)
            {
                newArr[i] = picture[i - 1];
            }
            newArr[picture.Length + 1] = firstNlast;

            return newArr;
        }

        //Tham khảo trên mạng Linq
        //var stars = new string[] { new string('*', picture[0].Length + 2) };
        //return stars.Concat(picture.Select(s => "*" + s + "*"))
        //.Concat(stars)
        //    .ToArray();
    }
}
