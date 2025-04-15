namespace FreelancerPlatform.Entities;

public class User
{
    public Guid Id { get; set; }
    public string? Name { get; set; }
    public string? Email { get; set; }
    public Role? Role { get; set; }
    public double Balance { get; set; }
    public int Rating { get; set; }
    
    public ICollection<Project> ProjectsAsFreelancer { get; set; } = [];
    public ICollection<Project> ProjectsAsCustomer { get; set; } = [];
    public ICollection<Application> Applications { get; set; } = [];
    public ICollection<Transaction> Transactions { get; set; } = [];
    public ICollection<Review> ReviewsAsReceiver { get; set; } = [];
    public ICollection<Review> ReviewsAsSender { get; set; } = [];
    public ICollection<Chat> ChatsAsReceiver { get; set; } = [];
    public ICollection<Chat> ChatsAsSender { get; set; } = [];
}