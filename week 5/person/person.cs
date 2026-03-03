
namespace person
{
    internal class Person
    {
        private string Name { get; set; }
        private string SurName { get; set; }
        private int Age { get; set; }
        private string Email { get; set; }

        public Person(string name, string surName, int age, string email)
        {
            Name = name;
            SurName = surName;
            Age = age;
            Email = email;
        }

        public void PrintInfo()
        {
            Console.WriteLine($"{Name} {SurName} {Age} {Email}");

        }

        public int GetAge()
        { return Age; }

        public string GetEmail(string name)
        {
            if (Name == name)
            { return Email; }
            else { return "invalid"; }


        }

        public void profession(string vet)
        { Console.WriteLine(vet); }
    }
}

