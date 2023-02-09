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








