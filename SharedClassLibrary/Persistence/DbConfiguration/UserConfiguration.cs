using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SharedClassLibrary.Models;

namespace SharedClassLibrary.Persistence.DbConfiguration
{
    internal class UserConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.Property(x => x.Description)
                .HasMaxLength(1000);

            builder.HasMany(x => x.CreatedRecipes)
                .WithOne(x => x.CreatedBy)
                .HasForeignKey(x => x.CreatedId)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
