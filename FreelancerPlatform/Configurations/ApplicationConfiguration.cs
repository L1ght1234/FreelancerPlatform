using FreelancerPlatform.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FreelancerPlatform.Configurations;

public class ApplicationConfiguration : IEntityTypeConfiguration<Application>
{
    public void Configure(EntityTypeBuilder<Application> builder)
    {
        builder.HasKey(x => x.Id);
        
        builder
            .HasOne(a => a.Freelancer)
            .WithMany(u => u.Applications)
            .HasForeignKey(a => a.FreelancerId)
            .OnDelete(DeleteBehavior.Restrict);
    }
}