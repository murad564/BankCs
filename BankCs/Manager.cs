namespace BankWithInterface;

public class Manager : Person, Iorganize, IcalculateSalary
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
