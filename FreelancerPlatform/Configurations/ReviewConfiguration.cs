using FreelancerPlatform.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FreelancerPlatform.Configurations;

public class ReviewConfiguration : IEntityTypeConfiguration<Review>
{
    public void Configure(EntityTypeBuilder<Review> builder)
    {
        builder.HasKey(r => r.Id);

        builder
            .HasOne(r => r.Sender)
            .WithMany(u => u.ReviewsAsSender)
            .HasForeignKey(r => r.SenderId)
            .OnDelete(DeleteBehavior.Restrict);
        
        builder
            .HasOne(r => r.Receiver)
            .WithMany(u => u.ReviewsAsReceiver)
            .HasForeignKey(r => r.ReceiverId)
            .OnDelete(DeleteBehavior.Restrict);
    }
}