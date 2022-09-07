namespace Contracts;

public class Sale
{
    public string Id { get; set; } = string.Empty;
    //public DateOnly Fecha { get; set; }
    public Customer? Customer { get; set; }
}