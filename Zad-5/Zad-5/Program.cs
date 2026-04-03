using System;
using Zad_5;

class Program
{
    static void Main()
    {
        Console.WriteLine("=== Задача 1: Книга ===\n");

        // Создаю 1-ю книгу
        Book book1 = new Book();
        book1.title = "Война и мир";
        book1.pages = 1200;

        // Создаю 2-ю книгу
        Book book2 = new Book();
        book2.title = "1984";
        book2.pages = 300;

        // Создаю 3-ю книгу (без названия, только страницы)
        Book book3 = new Book();
        book3.pages = 500;  // title останется "Неизвестно"

        // Вывод информации
        book1.GetInfo();
        book2.GetInfo();
        book3.GetInfo();


        //Задача 2: Студент 
        Console.WriteLine("=== Задача 2: Студент ===\n");

        // Создаю студентов разными конструкторами
        Student student1 = new Student();                    // конструктор без параметров
        Student student2 = new Student("Мария");             // только имя (возраст 18)
        Student student3 = new Student("Петр", 20);          // имя и возраст

        student1.PrintInfo();
        student2.PrintInfo();
        student3.PrintInfo();

        //Задача 3: Автомобиль
        Console.WriteLine("\n=== Задача 3: Автомобиль ===\n");

        // Использую тут инициализаторы объектов (фигурные скобки)
        Car car1 = new Car() { brand = "Toyota", model = "Camry", year = 2020 };
        Car car2 = new Car() { brand = "BMW", model = "X5", year = 2022 };
        Car car3 = new Car() { brand = "Lada", model = "Vesta" };  // year = 2000 (по умолчанию)

        // Вывожу информацию
        Console.WriteLine($"Автомобиль: {car1.brand} {car1.model}, {car1.year} г.");
        Console.WriteLine($"Автомобиль: {car2.brand} {car2.model}, {car2.year} г.");
        Console.WriteLine($"Автомобиль: {car3.brand} {car3.model}, {car3.year} г.");


        //Задача 4: Треугольник
        Console.WriteLine("\n=== Задача 4: Треугольник ===\n");

        // Валидный треугольник (3, 4, 5)
        Triangle triangle1 = new Triangle(3, 4, 5);
        triangle1.PrintSides();
        Console.WriteLine($"Треугольник существует: {triangle1.IsValid()}");
        Console.WriteLine();

        // Невалидный треугольник (1, 2, 4)
        Triangle triangle2 = new Triangle(1, 2, 4);
        triangle2.PrintSides();
        Console.WriteLine($"Треугольник существует: {triangle2.IsValid()}");


        //Задача 5: Точка 
        Console.WriteLine("\n=== Задача 5: Точка ===\n");

        // Создаю точку
        Point point1 = new Point(10, 20);

        // Деконструкция: получаю обе координаты
        (int x, int y) = point1;
        Console.WriteLine($"Координаты точки: X={x}, Y={y}");

        // Создаю вторую точку
        Point point2 = new Point(5, 7);

        // Деконструкция: игнорируем X с помощью _, берем только Y
        (int _, int yOnly) = point2;
        Console.WriteLine($"Только координата Y: {yOnly}");
    }

}
