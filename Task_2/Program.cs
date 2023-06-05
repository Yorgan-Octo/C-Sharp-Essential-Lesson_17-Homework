using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
    public class Program
    {
        static void Main()
        {

            List<Car> cars = new List<Car>()
            {
                new Car()
                {
                    Model = "GT500",
                    CarBrand = BrandCarsEnum.Ford,
                    GraduationYear = DateTime.Parse("2/4/2022"),
                    Color = ConsoleColor.DarkRed,
                },

                new Car()
                {
                    Model = "QWJ17",
                    CarBrand = BrandCarsEnum.Bentley,
                    GraduationYear = DateTime.Parse("12/10/1983"),
                    Color = ConsoleColor.DarkBlue,
                },

                new Car()
                {
                    Model = "LS789",
                    CarBrand = BrandCarsEnum.Acura,
                    GraduationYear = DateTime.Parse("2/2/2002"),
                    Color = ConsoleColor.Yellow,
                },

                new Car()
                {
                    Model = "BT2311",
                    CarBrand = BrandCarsEnum.Bugatti,
                    GraduationYear = DateTime.Parse("3/7/1964"),
                    Color = ConsoleColor.Blue,
                },

                new Car()
                {
                    Model = "Sirius",
                    CarBrand = BrandCarsEnum.Bentley,
                    GraduationYear = DateTime.Parse("4/4/2013"),
                    Color = ConsoleColor.Magenta,
                },
            };

            List<Client> clients = new List<Client>()
            {

                new Client()
                {
                    Name = "Dima",
                    NamberPhone = "+380971324589",
                    ModelCars = "GT500"
                },

                new Client()
                {
                    Name = "Alisa",
                    NamberPhone = "+380974569834",
                    ModelCars = "QWJ17"
                },

                new Client()
                {
                    Name = "Clara",
                    NamberPhone = "+380971256723",
                    ModelCars = "LS789"
                },

                new Client()
                {
                    Name = "Sara",
                    NamberPhone = "+380973457689",
                    ModelCars = "BT2311"
                },

                new Client()
                {
                    Name = "Liza",
                    NamberPhone = "+380964356767",
                    ModelCars = "Sirius"
                },

            };


            var data =
                from car in cars
                join client in clients
                on car.Model equals client.ModelCars
                let clientInfo = $"Покупатель: {client.Name}, Номер {client.NamberPhone}"
                orderby car.Model descending
                select new
                {
                    Client = clientInfo,
                    Car = car,
                };


            foreach (var item in data)
            {
                Console.WriteLine(new String('=', 50));
                Console.WriteLine(item.Client);
                item.Car.DrawInfoCar();
                Console.WriteLine(new String('=', 50));
                Console.WriteLine();
            }

            Console.ReadKey();

        }
    }
}
