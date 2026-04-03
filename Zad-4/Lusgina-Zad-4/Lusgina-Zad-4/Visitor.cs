using System;

public class Visitor
{
    // Публичное поле для имени посетителя
    public string name;

    // Статическое поле для подсчета всех созданных посетителей
    public static int totalVisitors = 0;

    // Конструктор, принимающий имя и увеличивающий счетчик
    public Visitor(string visitorName)
    {
        name = visitorName;
        totalVisitors++;
    }

    // Метод для вывода имени конкретного посетителя
    public void PrintInfo()
    {
        Console.WriteLine($"Посетитель: {name}");
    }

    // Статический метод для вывода общего количества посетителей
    public static void ShowTotalVisitors()
    {
        Console.WriteLine($"Всего создано посетителей: {totalVisitors}");
    }
}