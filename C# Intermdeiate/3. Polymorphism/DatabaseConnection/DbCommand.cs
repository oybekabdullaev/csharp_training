using System;

namespace DatabaseConnection
{
    public class DbCommand
    {
        private readonly DbConnection _dbConnection;
        private readonly string _instruction;

        public DbCommand(DbConnection dbConnection, string instruction)
        {
            if (dbConnection == null)
                throw new InvalidOperationException("Please, provide a valid database connection");

            if (instruction == null || instruction.Length == 0)
                throw new InvalidOperationException("Please, provide a valid instruction string");

            _dbConnection = dbConnection;
            _instruction = instruction;
        }

        public void Execute()
        {
            _dbConnection.Open();

            Console.WriteLine("Command {0} is executed", _instruction);

            _dbConnection.Close();
        }
    }
}
