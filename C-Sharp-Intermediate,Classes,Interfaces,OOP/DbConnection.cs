using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Intermediate_Classes_Interfaces_OOP
{
    public abstract class DbConnection
    {
        private readonly string ConnectionString;
        public TimeSpan TimeOut { get; set; }

        public DbConnection(string ConnectionString)
        {
            if (string.IsNullOrEmpty(ConnectionString))
            {
                throw new Exception("string is null or empty");
            }
            else
            {
                this.ConnectionString = ConnectionString;
            }
            
        }
        public abstract void OpeningConnection();
        public abstract void ClosingConnection();
    }
}
