namespace SharedClassLibrary.Models.Recipes
{
    public class Recipe
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public string? Description { get; set; }
        public uint? PreparationTimeInMinutes { get; set; }
        public uint? DifficultyLevel { get; set; }
        public DateTime CreatedTime { get; set; } = DateTime.UtcNow;
        public List<string> PreparationSteps { get; set; } = new();
        public List<RecipeIngredient> RecipeIngredients { get; set; } = new();

        public Guid CreatedId { get; set; }
        public User CreatedBy { get; set; }
    }
}
