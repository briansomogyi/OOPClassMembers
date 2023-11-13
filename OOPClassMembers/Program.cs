namespace OOPClassMembers
{
    public class Program
    {
        public static void Main()
        {
            Person p = new Person("2234");
            Console.Write("What's your name? "); p.Name = Console.ReadLine();
            p.SayHello();
            
            int maxLifespan = Person.InitMaxLifespan();
            p.FirstName = "Brian";
            p.LastName = "Somogyi";
            // p.Cnp="2344";
            
            Console.WriteLine(Person.PopulationCount);
            Console.WriteLine(p.FirstName);
            Console.WriteLine(p.LastName);
            Console.WriteLine(p.Cnp);
        }
    }
}