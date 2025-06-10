using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhotoPrintConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var calculator = new PhotoPrintCalculator.PhotoPrintCalculator();

            Console.WriteLine("Калькулятор стоимости печати фотографий");
            Console.WriteLine("Доступные размеры: " + string.Join(", ", calculator.GetAvailableSizes()));

            try
            {
                Console.Write("Введите размер фотографии: ");
                string size = Console.ReadLine();

                Console.Write("Введите количество фотографий: ");
                int quantity = int.Parse(Console.ReadLine());

                decimal cost = calculator.CalculateOrderCost(size, quantity);
                Console.WriteLine($"Стоимость заказа: {cost} руб.");

                if (quantity > 20)
                {
                    Console.WriteLine("(Применена скидка 10% за заказ более 20 фотографий)");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ошибка: {ex.Message}");
            }

            Console.WriteLine("\nНажмите любую клавишу для выхода...");
            Console.ReadKey();
        }
    }
}

