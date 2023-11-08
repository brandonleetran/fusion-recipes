using System.Collections.Generic; 

namespace FusionRecipesApi.Models;

public class Recipe
{
    public string Id { get; set; }

    public string Name { get; set; }

    public List<Ingredient> Ingredients { get; set; }
}