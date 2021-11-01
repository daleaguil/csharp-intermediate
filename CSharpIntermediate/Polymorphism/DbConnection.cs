using System;

namespace CSharpIntermediate
{
    public abstract class DbConnection
    {
        public string ConnectionString { get; set; }
        public TimeSpan Timeout { get; set; }
        public DbConnection(string connectionString)
        {
            if (connectionString == null)
                throw new InvalidOperationException("Connection string cannot be empty.");
            ConnectionString = connectionString;
        }
        public abstract void Open();
        public abstract void Close();

    }
}
