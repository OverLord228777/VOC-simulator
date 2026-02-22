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
