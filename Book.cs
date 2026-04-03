using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zad_6
{
    public class Book
    {
        // Поля со значениями по умолчанию
        public string title = "Неизвестно";
        public string author;
        public int year;

        // Метод для вывода информации о книге
        public void DisplayInfo()
        {
            Console.WriteLine($"Название: {title}, Автор: {author}, Год: {year}");
        }
    }
}
