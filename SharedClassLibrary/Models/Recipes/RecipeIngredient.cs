using SharedClassLibrary.Models.Recipes.Ingredients;

namespace SharedClassLibrary.Models.Recipes
{
    public class RecipeIngredient
    {
        public Guid Id { get; set; }
        public uint Quantity { get; set; }
        public UnitTypes Unit { get; set; }

        public Guid IngredientId { get; set; }
        public Ingredient Ingredient { get; set; }

        public Guid RecipeId { get; set; }
        public Recipe Recipe { get; set; }
    }
}
