using Microsoft.Data.Sqlite;

namespace VOC_simulator
{
    internal class Base
    {
        public static void createBase()
        {
            using (var connection = new SqliteConnection("Data Source=saves.db"))
            {
                connection.Open();

                // Создание таблицы
                var createTableCmd = connection.CreateCommand();
                createTableCmd.CommandText =
                @"
            CREATE TABLE IF NOT EXISTS Users (
            Id INTEGER PRIMARY KEY AUTOINCREMENT,
            Login TEXT NOT NULL,
            Password INTEGER
            )";
                createTableCmd.ExecuteNonQuery();

                Console.WriteLine("Таблица Users создана (или уже существует).");
            }
        }

        public static void insertLoginAndPassword(string username, string password)
        {
            using (var connection = new SqliteConnection("Data Source=saves.db"))
            {
                connection.Open();

                var insertCmd = connection.CreateCommand();
                insertCmd.CommandText = "INSERT INTO Users (Login, Password) VALUES ($Login, $Password)";
                insertCmd.Parameters.AddWithValue("$Login", username);
                insertCmd.Parameters.AddWithValue("$Password", password);

                int rowsInserted = insertCmd.ExecuteNonQuery();
                Console.WriteLine($"Добавлено строк: {rowsInserted}");
            }
        }
        
        public static void selectLoginAndPassword()
        {
            using (var connection = new SqliteConnection("Data Source=saves.db"))
            {
                connection.Open();

                var selectCmd = connection.CreateCommand();
                selectCmd.CommandText = "SELECT Id, Login, Password FROM Users";

                using (var reader = selectCmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var id = reader.GetInt32(0);
                        var name = reader.GetString(1);
                        var age = reader.GetInt32(2);

                        Console.WriteLine($"Id: {id}, Login: {name}, Password: {age}");
                    }
                }
            }
        }
      
    }
}

