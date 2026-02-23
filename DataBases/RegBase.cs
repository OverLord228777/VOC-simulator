using Microsoft.Data.Sqlite;

namespace VOC_simulator
{
    internal class RegBase
    {
        public static void createRegBase()
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
            Password INTEGER,
            Role TEXT
            )";
                createTableCmd.ExecuteNonQuery();

                Console.WriteLine("Таблица Users создана (или уже существует).");
            }
        }

        public static void insertLoginAndPassword(string username, string password, string role)
        {
            using (var connection = new SqliteConnection("Data Source=saves.db"))
            {
                connection.Open();

                var insertCmd = connection.CreateCommand();
                insertCmd.CommandText = "INSERT INTO Users (Login, Password, Role) VALUES ($Login, $Password, $Role)";
                insertCmd.Parameters.AddWithValue("$Login", username);
                insertCmd.Parameters.AddWithValue("$Password", password);
                insertCmd.Parameters.AddWithValue("$Role", role);

                int rowsInserted = insertCmd.ExecuteNonQuery();
                Console.WriteLine($"Добавлено строк: {rowsInserted}");
            }
        }
        
        public static void selectAllLoginAndPassword()
        {
            using (var connection = new SqliteConnection("Data Source=saves.db"))
            {
                connection.Open();

                var selectCmd = connection.CreateCommand();
                selectCmd.CommandText = "SELECT Id, Login, Password, Role FROM Users";

                using (var reader = selectCmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var id = reader.GetInt32(0);
                        var name = reader.GetString(1);
                        var age = reader.GetInt32(2);
                        var role = reader.GetString(3);

                        Console.WriteLine($"Id: {id}, Login: {name}, Password: {age}, Role: {role}");
                    }
                }
            }
        }

        public static void selectLoginAndPassword(int idToFind)
        {
            string dbFile = "saves.db";
            using (var connection = new SqliteConnection(dbFile))
            {
                connection.Open();
                string sql = "SELECT Name, Age FROM Users WHERE Id = @id";

                using (var command = new SqliteCommand(sql, connection))
                {
                    // Использование параметров для безопасности
                    command.Parameters.AddWithValue("@id", idToFind);

                    using (SqliteDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            // Данные найдены, считываем значения
                            string name = reader.GetString(0);
                            int age = reader.GetInt32(1);
                            Console.WriteLine($"Найдено: {name}, {age}");
                        }
                        else
                        {
                            Console.WriteLine("Кортеж не найден.");
                        }
                    }
                }
            }
        }

        public static void DeleteSQLiteDatabase(string dbFilePath)
        {
            // 1. Закрываем все подключения (если есть)
            // SQLiteConnection.ClearAllPools();

            // 2. Удаляем файл БД
            if (File.Exists(dbFilePath))
            {
                try
                {
                    File.Delete(dbFilePath);
                    Console.WriteLine("База данных успешно удалена.");
                }
                catch (IOException e)
                {
                    Console.WriteLine($"Ошибка при удалении: {e.Message}");
                }
            }
        }
    }
}

