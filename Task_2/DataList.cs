using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{

    public enum BrandCarsEnum
    {
        Acura,
        Audi,
        Bentley,
        BMW,
        Brilliance,
        Bugatti,
        Ford
    }


    public class Car
    {
        public string Model { get; set; }
        public BrandCarsEnum CarBrand { get; set; }
        public DateTime GraduationYear { get; set; }
        public ConsoleColor Color { get; set; }

        public void DrawInfoCar()
        {
            Console.WriteLine(new String('-', 50));
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine($"Автомобіль: {CarBrand} {Model}");
            Console.WriteLine($"Рік випуску: {GraduationYear.Year}");
            Console.WriteLine($"Колір: {Color}");
            Console.ResetColor();

        }

    }

    public class Client
    {
        public string Name { get; set; }
        public string NamberPhone { get; set; }
        public string ModelCars { get; set; }
    }


}
