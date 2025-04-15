namespace FreelancerPlatform.Entities;

public class Review
{
    public Guid Id { get; set; }
    public int Rating { get; set; }
    public string? Comment { get; set; }
    public DateTime Date { get; set; }
    
    public Guid SenderId { get; set; }
    public User? Sender { get; set; }
    public Guid ReceiverId { get; set; }
    public User? Receiver { get; set; }
}