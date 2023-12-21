using Bogus;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using SharedClassLibrary.Models;
using SharedClassLibrary.Models.Recipes;
using SharedClassLibrary.Models.Recipes.Ingredients;

namespace SharedClassLibrary.Persistence
{
    public class Seeder
    {
        private readonly CookTastyDbContext _cookTastyDbContext;
        private readonly UserManager<User> _userManager;

        public Seeder(CookTastyDbContext cookTastyDbContext, UserManager<User> userManager)
        {
            _cookTastyDbContext = cookTastyDbContext;
            _userManager = userManager;
        }

        public async Task SeedAsync()
        {
            await _cookTastyDbContext.Database.MigrateAsync();

            if (_cookTastyDbContext.Users.Any()) return;

            var user = CreateUser();
            var recipes = GetRecipes();

            foreach (var recipe in recipes)
            {
                user.CreatedRecipes.Add(recipe);
            }

            await _cookTastyDbContext.SaveChangesAsync();
        }

        private User CreateUser()
        {
            var user = new User()
            {
                Email = "user@test.com",
                UserName = "User",
                Description = "Something about me",
            };

            _userManager.CreateAsync(user, "Test123?");
            _userManager.AddToRoleAsync(user, "User");

            return user;
        }

        private List<Recipe> GetRecipes()
        {
            var preparationSteps = new List<string>()
            {
                "Add eggs",
                "Add flour",
                "Add oil",
                "Add spices",
                "Add sugar",
                "Chop onion",
                "Turn on the oven",
                "Stir ingredients",
                "Peel apples"
            };

            var ingredients = GetIngredients();

            var recipeIngredientFaker = new Faker<RecipeIngredient>()
                .RuleFor(p => p.Ingredient, f => f.PickRandom(ingredients))
                .RuleFor(p => p.Quantity, f => f.Random.UInt(1, 5))
                .RuleFor(p => p.Unit, f => (UnitTypes)f.Random.Int(0, 5));

            var recipeIngredients = recipeIngredientFaker.Generate(50);

            var recipesFaker = new Faker<Recipe>()
                .RuleFor(p => p.Title, f => f.Lorem.Sentence(3))
                .RuleFor(p => p.Description, f => f.Lorem.Sentences(5))
                .RuleFor(p => p.PreparationTimeInMinutes, f => f.Random.UInt(10, 500))
                .RuleFor(p => p.DifficultyLevel, f => f.Random.UInt(1, 10))
                .RuleFor(p => p.PreparationSteps, f => f.PickRandom(preparationSteps, 4).ToList())
                .RuleFor(p => p.RecipeIngredients, f => f.PickRandom(recipeIngredients, 5).ToList());

            var recipes = recipesFaker.Generate(30);

            return recipes;
        }

        private List<Ingredient> GetIngredients()
        {
            var ingredientFaker = new Faker<Ingredient>()
                .RuleFor(p => p.Name, f => f.Lorem.Word());

            var ingredients = ingredientFaker.Generate(100);

            return ingredients;
        }
    } 
}
