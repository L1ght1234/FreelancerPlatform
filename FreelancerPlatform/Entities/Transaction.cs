namespace FreelancerPlatform.Entities;

public class Transaction
{
    public Guid Id { get; set; }
    public double Sum { get; set; }
    public Type? Type { get; set; }
    public DateTime Date { get; set; }
    
    public Guid UserId { get; set; }
    public User? User { get; set; }
}