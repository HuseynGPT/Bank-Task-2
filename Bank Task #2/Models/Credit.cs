using System.Reflection.Metadata.Ecma335;

namespace Bank_Task__2.Models;

internal class Credit
{
    public Guid ID { get; set; }
    public Client client { get; set; }

    public float Amount { get; set; }


    public int Percent { get; set; }

    public DateTime Months { get; set; }


    public void calculatePercent()
    {
        Console.WriteLine("Percent hesablandi");
    }
    public void Payment()
    {
        Console.WriteLine("Pasyment isledi");
    }

    public Credit()
    {

    }

    public Credit( Client client, float amount, int percent, DateTime months)
    {
        ID = Guid.NewGuid();
        this.client = client;
        Amount = amount;
        Percent = percent;
        Months = months;
    }
}
