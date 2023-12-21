using SharedClassLibrary.Interfaces.Repositories;
using SharedClassLibrary.Interfaces.Service;
using SharedClassLibrary.Models.Recipes;

namespace SharedClassLibrary.Service
{
    public class RecipeService : IRecipeService
    {
        private readonly IRecipeRepository _recipeRepository;

        public RecipeService(IRecipeRepository recipeRepository)
        {
            _recipeRepository = recipeRepository;
        }

        public Task<IEnumerable<Recipe>> GetRecipesAsync()
        {
            throw new NotImplementedException();
        }

        public Task<Recipe> GetRecipeByIdAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task AddRecipeAsync(Recipe recipe)
        {
            throw new NotImplementedException();
        }

        public Task EditRecipeAsync(Recipe recipe)
        {
            throw new NotImplementedException();
        }

        public Task DeleteRecipeAsync(Recipe recipe)
        {
            throw new NotImplementedException();
        }
    }
}
