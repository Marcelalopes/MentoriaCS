using System;
//Criando a estrutura de Filme
struct Film
{
  public int id;
  public string name;
  public string description;
  public string duration;
  public string dt_launch;

  public Film(int id, string name, string description, string duration, string dt_launch)
  {
    this.id = id;
    this.name = name;
    this.description = description;
    this.duration = duration;
    this.dt_launch = dt_launch;
  }
  //método detalhar filme
  public void detalhar()
  {
    Console.WriteLine("-----------------------------------------");
    Console.WriteLine("Id: " + this.id);
    Console.WriteLine("Nome: " + this.name);
    Console.WriteLine("Descrição: " + this.description);
    Console.WriteLine("Duração: " + this.duration);
    Console.WriteLine("Data de lançamento: " + this.dt_launch);
  }
  //método cadatrar filmes
  public void cadastrar()
  {
    Console.Write("Id: ");
    this.id = int.Parse(Console.ReadLine());
    Console.Write("Nome: ");
    this.name = Console.ReadLine();
    Console.Write("Descrição: ");
    this.description = Console.ReadLine();
    Console.Write("Duração: ");
    this.duration = Console.ReadLine();
    Console.Write("Data de lançamento: ");
    this.dt_launch = Console.ReadLine();
  }
  //editar filme
  public void editar()
  {
    Console.Write("Novo nome: ");
    this.name = Console.ReadLine();
    Console.Write("Nova descrição: ");
    this.description = Console.ReadLine();
    Console.Write("Nova duração: ");
    this.duration = Console.ReadLine();
    Console.Write("Nova data de lançamento: ");
    this.dt_launch = Console.ReadLine();
  }
  //listar filmes
  public void listarFilmes()
  {
    Console.WriteLine($"{this.id}: {this.name}");
  }
}

namespace Filmes
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("Bem Vindo ao Gerenciador de Filme! :)");
      Console.WriteLine("-------------------------------------");
      Console.WriteLine("Quantos filmes você deseja cadastrar?");
      int qtd_film = int.Parse(Console.ReadLine());
      //Vetores p estrutura de filmes ativos e desativados
      Film[] filmesAtivos = new Film[qtd_film];
      Film[] filmesDesativados = new Film[qtd_film];
      //cadastrando filmes
      for (int i = 0; i < filmesAtivos.Length; i++)
      {
        filmesAtivos[i].cadastrar();
        Console.WriteLine("-------------");
      }
      Console.WriteLine("Filmes Cadastrados com sucesso!!");

      Console.WriteLine("------MENU------");
      Console.WriteLine("1 - Editar Filme");
      Console.WriteLine("2 - Listar Filmes Ativos");
      Console.WriteLine("3 - Detalhar Filme");
      Console.WriteLine("4 - Desativar Filme");
      Console.WriteLine("5 - Listar Filmes Desativados");
      Console.WriteLine("6 - Sair");

      Console.WriteLine("Escolha uma opção: ");
      int op = int.Parse(Console.ReadLine());

      do
      {
        switch (op)
        {
          //editar
          case 1:
            Console.Write("Qual filme você deseja editar? ");
            int p = int.Parse(Console.ReadLine());
            filmesAtivos[p - 1].editar();
            Console.WriteLine("Pressione Enter para continuar!");
            Console.ReadKey();
            break;
          //listar filmes ativos
          case 2:
            Console.WriteLine("Filmes Ativos: ");
            for (int i = 0; i < filmesAtivos.Length; i++)
            {
              filmesAtivos[i].listarFilmes();
            }
            Console.WriteLine("Pressione Enter para continuar!");
            Console.ReadKey();
            break;
          //detalhar filmes
          case 3:
            Console.WriteLine("Qual filme você deseja detalhar? ");
            int pp = int.Parse(Console.ReadLine());
            filmesAtivos[pp - 1].detalhar();
            Console.WriteLine("Pressione Enter para continuar!");
            Console.ReadKey();
            break;
          //desativar filme
          case 4:
            Console.WriteLine("Qual filme você deseja desativar? ");
            int ppp = int.Parse(Console.ReadLine());
            filmesDesativados[ppp - 1] = filmesAtivos[ppp - 1];

            filmesAtivos[ppp - 1].id = 0;
            filmesAtivos[ppp - 1].name = null;
            filmesAtivos[ppp - 1].description = null;
            filmesAtivos[ppp - 1].duration = null;
            filmesAtivos[ppp - 1].dt_launch = null;
            break;
          //listar filmes desativados
          case 5:
            Console.WriteLine("Filmes Desativados: ");
            for (int i = 0; i < filmesDesativados.Length; i++)
            {
              filmesDesativados[i].listarFilmes();
            }
            Console.WriteLine("Pressione Enter para continuar!");
            Console.ReadKey();
            break;

          default:
            Console.WriteLine("Opção Inválida!");
            Console.ReadKey();
            break;
        }
        Console.WriteLine("------MENU------");
        Console.WriteLine("1 - Editar Filme");
        Console.WriteLine("2 - Listar Filmes Ativos");
        Console.WriteLine("3 - Detalhar Filme");
        Console.WriteLine("4 - Desativar Filme");
        Console.WriteLine("5 - Listar Filmes Desativados");
        Console.WriteLine("6 - Sair");

        Console.WriteLine("Escolha uma opção: ");
        op = int.Parse(Console.ReadLine());
      } while (op != 6);
      Console.Write("Fim do programa!");
    }
  }
}

