public class DbCommand
{
      DbConnection _conection;
    string? _command;
    public DbCommand(DbConnection connection,string? command)
    {
        this._conection = connection;
        this._command = command;
    }
    public void Execute(){
        _conection.Opened();
        System.Console.WriteLine("Run the instruction " +_command);
        _conection.Closed();
    }
}