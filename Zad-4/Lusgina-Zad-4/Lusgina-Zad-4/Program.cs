using System;

class Program
{
    static void Main()
    {
        //ЗАДАЧА 1: Книжная полка 
        Console.WriteLine("=== Задача 1: Книжная полка ===\n");

        // Создаю объект myBook
        Book myBook = new Book();

        // Устанавливаю значения полей
        myBook.title = "Война и мир";
        myBook.author = "Лев Толстой";
        myBook.year = 1869;

        // Вызываю метод GetInfo для myBook
        myBook.GetInfo();

        // Создаю второй объект unknownBook (поля остаются по умолчанию)
        Book unknownBook = new Book();

        // Вызываю метод GetInfo для unknownBook
        unknownBook.GetInfo();

        Console.WriteLine("\n=== Задача 2: Умный счетчик ===\n");

        //ЗАДАЧА 2: Умный счетчик 

        // Создаю трех посетителей
        Visitor visitor1 = new Visitor("Анна");
        Visitor visitor2 = new Visitor("Борис");
        Visitor visitor3 = new Visitor("Виктор");

        // Вывожу информацию о каждом посетителе
        visitor1.PrintInfo();
        visitor2.PrintInfo();
        visitor3.PrintInfo();

        // Выводится общее количество созданных посетителей
        Visitor.ShowTotalVisitors();

        // Чтобы консоль не закрылась сразу
        Console.WriteLine("\nНажми любую клавишу для выхода...");
        Console.ReadKey();
    }
}