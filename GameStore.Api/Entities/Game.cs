
namespace GameStore.Api.Entities;

public class Game
{
    public int Id { get; set; }
    public required string Name { get; set; }
    // string? means its null,as its ternary operator and it gives only true value and its null

    public required string Genre { get; set; }

    public decimal Price { get; set; }

    public DateTime ReleaseDate { get; set; }

    public required string ImageUri {get; set;}   
}