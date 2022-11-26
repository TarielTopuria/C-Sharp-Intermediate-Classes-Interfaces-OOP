using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Intermediate_Classes_Interfaces_OOP
{
    public class SqlConnection : DbConnection
    {
        public SqlConnection(string ConnectionString) : base(ConnectionString)
        {

        }
        public override void OpeningConnection()
        {
            Console.WriteLine("SQL Connection is Opend");
        }
        public override void ClosingConnection()
        {
            Console.WriteLine("SQL Connection is Closed");
        }
    }
}
