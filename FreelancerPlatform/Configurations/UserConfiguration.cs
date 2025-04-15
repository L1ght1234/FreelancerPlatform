using FreelancerPlatform.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FreelancerPlatform.Configurations;

public class UserConfiguration : IEntityTypeConfiguration<User>
{
    public void Configure(EntityTypeBuilder<User> builder)
    {
        builder.HasKey(u => u.Id);
        
        builder
            .HasMany(u => u.ProjectsAsFreelancer)
            .WithOne(p => p.Freelancer)
            .HasForeignKey(p => p.FreelancerId)
            .OnDelete(DeleteBehavior.Restrict);

        builder
            .HasMany(u => u.ProjectsAsCustomer)
            .WithOne(p => p.Customer)
            .HasForeignKey(p => p.CustomerId)
            .OnDelete(DeleteBehavior.Restrict);
        
        builder
            .HasMany(u => u.Applications)
            .WithOne(a => a.Freelancer)
            .HasForeignKey(a => a.FreelancerId)
            .OnDelete(DeleteBehavior.Restrict);
        
        builder
            .HasMany(u => u.Transactions)
            .WithOne(a => a.User)
            .HasForeignKey(a => a.UserId)
            .OnDelete(DeleteBehavior.Restrict);

        builder
            .HasMany(u => u.ReviewsAsSender)
            .WithOne(a => a.Sender)
            .HasForeignKey(a => a.SenderId)
            .OnDelete(DeleteBehavior.Restrict);

        builder
            .HasMany(u => u.ReviewsAsReceiver)
            .WithOne(a => a.Receiver)
            .HasForeignKey(a => a.ReceiverId)
            .OnDelete(DeleteBehavior.Restrict);

        builder
            .HasMany(u => u.ChatsAsSender)
            .WithOne(a => a.Sender)
            .HasForeignKey(a => a.SenderId)
            .OnDelete(DeleteBehavior.Restrict);

        builder
            .HasMany(u => u.ChatsAsReceiver)
            .WithOne(a => a.Receiver)
            .HasForeignKey(a => a.ReceiverId)
            .OnDelete(DeleteBehavior.Restrict);

        builder
            .ComplexProperty(u => u.Role, b =>
            {
                b.IsRequired();
                b.Property(g => g.Value).HasColumnName("Role");
            });
    }
}