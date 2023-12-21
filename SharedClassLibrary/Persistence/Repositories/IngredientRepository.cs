using SharedClassLibrary.Interfaces.Repositories;
using SharedClassLibrary.Models.Recipes.Ingredients;

namespace SharedClassLibrary.Persistence.Repositories
{
    public class IngredientRepository : IIngredientRepository
    {
        private readonly CookTastyDbContext _dbContext;

        public IngredientRepository(CookTastyDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public Task SaveChangesAsync()
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Ingredient>> GetIngredientsAsync()
        {
            throw new NotImplementedException();
        }

        public Task<Ingredient> GetIngredientByIdAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task AddIngredientAsync(Ingredient ingredient)
        {
            throw new NotImplementedException();
        }

        public Task EditIngredientAsync(Ingredient ingredient)
        {
            throw new NotImplementedException();
        }

        public Task DeleteIngredientAsync(Ingredient ingredient)
        {
            throw new NotImplementedException();
        }
    }
}
