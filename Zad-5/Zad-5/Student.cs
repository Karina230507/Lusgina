using System;

public class Student
{
    // Поля
    public string name;
    public int age;

    // Конструктор 1: без параметров
    public Student()
    {
        name = "Иван";
        age = 18;
    }

    // Конструктор 2: только имя (возраст 18)
    public Student(string name) : this(name, 18)  // вызываю 3 конструктор
    {
        // Тело пустое, потому что this вызывает другой конструктор
    }

    // Конструктор 3: имя и возраст
    public Student(string name, int age)
    {
        this.name = name;  // this разрешает конфликт имен
        this.age = age;
    }

    // Метод вывода информации
    public void PrintInfo()
    {
        Console.WriteLine($"Имя: {name}, Возраст: {age}");
    }
}