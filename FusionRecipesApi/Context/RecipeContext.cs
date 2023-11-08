using Microsoft.EntityFrameworkCore;
using FusionRecipesApi.Models;

namespace FusionRecipesApi.Context;

public class RecipeContext : DbContext
{
    public RecipeContext(DbContextOptions<RecipeContext> options) : base(options)
    {
    }

    public DbSet<Recipe> Recipes { get; set; }
}