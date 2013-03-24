using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Linq;
using System.Data.Linq.Mapping;

namespace DatabaseConnection
{

    //[Table(UriHostNameType = "Tests")]
    //public class Tests
    //{
    //    private int _logID;
    //    [Column(IsPrimaryKeytrue, Storage = "_logID")]
    //    public int LogID
    //    {
    //        get { return this._logID; }
    //        set { this._logID = value; }
    //    }

    //    private string _DateCreated_DT;
    //    [Column(Storage = "_DateCreated_DT")]
    //    public string DateCreated_DT
    //    {
    //        get { return this._DateCreated_DT; }
    //        set { this._DateCreated_DT = value; }
    //    }
    //}


    class Program
    {
        static void Main(string[] args)
        {
            //Connection connect = new Connection();

            //Alternative Connection
            //DataContext db = new DataContext (@"C:\linqtest5\northwnd.mdf");
            Console.WriteLine("Enter a user name:");
            string uName = Console.ReadLine();
            
            
            
            DataClassDataContext db = new DataClassDataContext();

            Order_T order = new Order_T();
            order.OrderName_VC = uName;
            db.Order_Ts.InsertOnSubmit(order);
            db.SubmitChanges();



        }
    }
}
