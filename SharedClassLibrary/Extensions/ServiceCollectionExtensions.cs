using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using SharedClassLibrary.Interfaces.Repositories;
using SharedClassLibrary.Interfaces.Service;
using SharedClassLibrary.Models;
using SharedClassLibrary.Persistence;
using SharedClassLibrary.Persistence.Repositories;
using SharedClassLibrary.Service;

namespace SharedClassLibrary.Extensions
{
    public static class ServiceCollectionExtensions
    {
        public static void AddServices(this IServiceCollection services, IConfiguration configuration)
        {
            var connectionString = configuration.GetConnectionString("CookTastyDb_PostgreSQL");

            //I know it's bad practice to share secrets in a public repository, but it's for self-study, and this database instance is free with a 90-day validity period, so who cares...
            connectionString ??=
                "Server=dpg-clpq4ujd3o9c73ev98t0-a.frankfurt-postgres.render.com; Port=5432; User Id=badbadmin; Password=iX8yjU8AE9KHMFUjrWLjLCeYjRSPBdUl; Database=cooktastydb;";

            services.AddDbContext<CookTastyDbContext>(options =>
                options.UseNpgsql(connectionString));

            services.AddScoped<Seeder>();
            services.AddScoped<IRecipeRepository, RecipeRepository>();
            services.AddScoped<IIngredientRepository, IngredientRepository>();
            services.AddScoped<IRecipeService, RecipeService>();
            services.AddScoped<IIngredientService, IngredientService>();

            services.AddIdentityCore<User>(opt =>
                {
                    opt.User.RequireUniqueEmail = true;
                })
                .AddRoles<IdentityRole<Guid>>()
                .AddEntityFrameworkStores<CookTastyDbContext>();

        }
    }
}
