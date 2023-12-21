using Microsoft.EntityFrameworkCore;
using SharedClassLibrary.Models.Recipes;

namespace SharedComponents
{
    public partial class RecipesPage
    {
        public List<Recipe> Recipes { get; set; } = new();


        public void Run()
        {
            Recipes = DbContext.Recipes
                .Include(x => x.CreatedBy)
                .ToList();
        }

        public void Clear()
        {
            Recipes.Clear();
        }
    }
}
