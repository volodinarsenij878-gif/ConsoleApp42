using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program42
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--- Расход топлива ---");

            double distance = ReadPositiveDouble("Расстояние (км): ");
            double consumptionPer100 = ReadPositiveDouble("Средний расход на 100 км (л): ");
            decimal fuelPrice = ReadPositiveDecimal("Стоимость литра бензина (руб): ");

            double litersNeeded = distance * consumptionPer100 / 100.0;
            decimal totalCost = (decimal)litersNeeded * fuelPrice;

            Console.WriteLine($"Необходимое количество топлива: {litersNeeded:F2} л");
            Console.WriteLine($"Итоговые затраты на поездку: {totalCost:C2}\n");

            // Чтобы консоль не закрывалась сразу при запуске из IDE
            Console.Write("Нажмите Enter для выхода...");
            Console.ReadLine();
        }

        /// <summary>
        /// Считывает положительное double. При ошибке или отрицательном значении просит повторно.
        /// </summary>
        static double ReadPositiveDouble(string prompt)
        {
            while (true)
            {
                Console.Write(prompt);
                string input = Console.ReadLine();

                if (double.TryParse(input, out double value) && value > 0)
                {
                    return value;
                }

                Console.WriteLine("Ошибка: введите положительное число.");
            }
        }

        /// <summary>
        /// Считывает положительное decimal. При ошибке или отрицательном значении просит повторно.
        /// </summary>
        static decimal ReadPositiveDecimal(string prompt)
        {
            while (true)
            {
                Console.Write(prompt);
                string input = Console.ReadLine();

                if (decimal.TryParse(input, out decimal value) && value > 0)
                {
                    return value;
                }

                Console.WriteLine("Ошибка: введите положительное число (можно с копейками).");
            }
        }
    }
}