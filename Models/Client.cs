namespace BankApp.Models;

public class Client : Person
{
    public Credit Credit { get; set; }
    public string _liveaddress { get; set; }
    public string _livework_address { get; set; }

    public Client() { }

    public Client(string name, string surname, int age, string position, double salary, Credit credit, string liveaddress, string liveworkaddress)
        : base(name, surname, age, position, salary)
    {
        Credit = credit;
        _liveaddress = liveaddress;
        _livework_address = liveworkaddress;
    }

    public override void show()
    {
        base.show();
        Console.WriteLine($"\nLive Address --> {_liveaddress}\nWork Address --> {_livework_address}");
    }
}