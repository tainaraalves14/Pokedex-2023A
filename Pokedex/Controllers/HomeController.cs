using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Pokedex.Models;
using Pokedex.Services;
namespace Pokedex.Controllers;
public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;
    private readonly IPokeService _pokeService;
    public HomeController(ILogger<HomeController> logger, IPokeService pokeService)
    {
        _logger = logger;
        _pokeService = pokeService;
    }
    public IActionResult Index(string tipo)
    {
        var pokes = _pokeService.GetPokedexDto();
        ViewData["filter"] = string.IsNullOrEmpty(tipo) ? "all" : tipo;
        return View(pokes);
    }
    public IActionResult Details(int Numero)
    {
        var pokemon = _pokeService.GetDetailedPokemon(Numero);
        pokemon.Tipos = _pokeService.GetTipos();
        return View(pokemon);
    }
    public IActionResult Privacy()
    {
        return View();
    }
    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel
        {
            RequestId = Activity.Current?.Id
        ?? HttpContext.TraceIdentifier
        });
    }
}