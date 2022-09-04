public abstract class DbConnection
{
    public string? ConnectionString { get; set; }
    public TimeSpan Timeout { get; set; }
        public DbConnection(string?  connectionString, TimeSpan timeout)
    {
        this.ConnectionString = connectionString;
        this.Timeout = timeout;
    }
    public abstract void Opened();
    public abstract void Closed();
}