using System;
using Zad_6;

class Program
{
    static void Main()
    {
        Console.WriteLine("=== Задача 1: Книга ===\n");

        // Создаем объект книги
        Book myBook = new Book();

        // Присваиваем значения полям
        myBook.title = "Мастер и Маргарита";
        myBook.author = "Михаил Булгаков";
        myBook.year = 1967;

        // Вызываем метод DisplayInfo
        myBook.DisplayInfo();

        // Выводим каждое поле по отдельности
        Console.WriteLine($"\nВывод полей по отдельности:");
        Console.WriteLine($"Название: {myBook.title}");
        Console.WriteLine($"Автор: {myBook.author}");
        Console.WriteLine($"Год: {myBook.year}");

        Console.WriteLine("\n=== Следующая задача ===\n");




        // === Задача 2: Банковский счет ===
        Console.WriteLine("=== Задача 2: Банковский счет ===\n");

        // Создаем объект счета
        BankAccount myAccount = new BankAccount();

        // Устанавливаем номер счета
        myAccount.accountNumber = "123456789";

        Console.WriteLine($"Номер счета: {myAccount.accountNumber}");
        Console.WriteLine($"Начальный баланс: {myAccount.balance}\n");

        // Вносим 500
        myAccount.Deposit(500);

        // Снимаем 200
        myAccount.Withdraw(200);

        // Пытаемся снять 400 (должно быть недостаточно средств)
        myAccount.Withdraw(400);

        Console.WriteLine("\n=== Следующая задача ===\n");


        // === Задача 3: Структура Точка ===
        Console.WriteLine("=== Задача 3: Структура Точка ===\n");

        // Способ 1: Создание через new
        Point p1 = new Point();
        p1.X = 10;
        p1.Y = 20;
        Console.Write("p1 (через new): ");
        p1.PrintCoordinates();

        // Способ 2: Создание без new (просто объявление)
        Point p2;  // Без new!
                   // Важно: перед использованием нужно инициализировать поля вручную
        p2.X = 5;
        p2.Y = 7;
        Console.Write("p2 (без new): ");
        p2.PrintCoordinates();

        // Перемещаем точку p1
        Console.WriteLine("\nПеремещаем p1 на (+5, -3):");
        p1.Move(5, -3);
        Console.Write("p1 после перемещения: ");
        p1.PrintCoordinates();

        Console.WriteLine("\nПрограмма завершена!");
        Console.ReadKey();
    }
}