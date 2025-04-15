namespace FreelancerPlatform.Entities;

public class Chat
{
    public Guid Id { get; set; }
    public string? Message { get; set; }
    public DateTime Date { get; set; }
    
    public Guid SenderId { get; set; }
    public User? Sender { get; set; }
    public Guid ReceiverId { get; set; }
    public User? Receiver { get; set; }
}