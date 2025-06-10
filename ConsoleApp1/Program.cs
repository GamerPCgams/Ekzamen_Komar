using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Books.Books book1 = new Books.Books();
            Console.WriteLine("Первая книга (создана конструктором по умолчанию):");
            book1.DisplayInfo();

            Books.Books book2 = new Books.Books("Дж. Р. Р. Толкин", "Властелин Колец", 1954, 1000000, 1178);
            Console.WriteLine("Вторая книга (создана конструктором с параметрами):");
            book2.DisplayInfo();

            Books.Books book3 = new Books.Books("А. Сапковский", "Ведьмак: Последнее желание", 1993, 500000, 384);
            Console.WriteLine("Третья книга:");
            book3.DisplayInfo();

            Console.ReadLine();
        }
    }
}
