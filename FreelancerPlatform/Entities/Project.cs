namespace FreelancerPlatform.Entities;

public class Project
{
    public Guid Id { get; set; }
    public string? Name { get; set; }
    public string? Description { get; set; }
    public double Budget { get; set; }
    public bool IsCompleted { get; set; }
    public string? Category { get; set; }
    
    public ICollection<Application> Applications { get; set; } = [];
    public Guid CustomerId { get; set; }
    public User? Customer { get; set; }
    public Guid FreelancerId { get; set; }
    public User? Freelancer { get; set; }
}