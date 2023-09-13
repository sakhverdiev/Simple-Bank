namespace BankApp.Models;

public class Worker : Person
{

    TimeOnly _startwork { get; set; }
    TimeOnly _endwork { get; set; }
    public Operations[]? Operation { get; set; } = null;

    public Worker(string name, string surname, int age, string position, double salary, TimeOnly startwork, TimeOnly endwork, Operations[]? operations = null)
    {
        _startwork = startwork;
        _endwork = endwork;
        Operation = operations;
    }

    public override void show()
    {
        Console.WriteLine($"{base.show}\nStart Work \t--> {_startwork}\nEnd Work \t--> {_endwork}");
    }

}