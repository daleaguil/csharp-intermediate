using System;

namespace CSharpIntermediate
{
    public class OracleConnection : DbConnection
    {
        public OracleConnection(string connectionString)
            : base(connectionString)
        {

        }
        public override void Open()
        {
            Console.WriteLine("Oracle connection closed.");
        }

        public override void Close()
        {
            Console.WriteLine("Oracle connection closed.");
        }
    }
}
