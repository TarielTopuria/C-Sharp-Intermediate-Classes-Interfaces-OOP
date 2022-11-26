using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Intermediate_Classes_Interfaces_OOP
{
	public class DbCommand
	{
		public DbConnection DbConnection { get; set; }
		public string Instruction { get; set; }
		public DbCommand(DbConnection dbConnection, string instruction)
		{
			try
			{
				this.DbConnection = dbConnection;
			}
			catch (ArgumentNullException)
			{
				throw new ArgumentNullException("Db Connection is null");
			}

			if(string.IsNullOrEmpty(instruction))
			{
				throw new ArgumentNullException("instruction can't be null");
			}
			else
			{	
				this.Instruction = instruction;
			}
			
		}

		public void Execute()
		{
			DbConnection.OpeningConnection();
			Console.WriteLine(Instruction);
			DbConnection.ClosingConnection();
		}
	}
}
