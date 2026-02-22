using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace VOC_simulator
{
    internal class Weather
    {
        public static async Task<Double> GetWeather(string city, string apiKey)
        {
            double temp = 0;
            
            string url = $"https://api.openweathermap.org/data/2.5/weather?q={city}&appid={apiKey}&units=metric";
            
            using HttpClient client = new HttpClient();
            try
            {
                HttpResponseMessage response = await client.GetAsync(url);
                response.EnsureSuccessStatusCode();

                string jsonResponse = await response.Content.ReadAsStringAsync();
                using JsonDocument doc = JsonDocument.Parse(jsonResponse);
                JsonElement root = doc.RootElement;

                string cityName = root.GetProperty("name").GetString();
                temp = root.GetProperty("main").GetProperty("temp").GetDouble();
                string description = root.GetProperty("weather")[0].GetProperty("description").GetString();
                

                Console.WriteLine($"Погода в {cityName}");
                Console.WriteLine($"Температура: {temp}°C");
                Console.WriteLine($"Описание: {description}");
            }
            catch (HttpRequestException ex)
            {
                Console.WriteLine($"Ошибка запроса: {ex.Message}");
            }
            catch (JsonException ex)
            {
                Console.WriteLine($"Ошибка обработки JSON: {ex.Message}");
            }
            Console.WriteLine("GG");
            return temp;
        }
    }
}
