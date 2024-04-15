
using System.Diagnostics;
using System.Runtime.ConstrainedExecution;
using MySql.Data.MySqlClient;

class DatabaseService {
    private MySql.Data.MySqlClient.MySqlConnection myConnection;
    private string myConnectionString = "server=127.0.0.1;uid=root;pwd=password;database=tamagotchi";
    private MySqlCommand cmd = new MySqlCommand();


    public MySql.Data.MySqlClient.MySqlConnection MySqlConn(){
        try{
            myConnection = new MySql.Data.MySqlClient.MySqlConnection(myConnectionString);

            myConnection.Open();
        }
        catch (MySql.Data.MySqlClient.MySqlException ex)
        {
            Debug.WriteLine("<<<catch Database: " + ex.ToString());
        }
        return myConnection;
        }
    }
