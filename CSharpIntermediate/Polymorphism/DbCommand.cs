using System;

namespace CSharpIntermediate
{
    public class DbCommand
    {
        public DbConnection Connection { get; set; }
        public String Instruction { get; set; }
        public DbCommand(DbConnection dbConnection, string instruction)
        {
            if (dbConnection == null)
                throw new InvalidOperationException("Database connection is null.");
            if (String.IsNullOrEmpty(instruction))
                throw new InvalidOperationException("Instruction is empty or null.");

            Connection = dbConnection;
            Instruction = instruction;
        }

        public void Execute()
        {
            Connection.Open();
            Console.WriteLine("Instructions executed. '{0}'", Instruction);
            Connection.Close();
        }
    }
}
