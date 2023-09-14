namespace Bank_Task__2.Models;

internal class Worker : IPerson, IForCeoAndWoker
{
    public Worker(string position, float salary, Guid id, string name, string surname, int age, DateTime startTime, DateTime endTime)
    {
        this.position = position;
        Salary = salary;
        Id = id;
        Name = name;
        Surname = surname;
        Age = age;
        this.startTime = startTime;
        this.endTime = endTime;
    }


    public Worker()
    {
        
    }
    public string position { get; set; }
    public float Salary { get; set; }
    public Guid Id { get; set; }
    public string Name { get; set; }
    public string Surname { get; set; }
    public int Age { get; set; }


    public DateTime startTime{ get; set; }
    public DateTime endTime{ get; set; }
    

    public void organize()
    {
        Console.WriteLine("Organize isledi");
    }
}
