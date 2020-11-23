using System;

namespace DatabaseConnection
{

    public class SqlConnection : DbConnection
    {
        public SqlConnection(string connectionString) : base(connectionString)
        {
        }

        public override void Close()
        {
            Console.WriteLine("Sql connection is closed");
        }

        public override void Open()
        {
            Console.WriteLine("Sql connection is open with connection string {0}", _connectionString);
        }
    }
}
