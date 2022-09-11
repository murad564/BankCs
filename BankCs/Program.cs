namespace BankWithInterface;

class Program
{
    static void Main()
    {
        Client client = new Client("Murad", "Meherremli", 20, "Developer", 2500, new Credit(200, 2, 2, 20), "Mir Celal 103", "USA");
        client.show();
    }
}