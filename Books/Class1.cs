using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// Класс, представляющий книгу с различными характеристиками
/// </summary>
namespace Books
{
    public class Books
    {
        private string author;       
        private string title;        
        private int year;           
        private int circulation;     
        private int pages;          

        /// <summary>
        /// Конструктор по умолчанию (без параметров)
        /// </summary>
        public Books()
        {
            author = "Неизвестен";
            title = "Без названия";
            year = 0;
            circulation = 0;
            pages = 0;
        }

        /// <summary>
        /// Конструктор с параметрами
        /// </summary>
        /// <param name="author">Автор книги</param>
        /// <param name="title">Название книги</param>
        /// <param name="year">Год издания</param>
        /// <param name="circulation">Тираж</param>
        /// <param name="pages">Количество страниц</param>
        public Books(string author, string title, int year, int circulation, int pages)
        {
            this.author = author;
            this.title = title;
            this.year = year;
            this.circulation = circulation;
            this.pages = pages;
        }

        /// <summary>
        /// Метод для отображения информации о книге на экране
        /// </summary>
        public void DisplayInfo()
        {
            Console.WriteLine("Информация о книге:");
            Console.WriteLine($"Автор: {author}");
            Console.WriteLine($"Название: {title}");
            Console.WriteLine($"Год издания: {year}");
            Console.WriteLine($"Тираж: {circulation} экз.");
            Console.WriteLine($"Количество страниц: {pages}");
            Console.WriteLine(new string('-', 30));
        }
    }
}
