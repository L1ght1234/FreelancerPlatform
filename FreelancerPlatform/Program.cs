using FreelancerPlatform.Entities;

namespace FreelancerPlatform;

public class Program
{
    public static void Main()
        {
            using var context = new FreelancerPlatformDbContext(); 


            var freelancer = new User
            {
                Id = Guid.NewGuid(),
                Name = "Freelancer User",
                Email = "freelancer@example.com",
                Role = Role.Freelancer,
                Balance = 1000,
                Rating = 5
            };

            context.Users.Add(freelancer);
            context.SaveChanges(); 

            var project = new Project
            {
                Id = Guid.NewGuid(),
                Name = "Test Project",
                Description = "This is a test project.",
                Budget = 500,
                IsCompleted = false,
                Category = "IT",
                CustomerId = freelancer.Id, 
                FreelancerId = freelancer.Id 
            };

            context.Projects.Add(project);
            context.SaveChanges(); 

            var application = new Application
            {
                Id = Guid.NewGuid(),
                SuggestedPrice = 450,
                SubmissionDate = DateTime.Now,
                FreelancerId = freelancer.Id, 
                ProjectId = project.Id 
            };

            context.Applications.Add(application);
            context.SaveChanges();
            
        }
}