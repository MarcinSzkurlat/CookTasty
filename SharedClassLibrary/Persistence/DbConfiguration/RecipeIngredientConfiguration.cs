using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SharedClassLibrary.Models.Recipes;

namespace SharedClassLibrary.Persistence.DbConfiguration
{
    internal class RecipeIngredientConfiguration : IEntityTypeConfiguration<RecipeIngredient>
    {
        public void Configure(EntityTypeBuilder<RecipeIngredient> builder)
        {
            builder.Property(x => x.Quantity)
                .HasDefaultValue(1);
        }
    }
}
