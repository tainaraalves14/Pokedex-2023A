using System.Diagnostics;
using System.Text.Json;
using Microsoft.AspNetCore.Mvc;
using Pokedex.Models;

namespace Pokedex.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        var tipos = JsonSerializer.Deserialize<List<Tipo>>(
            LerArquivo(@"Data\tipos.json")
        );
        ViewData["Tipos"] = tipos;
         var pokemons = JsonSerializer.Deserialize<List<Pokemon>>(
             LerArquivo(@"Data\pokemons.json")
         );
            return View(pokemons);
        
    }

    private string LerArquivo(string nomeArquivo)
    {
        using (StreamReader leitor = new StreamReader(nomeArquivo)) 
        {
            string dados = leitor.ReadToEnd(); 
            return dados;
        }
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
