using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Linq;
using System.Data.Linq.Mapping;
using System.Data.SqlClient;


namespace WebCrawler
{
    internal class DLINQ
    {
        //static void Main(string[] args)
        //{
        //   DatabaseConnection connection = new DatabaseConnection();

        //}
    }

    [Table(Name = "Orders_T")]
    public class Order
    {
        [Column(IsPrimaryKey = true, CanBeNull = false)]
        public int OrderID { get; set; }

        [Column]
        public string CustomerID { get; set; }

        [Column]
        public DateTime? OrderDate { get; set; }

        [Column]
        public string ShipName { get; set; }

        [Column]
        public string ShipAddress { get; set; }

        [Column]
        public string ShipCity { get; set; }

        [Column]
        public string ShipCountry { get; set; }
    }

    public class WebOrders : DataContext
    {
        public Table<Order> Orders;

        public WebOrders(string connectionInfo) : base(connectionInfo)
        {
            
        }
    }

}
