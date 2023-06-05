using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_5
{
    internal class Program
    {
        static void Main()
        {
            Calculator calculator = new Calculator();
            while (true)
            {
                Console.Clear();

                dynamic namber1 = UserInterface.InNumData("Введіть число 1: ");
                dynamic mathOperato = UserInterface.InMathOperator();
                dynamic namber2 = UserInterface.InNumData("Введіть число 2: ");

                dynamic resalt = mathOperato switch
                {
                    "+" => calculator.Add(namber1, namber2),
                    "-" => calculator.Sum(namber1, namber2),
                    "*" => calculator.Mul(namber1, namber2),
                    "/" => calculator.Div(namber1, namber2),
                    _ => null
                };

                if (resalt != null)
                {
                    Console.Clear();
                    Console.WriteLine($"Результат: {namber1} {mathOperato} {namber2} = {resalt}");
                }

                Console.ReadKey();
            }
        }
    }
}
