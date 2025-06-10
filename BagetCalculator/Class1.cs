using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BagetCalculator
{
    public class BagetPriceCalculator
    {
        private readonly Dictionary<string, Dictionary<string, decimal>> bagetPrices = new Dictionary<string, Dictionary<string, decimal>>
        {
            {
                "Россия", new Dictionary<string, decimal>
                {
                    {"Дерево", 500},
                    {"Пластик", 300},
                    {"Алюминий", 700}
                }
            },
            {
                "Италия", new Dictionary<string, decimal>
                {
                    {"Дерево", 1200},
                    {"Пластик", 800},
                    {"Алюминий", 1500}
                }
            },
            {
                "Германия", new Dictionary<string, decimal>
                {
                    {"Дерево", 1000},
                    {"Пластик", 600},
                    {"Алюминий", 1300}
                }
            }
        };

        private const decimal GlassPrice = 800; 
        private const decimal StretchingPrice = 500;
        private const decimal PaspartuPricePerMeter = 400;

        /// <summary>
        /// Рассчитывает стоимость оформления работы в багет
        /// </summary>
        public decimal Calculate(
            decimal width, decimal height,
            string manufacturer, string material,
            bool hasGlass, bool needsStretching,
            bool hasPaspartu, decimal paspartuWidth = 0)
        {
            if (width <= 0 || height <= 0)
                throw new ArgumentException("Размеры должны быть положительными числами");

            if (!bagetPrices.ContainsKey(manufacturer) || !bagetPrices[manufacturer].ContainsKey(material))
                throw new ArgumentException("Неверный производитель или материал багета");

            if (hasPaspartu && paspartuWidth <= 0)
                throw new ArgumentException("Ширина паспарту должна быть положительной");

            decimal perimeter = (width + height) * 2 / 100;

            decimal bagetCost = perimeter * bagetPrices[manufacturer][material];

            decimal glassCost = hasGlass ? (width * height / 10000) * GlassPrice : 0;

            decimal stretchingCost = needsStretching ? StretchingPrice : 0;

            decimal paspartuCost = 0;
            if (hasPaspartu)
            {
                decimal paspartuPerimeter = ((width + paspartuWidth * 2) + (height + paspartuWidth * 2)) * 2 / 100;
                paspartuCost = paspartuPerimeter * PaspartuPricePerMeter;
            }

            return bagetCost + glassCost + stretchingCost + paspartuCost;
        }

        /// <summary>
        /// Получает список доступных производителей
        /// </summary>
        public List<string> GetManufacturers()
        {
            return new List<string>(bagetPrices.Keys);
        }

        /// <summary>
        /// Получает список доступных материалов для указанного производителя
        /// </summary>
        public List<string> GetMaterials(string manufacturer)
        {
            if (bagetPrices.ContainsKey(manufacturer))
                return new List<string>(bagetPrices[manufacturer].Keys);
            return new List<string>();
        }
    }
}
