
using System.Diagnostics;
using System.Runtime.ConstrainedExecution;
using MySql.Data.MySqlClient;

class Database {
    private MySql.Data.MySqlClient.MySqlConnection myConnection;
    private MySqlCommand myCommand = new MySqlCommand();
    private string myConnectionString = "server=127.0.0.1;uid=root;pwd=password;database=tamagotchi";

    public MySql.Data.MySqlClient.MySqlConnection MySqlConn(){
        try{
            myConnection = new MySql.Data.MySqlClient.MySqlConnection(myConnectionString);

            myConnection.Open();
        }catch(MySql.Data.MySqlClient.MySqlException ex){
            Debug.WriteLine("<<<catch Database: " + ex.ToString());
        }
        return myConnection;
    }
    public void LoadData(){
        myConnection = this.MySqlConn();
        myCommand.Connection = myConnection;
        myCommand.CommandText = @"SELECT * FROM pet";

        using var myReader = myCommand.ExecuteReader();
        while(myReader.Read()){
            System.Console.WriteLine(myReader.GetString("name"));
            System.Console.WriteLine(myReader.GetInt32("age"));

        }
        myConnection.Close();
    }

    public void SaveData(string name, int age){
        myConnection = this.MySqlConn();
        myCommand.Connection = myConnection;
        myCommand.CommandText = $@"insert into pet (name, age) values ({name}, {age})* FROM pet";

        using var myReader = myCommand.ExecuteReader();
        while(myReader.Read()){
            System.Console.WriteLine(myReader.GetString("name"));
            System.Console.WriteLine(myReader.GetInt32("age"));

        }
        myConnection.Close();

    }
    }
