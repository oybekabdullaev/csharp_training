using System;

namespace DatabaseConnection
{

    public abstract class DbConnection
    {
        protected readonly string _connectionString;
        public TimeSpan Timeout { get; set; }

        public DbConnection(string connectionString)
        {
            if (connectionString == null || connectionString.Length == 0)
                throw new InvalidOperationException("Please, provide a valid string");

            _connectionString = connectionString;
        }

        public abstract void Open();
        public abstract void Close();
    }
}
