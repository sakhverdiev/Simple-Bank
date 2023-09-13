namespace BankApp.Models;

class Program
{
    static void Main()
    {
        Client client = new Client("Senan", "Akhverdiev", 18, "Developer", 5000, new Credit(300, 2, 3, 30), "Baku, Bakikhanov", "Baku, Yasamal");
        client.show();
    }
}