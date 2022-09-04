public class MySqlConnection : DbConnection
{
    public MySqlConnection(string? connectionString, TimeSpan timeout) :base(connectionString,timeout)
    {
        
    }
    public override void Opened()
    {
        System.Console.WriteLine("MysqlConnection is open");
    }

    public override void Closed()
    {
        System.Console.WriteLine("MysqlConnection is closed");
    }
}