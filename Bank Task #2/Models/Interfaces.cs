namespace Bank_Task__2.Models
{
    interface IPerson
    {

        public Guid Id{ get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }

        public int Age{ get; set; }
        
    }

    interface IForCeoAndWoker
    {
        public string position { get; set; }

        public float Salary{ get; set; }

        public void organize();

    }


}
