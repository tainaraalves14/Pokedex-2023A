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














