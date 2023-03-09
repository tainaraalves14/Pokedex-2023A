using Pokedex.Models;
namespace Pokedex.Services;

public interface IPokeService
{
     Pokemon GetPokemon(int Numero);
     List<Pokemon> GetPokemons();
     List<Tipo> GetTipos();
}
