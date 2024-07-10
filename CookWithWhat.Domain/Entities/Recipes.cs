namespace CookWithWhat.Domain.Entities;

public class Recipes
{
    public Guid Id { get; set; }
    public string Title { get; set; } = default!;
    public string Description { get; set; } = default!;
    public string Image { get; set; } = default!;
    public string Instructions { get; set; } = default!;

}