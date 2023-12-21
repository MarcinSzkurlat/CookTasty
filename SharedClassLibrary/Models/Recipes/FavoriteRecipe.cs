namespace SharedClassLibrary.Models.Recipes
{
    public class FavoriteRecipe
    {
        public int Id { get; set; }

        public Guid UserId { get; set; }
        public User User { get; set; }

        public Guid FavoriteRecipeId { get; set; }
        public Recipe FavoriteRecipeObject { get; set; }
    }
}
