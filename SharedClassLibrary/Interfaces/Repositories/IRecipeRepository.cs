using SharedClassLibrary.Models.Recipes;

namespace SharedClassLibrary.Interfaces.Repositories
{
    public interface IRecipeRepository
    {
        public Task SaveChangesAsync();
        public Task<IEnumerable<Recipe>> GetRecipesAsync();
        public Task<Recipe> GetRecipeByIdAsync(Guid id);
        public Task AddRecipeAsync(Recipe recipe);
        public Task EditRecipeAsync(Recipe recipe);
        public Task DeleteRecipeAsync(Recipe recipe);
    }
}
