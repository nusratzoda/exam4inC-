public class SqlConnection : DbConnection
{
      public SqlConnection(string? connectionString, TimeSpan timeout) :base(connectionString,timeout)
    {
        
    }
    public override void Closed()
    {
        System.Console.WriteLine("SqlConnection is open");
    }

    public override void Opened()
    {
        System.Console.WriteLine("SqlConnection is closed");
    }
}