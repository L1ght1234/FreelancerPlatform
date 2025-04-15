using FreelancerPlatform.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FreelancerPlatform.Configurations;

public class TransactionConfiguration  : IEntityTypeConfiguration<Transaction>
{
    public void Configure(EntityTypeBuilder<Transaction> builder)
    {
        builder.HasKey(t => t.Id);

        builder
            .HasOne(t => t.User)
            .WithMany(u => u.Transactions)
            .HasForeignKey(t => t.UserId)
            .OnDelete(DeleteBehavior.Restrict);
        
        builder
            .ComplexProperty(u => u.Type, b =>
            {
                b.IsRequired();
                b.Property(g => g.Value).HasColumnName("Type");
            });
    }
}