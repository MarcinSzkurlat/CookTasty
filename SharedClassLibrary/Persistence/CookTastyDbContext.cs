using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using SharedClassLibrary.Models;
using SharedClassLibrary.Models.Recipes;
using SharedClassLibrary.Models.Recipes.Ingredients;
using SharedClassLibrary.Persistence.DbConfiguration;

namespace SharedClassLibrary.Persistence
{
    public class CookTastyDbContext : IdentityDbContext<User, IdentityRole<Guid>, Guid>
    {
        public CookTastyDbContext(DbContextOptions options) : base(options)
        {
            
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Recipe> Recipes { get; set; }
        public DbSet<RecipeIngredient> RecipeIngredients { get; set; }
        public DbSet<Ingredient> Ingredients { get; set; }
        public DbSet<FavoriteRecipe> FavoriteRecipes { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.ApplyConfiguration(new UserConfiguration());
            builder.ApplyConfiguration(new FavoriteRecipeConfiguration());
            builder.ApplyConfiguration(new IngredientConfiguration());
            builder.ApplyConfiguration(new RecipeConfiguration());
            builder.ApplyConfiguration(new RecipeIngredientConfiguration());
            builder.ApplyConfiguration(new UserRoleConfiguration());
        }
    }
}
