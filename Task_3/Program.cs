using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Lifetime;
using System.Text;
using System.Threading.Tasks;

namespace Task_3
{
    internal class Program
    {
        static void Main(string[] args)
        {

            dynamic UA = new[]
            {
                "Привет",
                "Спасибо",
                "До свидания",
                "Пожалуйста",
                "Да",
                "Нет",
                "Извените",
                "Помогите",
                "Друг",
                "Еда",
            };

            dynamic EN = new[]
            {
                "Hello",
                "Thank you",
                "Goodbye",
                "Please",
                "Yes",
                "No",
                "Sorry",
                "Help",
                "Friend",
                "Food",
            };

            while (true)
            {
                Console.Clear();

                Console.WriteLine(new String('-', 50));
                Console.WriteLine("Вас вітае Українсько-Англійській словник! 1000 слів за секунду!");
                Console.WriteLine(new String('-', 50));

                Console.Write("Введить україньське слово для прекладу: ");
                dynamic userIn = Console.ReadLine();

                dynamic resalt = default;

                for (int i = 0; i < UA.Length; i++)
                {
                    if (UA[i].ToLower() == userIn.ToLower())
                    {
                        resalt = $"Слово: {UA[i]}  -  Переклад: {EN[i]}";
                        break;
                    }

                    if (i == UA.Length - 1)
                    {
                        resalt = "Такого слова немае! Пошукайте інше!";
                    }
                }

                Console.Clear();
                Console.WriteLine(resalt);
                Console.ReadKey();
            }

        }
    }
}
