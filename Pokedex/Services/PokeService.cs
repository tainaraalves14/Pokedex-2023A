using System.Text.Json;
using Pokedex.Models;
namespace Pokedex.Services;
public class PokeService : IPokeService
{
    private readonly IHttpContextAccessor _session;
    private readonly string pokemonFile = @"Data\pokemons.json";
    private readonly string tiposFile = @"Data\tipos.json";
    public PokeService(IHttpContextAccessor session)
    {
        _session = session;
        PopularSessao();
    }
    public List<Pokemon> GetPokemons()
    {
        PopularSessao();
        var pokemons = JsonSerializer.Deserialize<List<Pokemon>>
        (_session.HttpContext.Session.GetString("Pokemons"));
        return pokemons;
    }
    public List<Tipo> GetTipos()
    {
        PopularSessao();
        var tipos = JsonSerializer.Deserialize<List<Tipo>>
        (_session.HttpContext.Session.GetString("Tipos"));
        return tipos;
    }
    public Pokemon GetPokemon(int Numero)
    {
        var pokemons = GetPokemons();
        return pokemons.Where(p => p.Numero == Numero).FirstOrDefault();
    }
    public PokedexDto GetPokedexDto()
    {
        var pokes = new PokedexDto()
        {
            Pokemons = GetPokemons(),
            Tipos = GetTipos()
        };
        return pokes;
    }
    public DetailsDto GetDetailedPokemon(int Numero)
    {
        var pokemons = GetPokemons();
        var poke = new DetailsDto()
        {
            Current = pokemons.Where(p => p.Numero == Numero)
        .FirstOrDefault(),
            Prior = pokemons.OrderByDescending(p => p.Numero)
        .FirstOrDefault(p => p.Numero < Numero),
            Next = pokemons.OrderBy(p => p.Numero)
        .FirstOrDefault(p => p.Numero > Numero),
        };
        poke.Tipos = GetTipos();
        return poke;
    }
    public Tipo GetTipo(string Nome)
    {
        var tipos = GetTipos();
        return tipos.Where(t => t.Nome == Nome).FirstOrDefault();
    }
    private void PopularSessao()
    {
        if (string.IsNullOrEmpty(_session.HttpContext.Session.GetString("Tipos")))
        {
            _session.HttpContext.Session
            .SetString("Pokemons", LerArquivo(pokemonFile));
            _session.HttpContext.Session
            .SetString("Tipos", LerArquivo(tiposFile));
        }
    }
    private string LerArquivo(string fileName)
    {
        using (StreamReader leitor = new StreamReader(fileName))
        {
            string dados = leitor.ReadToEnd();
            return dados;
        }
    }
}