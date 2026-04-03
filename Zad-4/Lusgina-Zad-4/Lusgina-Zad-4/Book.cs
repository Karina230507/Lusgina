using System;

public class Book
{
    // Поля с модификатором public и значениями по умолчанию
    public string title = "Неизвестно";
    public string author = "Неизвестен";
    public int year;

    // Метод для вывода информации о книге
    public void GetInfo()
    {
        Console.WriteLine($"\"{title}\", {author} ({year})");
    }
}