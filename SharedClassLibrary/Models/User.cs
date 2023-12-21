using Microsoft.AspNetCore.Identity;
using SharedClassLibrary.Models.Recipes;

namespace SharedClassLibrary.Models
{
    public class User : IdentityUser<Guid>
    {
        public string? Description { get; set; }
        public ICollection<Recipe> CreatedRecipes { get; set; } = new List<Recipe>();
        public ICollection<FavoriteRecipe> FavoriteRecipes { get; set; } = new List<FavoriteRecipe>();
    }
}
