using System.Security.Cryptography;

namespace Bank_Task__2.Models;

internal class Manager : IPerson
{
    public Guid Id { get; set; }
    public string Name { get; set; }
    public string Surname { get; set; }
    public int Age { get; set; }
    public string Position { get; set; }

    public float Salary { get; set; }

    public void orhanize()
    {
        Console.WriteLine("organize isledi");
    }

    public void calculateSalaries()
    {
        Console.WriteLine("faiz hesanlandi");
    }

    public Manager()
    {
        
    }

    public Manager( string name, string surname, int age, string position, float salary)
    {
        Id = Guid.NewGuid();
        Name = name;
        Surname = surname;
        Age = age;
        Position = position;
        Salary = salary;
    }
}
