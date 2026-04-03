using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zad_5
{
    public class Triangle
    {
        // Поля (стороны)
        public double a;
        public double b;
        public double c;

        // Конструктор с параметрами (this разрешает конфликт имен)
        public Triangle(double a, double b, double c)
        {
            this.a = a;  // this.a — это поле, a — это параметр
            this.b = b;
            this.c = c;
        }

        // Проверка: существует ли треугольник?
        public bool IsValid()
        {
            // Сумма любых двух сторон больше третьей
            return (a + b > c) && (a + c > b) && (b + c > a);
        }

        // Вывод сторон
        public void PrintSides()
        {
            Console.WriteLine($"Стороны треугольника: a={a}, b={b}, c={c}");
        }
    }
}
