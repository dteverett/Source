using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using DataConnection;

namespace WebCrawler
{
    class Program
    {
        static Connection connection = new Connection();
        static void Main(string[] args)
        {
            Initialize();
        }

        private static void Initialize()
        {
            string path = @"D:\input\text.txt";
            string URL = "http://en.wikipedia.org/wiki/Main_Page";
            WebConnection.GetFile(URL, path);

            try
            {
                
            }
            catch (Exception ex)
            {

                try
                {
                    
                }
                catch (Exception)
                {
                    
                    throw;
                }
            }
        }



    }
}
