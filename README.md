# Pokedex-2023A
Projeto Desenvolvido em aulas de Programação Web II.


Aula Inicial
Terminal Visual Studio Code

git config --global user.name  "Tainara Alves" 

git config --global user.emal "tainara.nascimento16@etec.sp.gov.br"

git clone https://github.com/tainaraalves14/Pokedex-2023A.git

/*caso você não tenha criado no repositório*/
dot net new gitignore 

/*dotnet new mvc*/
dotnet new mvc 

dotnet new sln --name Pokedex
/*
para criar uma solução 
uma solução é um agrupador de projetos 
sln = solution
*/

dotnet new mvc --name Pokedex -f Net6.0 

dotnet sln add Pokedex\Pokedex.csproj

git status 

git add .

git commit -m "criada a solução e o projeto mvc"

git push 
or 
git push -u 

obs error
git pull 

Orientação Objeto 
dotnet  watch run --project Pokedex\Pokedex.csproj   

dotnet watch run 


Aula II 

git config --global user.name  "Tainara Alves" 

git config --global user.emal "tainara.nascimento16@etec.sp.gov.br"

cd desketop 

git clone https://github.com/tainaraalves14/Pokedex-2023A.git


substituição de pastas

css

.card img {
    background-color: lightgray;
}

.card:hover {

    border: 3px solid red;
    
    transform: scale(1.15);
    
    transition: 1s;
    
    z-index: 1000;
}

.cursor-pointer {

    cursor: pointer;
}

....img.... 
- favicon 
- pokemons


Criar pasta Data 
adicionar pastas de dados constituidas por arquivos Json  
-pokemons.json
-tipos.json 

mudar para 
<Nullable>disable</Nullable>
cs.proj

models 
new c# 
-Tipo 
-Pokemon 


Tipo

prop

namespace Pokedex.Models
{
    public class Tipo
    {
      //Atributos 
      
      public string Nome { get; set; }  
      
      public string Cor { get; set; }  
    }
}


Pokemon 
ctor
namespace Pokedex.Models
{
    public class Pokemon
    {
        public int Numero { get; set; }
        
        public string Nome { get; set; }
        
        public string Descricao { get; set; }
        
        public string Especie { get; set; }
        
        public List<string> Tipo { get; set;}
        
        public double Altura { get; set; }

        public double Peso { get; set; }
        
        public string Imagem { get; set; }

        // Método Construtor
        
        public Pokemon()
        {
            Tipo = new List<string>();   
        }
    }
}

Boostrap 


Arquivo json 


Aula III

cd Pokedex 
dotnet restore 
dotnet clean 

arquivo css substituição

shift alt f 

indexcshtml 
substituição 


layoutcss 
substituição 


aula v

@ ou \ antes do texto quer dizer que é um texto 


HomeControllers.cs
 public IActionResult Index()
    {
        string arquivo = @"Data\pokemons.json";
        using (StreamReader leitor = new StreamReader(arquivo)) 
        {
            string dados = leitor.ReadToEnd(); 
            var pokemons = JsonSerializer.Deserialize<List<Pokemon>>(dados);
            return View(pokemons);

        }
       
    }



transformar json em objeto 
var pokemons = JsonSerializer.Deserialize<List<Pokemon>>(dados);

ctrl . (erro em JsonSerializer) 
using System.Text.Json;



Views 
home 
index.cshtml
@model List<Pokedex.Models.Pokemon>



apagar card 2 
laços de repetição 
@foreach 

repete uma determinada extrutura n vezes 
foreach ele só funciona com listas em geral 
cada item da minha lista ele salva um por vez na var

@foreach (var pokemon in Model)
{
                    
}

colocar chave no fim da estrutura do card 

@foreach (var pokemon in Model)
            {
                    
           
            <!-- Card Pokemon - Inicio -->
            <div class="col">
                <div class="card shadow-sm cursor-pointer planta venenoso" onclick="GetInfo(001)">
                    <img src="@Model.Imagem" class="card-img-top" width="100%" height="300" alt="@Model.Nome" />
                    <div class="card-body">
                        <p class="card-text mb-0">Nº @Model.Numero.ToString("000")</p>
                        <h3 class="card-title">@Model.Nome</h3>
                        <div class="d-flex justify-content-between align-items-center">
                            <div class="btn-group">
                                <a href="#" class="btn my-2 text-white" style="background-color:#7c5">Planta</a>
                                <a href="#" class="btn my-2 text-white" style="background-color:#a59">Venenoso</a>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
            <!-- Card Pokemon - Fim -->

            }
            
 
Para fazer funcionar 
trocar Model por pokemon 


cd Pokedex 
dotnet watch run 

 <div class="btn-group">
                                @foreach (var tipo in pokemon.Tipo)
                                {
                                    <a href="#" class="btn my-2 text-white bg-darck" >@tipo</a>
                                }
                                
                            </div>


commit 
Leitura dos Arquivos Json e exibição na index 


