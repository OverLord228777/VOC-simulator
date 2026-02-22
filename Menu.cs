using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace VOC_simulator
{
    internal class Menu
    {
        private const string intro = "=== VOC-simulator ===\n";

        public static void showIntro()
        {
            Console.WriteLine(intro);
        }

        public static void signUp(string login, string pswd)
        {
            string path = "base.txt";
            File.AppendAllText(path, login);
            File.AppendAllText(path, ":");
            File.AppendAllText(path, pswd);
            File.AppendAllText(path, "\n");

            Base.createBase();
            Base.insertLoginAndPassword(login, pswd);
        }
        public static string getApiKey()
        {
            string path = "api.txt";        // add your API key from openweathermap.org
            string api = "";
            try
            {
                api = File.ReadAllText(path);
            }
            catch (IOException e)
            {
                Console.WriteLine("Ошибка чтения файла: " + e.Message);
            }
            return api;
        }
    }
}
