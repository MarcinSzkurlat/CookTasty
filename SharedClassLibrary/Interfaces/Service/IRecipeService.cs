using SharedClassLibrary.Models.Recipes;

namespace SharedClassLibrary.Interfaces.Service
{
    public interface IRecipeService
    {
        public Task<IEnumerable<Recipe>> GetRecipesAsync();
        public Task<Recipe> GetRecipeByIdAsync(Guid id);
        public Task AddRecipeAsync(Recipe recipe);
        public Task EditRecipeAsync(Recipe recipe);
        public Task DeleteRecipeAsync(Recipe recipe);
    }
}
