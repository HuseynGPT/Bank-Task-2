namespace Bank_Task__2.Models;

internal class Client : IPerson
{
    public Client(string name, string surname, int age, string work_addresss, float salary)
    {
        Id = Guid.NewGuid();
        Name = name;
        Surname = surname;
        Age = age;
        this.work_addresss = work_addresss;
        this.salary = salary;
    }

    public Guid Id { get; set; }
    public string Name { get; set; }
    public string Surname { get; set; }
    public int Age { get; set; }

    public string work_addresss { get; set; }

    public float salary{ get; set; }


}
