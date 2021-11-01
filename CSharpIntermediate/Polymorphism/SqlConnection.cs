using System;

namespace CSharpIntermediate
{
    public class SqlConnection : DbConnection
    {
        public SqlConnection(string connectionString)
            : base(connectionString)
        {

        }
        public override void Open()
        {
            Console.WriteLine("SQL Server connection opened.");
        }

        public override void Close()
        {
            Console.WriteLine("SQL Server connection closed.");
        }
    }
}
