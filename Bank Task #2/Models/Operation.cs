namespace Bank_Task__2.Models;

internal class Operation
{
    public Operation(Guid iD, string processName, DateTime datetime)
    {
        ID = Guid.NewGuid();
        this.processName = processName;
        Datetime = datetime;
    }

    public Guid ID { get; set; }

    public string processName { get; set; }

    public DateTime Datetime{ get; set; }

    public Operation()
    {
        
    }

}
