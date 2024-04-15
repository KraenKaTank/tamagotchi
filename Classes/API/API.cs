using System.Data.Common;
using MySql.Data.MySqlClient;
using Tamagotchi;

class API{
    private DatabaseService database = new DatabaseService();
    private MySql.Data.MySqlClient.MySqlConnection myConn; 
    private MySqlCommand cmd = new MySqlCommand();

    
    public API(){
        myConn = database.MySqlConn();
    }

    public void ReadPetData()
    {
        cmd.Connection = myConn;
        cmd.CommandText = @"SELECT * FROM pet";


        using var myReader = cmd.ExecuteReader();
        while (myReader.Read())
        {
        System.Console.Write(myReader.GetInt16("id") + " ");
        System.Console.Write(myReader.GetString("name") + " ");
        System.Console.Write(myReader.GetDouble("age") + " ");
        System.Console.Write(myReader.GetBoolean("alive") + " ");
        System.Console.Write(myReader.GetInt16("hunger") + " ");
        System.Console.Write(myReader.GetInt16("sleepy") + " ");
        System.Console.Write(myReader.GetInt16("bored") + " ");
        System.Console.Write(myReader.GetInt16("health") + " ");
        System.Console.Write(myReader.GetInt16("hygiene") + " ");
        System.Console.Write(myReader.GetInt16("social") + " ");
        System.Console.WriteLine(myReader.GetInt16("harndrang") + " ");

        }
        cmd.Connection.Close();
    }

    public void CreatePetData(string name, double age, bool alive, int hunger, int sleepy, int bored, int health, int hygiene, int social, int harndrang)
    {
    
        cmd.Connection = myConn;
        cmd.CommandText = @"insert into pet (name, age, alive, hunger, sleepy, bored, health, hygiene, social, harndrang) values 
        (@name, @age, @alive, @hunger, @sleepy, @bored, @health, @hygiene, @social, @harndrang)";
        cmd.Parameters.AddWithValue("@name", name);
        cmd.Parameters.AddWithValue("@age", age);
        cmd.Parameters.AddWithValue("@alive", alive);
        cmd.Parameters.AddWithValue("@hunger", hunger);
        cmd.Parameters.AddWithValue("@sleepy", sleepy);
        cmd.Parameters.AddWithValue("@bored", bored);
        cmd.Parameters.AddWithValue("@health", health);
        cmd.Parameters.AddWithValue("@age", hygiene);
        cmd.Parameters.AddWithValue("@age", social);
        cmd.Parameters.AddWithValue("@age", harndrang);


        cmd.ExecuteNonQuery();
        cmd.Connection.Close();

    }


    public void UpdatePetData(string name, double age, bool alive, int hunger, int sleepy, int bored, int health, int hygiene, int social, int harndrang)
    {
        /*   
        
        public Pet(string nameV)
        {
            name = nameV;
            alive = true;
            hunger = 70;
            sleepy = 70;
            bored = 70;
            age = 0;
            health = 70;
            hygiene = 70;
            social = 70;
            harndrang = 30;}

        */

        cmd.Connection = myConn;
        cmd.CommandText = @"insert into pet (name, age, alive, hunger, sleepy, bored, health, hygiene, social, harndrang) values 
        (@name, @age, @alive, @hunger, @sleepy, @bored, @health, @hygiene, @social, @harndrang)";
        cmd.Parameters.AddWithValue("@name", name);
        cmd.Parameters.AddWithValue("@age", age);
        cmd.Parameters.AddWithValue("@alive", alive);
        cmd.Parameters.AddWithValue("@hunger", hunger);
        cmd.Parameters.AddWithValue("@sleepy", sleepy);
        cmd.Parameters.AddWithValue("@bored", bored);
        cmd.Parameters.AddWithValue("@health", health);
        cmd.Parameters.AddWithValue("@hygiene", hygiene);
        cmd.Parameters.AddWithValue("@social", social);
        cmd.Parameters.AddWithValue("@harndrang", harndrang);


        cmd.ExecuteNonQuery();
        cmd.Connection.Close();

    }

    public Pet GetPet(int id)
    {

        cmd.Connection = myConn;
        cmd.CommandText = "SELECT * FROM pet WHERE id = @id";
        cmd.Parameters.AddWithValue("@id", id);

        using var myReader = cmd.ExecuteReader();

        System.Console.Write(myReader.GetInt16("id") + " ");
        System.Console.Write(myReader.GetString("name") + " ");
        System.Console.Write(myReader.GetDouble("age") + " ");
        System.Console.Write(myReader.GetBoolean("alive") + " ");
        System.Console.Write(myReader.GetInt16("hunger") + " ");
        System.Console.Write(myReader.GetInt16("sleepy") + " ");
        System.Console.Write(myReader.GetInt16("bored") + " ");
        System.Console.Write(myReader.GetInt16("health") + " ");
        System.Console.Write(myReader.GetInt16("hygiene") + " ");
        System.Console.Write(myReader.GetInt16("social") + " ");
        System.Console.WriteLine(myReader.GetInt16("harndrang") + " ");

        return new Pet(myReader.GetString("name"));
    }
       public bool DeletePetData(int id)
    {

        cmd.Connection = myConn;
        cmd.CommandText = "DELETE FROM pet WHERE id = @id";
        cmd.Parameters.AddWithValue("@id", id);
        
        int exe = cmd.ExecuteNonQuery();
        cmd.Connection.Close();
        
        return exe == 1;

    }
}
