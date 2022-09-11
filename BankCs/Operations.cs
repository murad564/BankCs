
namespace BankWithInterface;

public class Operations 
{
    public Guid id { get; } = Guid.NewGuid();
    public string? OperationName { get; set; }

    public DateTime Time { get; set; }

}
