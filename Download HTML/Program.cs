using System;
using System.IO;
using System.Net;

namespace Download_HTML
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            string urlAddress = "https://xesaoviet.com.vn/gioi-thieu";
            var html = new WebClient()
                .DownloadString(urlAddress);
            File.WriteAllText(@"D:\localfiles.html", html);
            Console.WriteLine(html);
            Console.ReadLine();
        }
    }
}