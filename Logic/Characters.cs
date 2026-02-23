using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Security;
using System.Text;
using System.Threading.Tasks;

namespace VOC_simulator
{
    public class Characters
    {
        protected int reputation;
        protected string name;
        protected double balance;

        protected void showStats()
        {
            Console.WriteLine($"Имя: {name}");
            Console.WriteLine($"Репутация: {reputation}");
            Console.WriteLine($"Баланс: {balance}");
        }
    }

    // Капитан корабля
    public class Capitan : Characters
    {
        public async Task goToExpedition(string city, string apiKey)
        {
            double temp = await Weather.GetWeather(city, apiKey);
            if (temp > 10)
            {
                Console.WriteLine("norm");
            }
            else
            {
                Console.WriteLine("ploho");
            }
        }
    }

    // Губернатор города
    public class Governor : Characters
    {
        // Город, которым управляет губернатор
        public City City { get; set; }
    }

    // Директор торговой компании
    public class Director : Characters
    {
        // Компания, которой управляет директор
        public Company Company { get; set; }
    }
}
