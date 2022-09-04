var sql = new SqlConnection("",TimeSpan.FromSeconds(20));
sql.Opened();
var command = new DbCommand(DbConnection.,"");
command.Execute();
var Mysql = new MySqlConnection("",TimeSpan.FromSeconds(20));
Mysql.Closed();