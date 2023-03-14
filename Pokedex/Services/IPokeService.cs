using Pokedex.Models;
namespace Pokedex.Services;
public interface IPokeService
{
    List<Pokemon> GetPokemons();
    List<Tipo> GetTipos();
    Pokemon GetPokemon(int Numero);
    PokedexDto GetPokedexDto();
    DetailsDto GetDetailedPokemon(int Numero);
    Tipo GetTipo(string Nome);
}