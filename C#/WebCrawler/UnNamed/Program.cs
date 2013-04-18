using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using DataConnection;
using System.IO;

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
            string contents;
            string _URL = "http://en.wikipedia.org/wiki/Main_Page";
            WebConnection.GetFile(_URL, path);

            string file = File.ReadAllText(path);
            try
            {
                int counter = 0;

                DataClassDataContext db = new DataClassDataContext();

                WebID_T web = new WebID_T();
                web.DateAccessed_DT = System.DateTime.Now;
                web.URL = _URL;
                web.Entry_ID = ++counter;
                db.WebID_Ts.InsertOnSubmit(web);

                db.SubmitChanges();

                URL_T url = new URL_T();// {TextContent_VC = file};
                url.DateAccessed_DT = System.DateTime.Now;
                url.URL_VC = _URL;
                db.URL_Ts.InsertOnSubmit(url);

                
                db.SubmitChanges();
                
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
                Console.Read();
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
