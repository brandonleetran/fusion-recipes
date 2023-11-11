namespace FusionRecipesApi.Models;
public class Recipe
{
    public int Id { get; set; }
    public string Title { get; set; }
    public string MarkdownContentFilePath { get; set; } 
    public string ImageUrl { get; set; } 
    public DateTime PublishDate { get; set; }
}
