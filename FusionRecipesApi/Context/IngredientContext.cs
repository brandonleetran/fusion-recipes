using Microsoft.EntityFrameworkCore;
using FusionRecipesApi.Models;

namespace FusionRecipesApi.Context;

public class IngredientContext : DbContext
{
    public IngredientContext(DbContextOptions<IngredientContext> options) : base(options) 
    {
    }

    public DbSet<Ingredient> IngredientContexts { get; set; }
}