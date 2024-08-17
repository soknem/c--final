using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bank_Queue_Management_Systems
{
    static class Program
    {
        public static Queue <int> bankQueue = new Queue <int> ();
        public  static string displayNum = " ";
        //public static OleDbConnection Connection = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Bank Queue MS.mdb;Persist Security Info=False");
        //public static string userLogin = "";
        public static OleDbConnection Connection = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=BankQueueMS.mdb;Persist Security Info=False");
    
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Connection.Open();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Login());
        }
    }
}
