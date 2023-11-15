using System;
public class Person
{
    private string name;
    private int age;
    public string Name
    {
        get { return name; }
        set { name = value; }
    }
    public int Age
    {
        get { return age; }
        set
        {
            if (value >= 0) age = value;
            else Console.WriteLine("Вік не може бути менше 0");
        }
    }
}
class Program
{
    static void Main()
    {
        Person person = new Person();
        Console.WriteLine("Введіть і'мя: ");
        string NewName = Console.ReadLine();
        Console.WriteLine($"Введіть {NewName}'s вік: ");
        int NewAge = int.Parse(Console.ReadLine());

        person.Name = NewName;
        person.Age = NewAge;
        Console.WriteLine($"\nІм'я: {person.Name}");
        Console.WriteLine($"Вік: {person.Age}");
        Console.ReadKey();
    }
}