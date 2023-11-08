namespace FusionRecipesApi.Models;

public class Ingredient
{
    public long Id { get; set; }

    public string Name { get; set; }

    public string MeasurementUnit { get; set; }
    
    public double Quantity { get; set; }
}