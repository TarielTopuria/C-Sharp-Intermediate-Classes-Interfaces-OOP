using C_Sharp_Intermediate_Classes_Interfaces_OOP;

namespace CSharpCourse;

public class Program
{
    public static void Main(string[] args)
    {
        var sqlConnection = new SqlConnection("Some Sql ConnectionString");
        var sqlCommand = new DbCommand(sqlConnection, "Program Running On SQL Server");
        sqlCommand.Execute();

        var oracleConnection = new OracleConnection("Some Oracle ConnectionString");
        var oracleCommand = new DbCommand(oracleConnection, "Program Running On Oracle Server");
        oracleCommand.Execute();
    }
}