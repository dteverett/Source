using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DataConnection
{
    public class Connection
    {
        public WebInformationEntities _connection;

        public Connection()
        {
            _connection = new WebInformationEntities();
        }
    }
}
