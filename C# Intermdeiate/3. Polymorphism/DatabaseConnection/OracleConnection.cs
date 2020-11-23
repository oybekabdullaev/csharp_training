using System;

namespace DatabaseConnection
{
    public class OracleConnection : DbConnection
    {
        public OracleConnection(string connectionString) : base(connectionString)
        {
        }

        public override void Close()
        {
            Console.WriteLine("Oracle connection is closed");
        }

        public override void Open()
        {
            Console.WriteLine("Oracle connection is open with connection string {0}", _connectionString);
        }
    }
}
