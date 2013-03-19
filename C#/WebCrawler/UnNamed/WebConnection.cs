using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace WebCrawler
{
    class WebConnection
    {
        public static void GetFile(string strURL, string strFilePath)
        {
            WebRequest myWebRequest = WebRequest.Create(strURL);
            WebResponse myWebResponse = myWebRequest.GetResponse();
            Stream ReceiveStream = myWebResponse.GetResponseStream();
            Encoding encode = System.Text.Encoding.GetEncoding("utf-8");
            StreamReader reader = new StreamReader(ReceiveStream, encode);
            string strResponse = reader.ReadToEnd();
            StreamWriter writer = new StreamWriter(strFilePath);
            writer.WriteLine(strResponse);
            writer.Close();
            reader.Close();
            myWebResponse.Close();
        }
    }
}
