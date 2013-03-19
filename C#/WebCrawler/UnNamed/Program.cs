using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebCrawler
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"D:\input\text.txt";
            string URL = "http://en.wikipedia.org/wiki/Main_Page";
            WebConnection.GetFile(URL, path);
        }



    }
}
