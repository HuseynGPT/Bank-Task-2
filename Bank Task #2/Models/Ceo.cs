namespace Bank_Task__2.Models
{



    internal class Ceo : IPerson,IForCeoAndWoker
    {
        public Guid Id { get; set; }
        public string Name { get ; set; }
        public string Surname { get ; set ; }
        public int Age { get; set; }

        public string position { get; set; }
        public float Salary { get; set; }

        public Ceo()
        {
            
        }

        public Ceo(Guid id, string name, string surname, int age, string position, float salary)
        {
            Id = Guid.NewGuid();
            Name = name;
            Surname = surname;
            Age = age;
            this.position = position;
            Salary = salary;
        }

        public void organize()
        {
            throw new NotImplementedException();
        }

        public void control()
        {

        }

        public void makeMeeting()
        {

        }

        public void decreasePercentage(float percentage)
        {

        }


    }
}
