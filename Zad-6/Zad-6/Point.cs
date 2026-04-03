using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zad_6
{
    public struct Point
    {
        // Поля
        public int X;
        public int Y;

        // Метод для перемещения точки
        public void Move(int deltaX, int deltaY)
        {
            X = X + deltaX;  // или X += deltaX
            Y = Y + deltaY;  // или Y += deltaY
        }

        // Метод для вывода координат
        public void PrintCoordinates()
        {
            Console.WriteLine($"Точка: ({X}, {Y})");
        }
    }
 
}
