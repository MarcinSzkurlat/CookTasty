using SharedClassLibrary.Interfaces.Repositories;
using SharedClassLibrary.Models.Recipes;

namespace SharedClassLibrary.Persistence.Repositories
{
    public class RecipeRepository : IRecipeRepository
    {
        private readonly CookTastyDbContext _dbContext;

        public RecipeRepository(CookTastyDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public Task SaveChangesAsync()
        {
            throw new NotImplementedException();
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
