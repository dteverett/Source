using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace DataConnection
{
    public static class SecondaryConnection
    {
        static SqlConnection dataConnection = new SqlConnection();

        public static void Write()
        {
            try
            {
                
            }
            catch (Exception ex)
            {

                Console.WriteLine("Error accessing database: {0}", ex.Message);
            }
        }

        public static void Read(string sqlCommand)
        {
            try
            {

            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: {0}", ex.Message);
                
            }

        }
    }
}
