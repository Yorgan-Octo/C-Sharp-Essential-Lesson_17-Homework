using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3_V2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Dictionary<string, string> diction = new Dictionary<string, string>();

            diction.Add("Cat", "Кошка");
            diction.Add("Book", "Книга");
            diction.Add("Sun", "Солнце");
            diction.Add("Happy", "Счастливый");
            diction.Add("Car", "Машина");

            List<Discript> discripts = new List<Discript>()
            {
                new Discript
                {
                    Key = "Кошка",
                    Discription = "Хищное млекопитающее с мягкой шерстью, остроумное и независимое домашнее животное",
                },

                new Discript
                {
                    Key = "Книга",
                    Discription = "Издание, состоящее из страниц, связанных между собой, содержащее текст или иллюстрации.",
                },

                new Discript
                {
                    Key = "Солнце",
                    Discription = "Центральная звезда нашей солнечной системы, которая обеспечивает свет и тепло на Земле.",
                },

                new Discript
                {
                    Key = "Счастливый",
                    Discription = "Состояние эмоционального благополучия и удовлетворения.",
                },

                new Discript
                {
                    Key = "Машина",
                    Discription = "Средство передвижения на колесах, обычно с двигателем, используемое для транспортировки людей и грузов.",
                }
            };

            string userIn = Console.ReadLine();

            var res =
                from dic in diction
                join dis in discripts
                on dic.Value equals dis.Key
                where dic.Key.ToLower() == userIn.ToLower()
                let r = $"{dic.Key} это {dic.Value}"
                select new
                {
                    Translete = r,
                    Discript = dis.Discription
                };

            Console.Clear();
            foreach (var item in res)
            {
                Console.WriteLine("Перевод: " + item.Translete);
                Console.WriteLine();
                Console.WriteLine("Описание:");
                Console.WriteLine(item.Discript);
            }

            Console.ReadKey();


        }
    }
}
