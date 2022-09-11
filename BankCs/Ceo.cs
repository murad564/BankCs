namespace BankWithInterface;

public class Ceo: Person,Iorganize,Icontrol,Imakemeeting
{
    public Ceo() { }
    public Ceo(string name, string surname, int age, string position, double salary)
        : base(name, surname, age, position, salary) { }

    public void Control()
    {
        Console.WriteLine("Ceo is control");
    }

    public void Makemeeting()
    {
        Console.WriteLine("Ceo is makemeeting");
    }

    void Iorganize.Organize()
    {
        Console.WriteLine("Ceo is organize");
    } 
}