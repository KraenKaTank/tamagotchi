
using MySql.Data.MySqlClient;
class PetAPI{
    private Database db = new Database();
    private MySql.Data.MySqlClient.MySqlConnection myConnection;
    
    private MySqlCommand myCommand = new MySqlCommand();

    
        public void LoadData()
    {
        myConnection = db.MySqlConn();
        myCommand.Connection = myConnection;
        myCommand.CommandText = @"SELECT * FROM pet";

        using var myReader = myCommand.ExecuteReader();
        while (myReader.Read())
        {
            System.Console.WriteLine(myReader.GetString("name"));
            System.Console.WriteLine(myReader.GetInt32("age"));

        }
        myConnection.Close();
    }

    public void SaveData(string name, int age)
    {
        myConnection = db.MySqlConn();
        myCommand.Connection = myConnection;
        myCommand.CommandText = $@"insert into pet (name, age) values ({name}, {age})* FROM pet";

        using var myReader = myCommand.ExecuteReader();
        while (myReader.Read())
        {
            System.Console.WriteLine(myReader.GetString("name"));
            System.Console.WriteLine(myReader.GetInt32("age"));

        }
        myConnection.Close();
    }
}