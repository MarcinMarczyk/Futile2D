using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Mono.Data.Sqlite;
using System.Data;

public class DBConnectioner : MonoBehaviour 
{ 

    private string dbName = "Uri=file:Futile.db";


    void Start()
    {
        ConnectToDB();
    }

    public void ConnectToDB()
    {

        using (var connection = new SqliteConnection(dbName))
        {
            connection.Open();
        }
    }
}


//Kod do wpisania komendy do bazy danych i wyświetlenia ich

//                using (var command = connection.CreateCommand())
//{
//    command.CommandText = "SELECT * FROM Map";

//    using (IDataReader reader = command.ExecuteReader())
//    {
//        while (reader.Read())
//        {
//            Debug.Log(reader["name"] + "\t\t" + reader["numberOfPlaces"]);
//            reader.Close();
//        }
//    }
//}