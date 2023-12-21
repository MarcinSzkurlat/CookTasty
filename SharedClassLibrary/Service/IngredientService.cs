using SharedClassLibrary.Interfaces.Repositories;
using SharedClassLibrary.Interfaces.Service;
using SharedClassLibrary.Models.Recipes.Ingredients;

namespace SharedClassLibrary.Service
{
    public class IngredientService : IIngredientService
    {
        private readonly IIngredientRepository _ingredientRepository;

        public IngredientService(IIngredientRepository ingredientRepository)
        {
            _ingredientRepository = ingredientRepository;
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
