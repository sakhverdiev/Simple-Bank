namespace BankApp.Models;

public class Ceo : Person, IOrganize, IControl, IMakeMeeting
{
    public Ceo() { }
    public Ceo(string name, string surname, int age, string position, double salary)
        : base(name, surname, age, position, salary) { }

    public void Control()
    {
        Console.WriteLine("Ceo is Control");
    }

    public void Makemeeting()
    {
        Console.WriteLine("Ceo is MakeMeeting");
    }

    void IOrganize.Organize()
    {
        Console.WriteLine("Ceo is Organize");
    }
}