namespace BankApp.Models;

public class Bank
{
    public Guid _id { get; } = Guid.NewGuid();
    public string? _name { get; set; }
    public double _budget { get; set; }
    public Ceo? _ceo { get; set; }
    public Manager[]? _managers { get; set; }
    public Worker[]? _workers { get; set; }
    public Client[]? _clients { get; set; }


    public void ShowAllCredits()
    {
        if (_clients != null)
            foreach (var client in _clients)
                client.show();
    }

    public void ShowAllWorkers()
    {
        if (_workers != null)
            foreach (var worker in _workers)
                worker.show();
    }

    public void ShowAllManagers()
    {
        if (_managers != null)
            foreach (var manager in _managers)
                manager.show();
    }

    public void PayCredit(Client clientIn, double money)
    {
        if (_clients != null)
            foreach (var client in _clients)
                if (clientIn == client)
                    client.Credit._payment -= money;
    }
}