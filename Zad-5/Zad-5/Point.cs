using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zad_5
{
    public class Point
    {
        // Поля
        public int X;
        public int Y;

        // Конструктор
        public Point(int x, int y)
        {
            X = x;
            Y = y;
        }

        // Метод деконструкции
        public void Deconstruct(out int x, out int y)
        {
            x = X;
            y = Y;
        }
    }
}
