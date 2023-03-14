namespace Pokedex.Models;
public class DetailsDto
{
    public Pokemon Prior { get; set; }
    public Pokemon Current { get; set; }
    public Pokemon Next { get; set; }
    public List<Tipo> Tipos { get; set; }
}