namespace MvcMovie.Models;

public class Artist
{
    public int Id { get; set; }
    public required string Nome { get; set; }
    public string? Bio { get; set; }
    public string? Site { get; set; }
    public ICollection<Movie>? Movie { get; set; }
    public ICollection<Artist>? MovieArtists { get; set; }
}
