using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhotoPrintCalculator
{
    /// <summary>
    /// Класс для расчета стоимости печати фотографий
    /// </summary>
    public class PhotoPrintCalculator
    {
        private readonly Dictionary<string, decimal> sizePrices = new Dictionary<string, decimal>
        {
            {"9x12", 50},
            {"12x15", 80},
            {"18x24", 120}
        };

        /// <summary>
        /// Рассчитывает стоимость заказа
        /// </summary>
        /// <param name="size">Размер фотографии (9x12, 12x15 или 18x24)</param>
        /// <param name="quantity">Количество фотографий</param>
        /// <returns>Общая стоимость заказа</returns>
        public decimal CalculateOrderCost(string size, int quantity)
        {
            if (!sizePrices.ContainsKey(size))
                throw new ArgumentException("Неверный размер фотографии");

            if (quantity <= 0)
                throw new ArgumentException("Количество должно быть больше 0");

            decimal price = sizePrices[size];
            decimal total = price * quantity;

            if (quantity > 20)
            {
                total *= 0.9m;
            }

            return total;
        }

        /// <summary>
        /// Получает список доступных размеров
        /// </summary>
        /// <returns>Массив доступных размеров</returns>
        public string[] GetAvailableSizes()
        {
            return sizePrices.Keys.ToArray();
        }

        /// <summary>
        /// Проверяет, доступен ли указанный размер
        /// </summary>
        /// <param name="size">Размер для проверки</param>
        /// <returns>True если размер доступен</returns>
        public bool IsSizeAvailable(string size)
        {
            return sizePrices.ContainsKey(size);
        }
    }
}
