namespace BankApp.Models;

public class Credit
{
    public Guid _id { get; } = Guid.NewGuid();
    public double _amount { get; set; }
    public double _percent { get; set; }
    public int _months { get; set; }

    public double _payment { get; set; }

    public Credit() { }

    public Credit(double amount, double percent, int months, double payment)
    {
        _amount = amount;
        _percent = percent;
        _months = months;
        _payment = payment;
    }

    public static double CalculatePercent(double amount, double percent)
    {
        return Convert.ToDouble(amount + (amount * percent / 100.0));
    }

    public void showCredit()
    {
        Console.WriteLine($"Credit: {_id}\nAmount : {_amount} + {_percent}% => {_payment}");
    }

}