using System.Reflection.Metadata.Ecma335;

namespace Bank_Task__2.Models;

internal class Bank
{

    public string Name { get; set; }

    public float Budget{ get; set; }

    public float  Profit{ get; set; }


    public void CalcutaeProfit()
    {
        Console.WriteLine($"Profit: { Budget+Profit}");
    }

    public List<Ceo> ceos { get; set; }
    public List<Worker> Workers { get; set; }

    public List<Manager> Managers{ get; set; }

    public List<Client> clients{ get; set; }




    public void ShowClientCredit(Client client)
    {
        Console.WriteLine($"{client.Name} in kerditi{client.salary}");



    }

    public void payCredit(Client client, float money)
    {
        client.salary += money;

        Console.WriteLine("Pay kedit isledi");


    }


    public void ShowAllClients()
    {
        foreach (var item in clients)
        {
            Console.WriteLine(item.salary);
        }
    }




}