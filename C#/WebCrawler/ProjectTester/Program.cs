using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataConnection;

namespace ProjectTester
{
    class Program
    {
        static void Main(string[] args)
        {
            Connection connection = new Connection();

            var results = connection._connection.WebID_T.Where(x => x.Entry_ID != null).ToArray();

            foreach (var entry in results)
            {
                Console.WriteLine(entry.URL);
            }


            Console.Read();
        }
    }
}
