using System;

public class Book
{
    // Поля со значениями по умолчанию
    public string title = "Неизвестно";
    public int pages;

    // Метод для вывода информации
    public void GetInfo()
    {
        Console.WriteLine($"Книга: {title}, страниц: {pages}");
    }
}