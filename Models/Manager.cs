namespace BankApp.Models;

public class Manager : Person, IOrganize, ICalculateSalary
{
    public void Calculate()
    {
        Console.WriteLine("Calculate salary");
    }

    public void Organize()
    {
        Console.WriteLine("Manager is organize");
    }
}