using SharedClassLibrary.Models.Recipes.Ingredients;

namespace SharedClassLibrary.Interfaces.Repositories
{
    public interface IIngredientRepository
    {
        public Task SaveChangesAsync();
        public Task<IEnumerable<Ingredient>> GetIngredientsAsync();
        public Task<Ingredient> GetIngredientByIdAsync(Guid id);
        public Task AddIngredientAsync(Ingredient ingredient);
        public Task EditIngredientAsync(Ingredient ingredient);
        public Task DeleteIngredientAsync(Ingredient ingredient);
    }
}
