using System;

namespace DatabaseConnection
{

    class Program
    {
        static void Main(string[] args)
        {
            var commandOne = new DbCommand(new SqlConnection("localhost: "), "select * from table");
            var commandTwo = new DbCommand(new OracleConnection("localhost: "), "select * from table");

            commandOne.Execute();
            commandTwo.Execute();
        }
    }
}
