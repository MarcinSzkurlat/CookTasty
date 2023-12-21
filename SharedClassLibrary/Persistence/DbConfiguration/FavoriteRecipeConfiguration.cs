using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SharedClassLibrary.Models.Recipes;

namespace SharedClassLibrary.Persistence.DbConfiguration
{
    internal class FavoriteRecipeConfiguration : IEntityTypeConfiguration<FavoriteRecipe>
    {
        public void Configure(EntityTypeBuilder<FavoriteRecipe> builder)
        {
            builder.HasOne(x => x.User)
                .WithMany(x => x.FavoriteRecipes)
                .HasForeignKey(x => x.UserId)
                .OnDelete(DeleteBehavior.NoAction);

            builder.HasOne(x => x.FavoriteRecipeObject)
                .WithMany()
                .HasForeignKey(x => x.FavoriteRecipeId)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
