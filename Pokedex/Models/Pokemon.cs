namespace Pokedex.Models;
// Namespace: é como se fosse o "nome" do arquivo, é uma forma de "endereçamento", é também o nome do projeto.


// public: classificação da classe, qualquer um que acessar conseguirá ver o nome
// class: comando para criação de uma classe
// Pokemon: nome da classse
public class Pokemon 
{
   public int Numero { get; set; } 
   public string Nome { get; set; }
   public string Descricao { get; set; }
   public string Especie { get; set; }
   public List<string> Tipo { get; set; }
   public double Altura  { get; set; }
   public double Peso    { get; set; }
   public string Imagem{ get; set; }


} 
// Dentro das chaves serão colocadas as "propriedades", é como criar um "banco de dados" ou uma "tabela"
// Não se terá a informação mas uma propriedade que permitirá dizer que é essa informação