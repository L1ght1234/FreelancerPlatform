namespace FreelancerPlatform.Entities;

public class Application
{
    public Guid Id { get; set; }
    public double SuggestedPrice { get; set; }
    public DateTime SubmissionDate { get; set; }

    public Guid FreelancerId { get; set; }
    public User? Freelancer { get; set; }
    public Guid ProjectId { get; set; }
    public Project? Project { get; set; }
}
    