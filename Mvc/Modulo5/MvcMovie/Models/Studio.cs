namespace MvcMovie.Models;

public class Studio
{
    public int Id { get; set; }
    public string? Nome { get; set; }
    public string? Country { get; set; }
    public string? Site { get; set; }
    public required ICollection<Movie> Movies { get; set; } = new List<Movie>();
}
