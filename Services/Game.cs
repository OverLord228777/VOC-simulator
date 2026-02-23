using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace VOC_simulator
{
    internal class Game
    {
        public static void GameRegistration()
        {
            Console.WriteLine("=== Регистрация пользователя ===");
            Console.WriteLine("Уже имеете аккаунт?");
            string ans = Console.ReadLine();
            try
            {
                if (ans.ToLower() == "да")
                {

                }
                else
                {
                    Console.WriteLine("Введите логин: ");
                    string login = Console.ReadLine();
                    Console.WriteLine("Введите пароль: ");
                    string password = Console.ReadLine();
                    Registration.signUp(login, password, "Colonizer");
                }
            }
            catch (NullReferenceException ex)
            {
                Console.WriteLine($"null-строка: {ex.Message}");
            }
        }
    }
}
