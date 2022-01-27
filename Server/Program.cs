using static System.Console;
using Server;
using Server.scr;



namespace App_cadastro_series
{
  class Program{

      static Serierepositorio repositorio = new Serierepositorio();
      static void Main(string[] args){
  
        string OpcaoUsuario = ObterOpcaoUsuario();

        while (OpcaoUsuario.ToUpper() != "X")
        {
          switch(OpcaoUsuario)
          {
            case "1":
              ListaSeries();
              break;
            
            case "2":
              InserirSeries();
              break;
            
            case "3":
              AtualizarSeries();
              break;
            
            case "4":
              //ExcluirSeries();
              break;
              
            case "5":
              VisualizarSeries();
              break;

            case "6":
              Clear();
              break;
            
            default:
              throw new ArgumentOutOfRangeException();
          }
          OpcaoUsuario = ObterOpcaoUsuario(); 



        }

        WriteLine ("Obrigado por utilizar o cadastro F1. Bye! ");
        ReadLine();





      }

    private static void AtualizarSeries()
		{
			Write("Digite o id da série: ");
			int indiceSerie = int.Parse(Console.ReadLine());

			
			foreach (int i in Enum.GetValues(typeof(Genero)))
			{
				WriteLine("{0}-{1}", i, Enum.GetName(typeof(Genero), i));
			}
			Write("Digite a Equipe entre as opções acima: ");
			int entradaGenero = int.Parse(ReadLine());

			Write("Digite o piloto da equipe: ");
			string entradaPiloto = ReadLine();

			Write("Digite o Ano: ");
			var entradaAno = int.Parse(ReadLine());

			Write("Digite o nome do chefe de equipe: ");
			string entradaChefe = ReadLine();

			Series atualizaSeries = new Series(id: indiceSerie,
										               genero: (Genero)entradaGenero,
                                   NamePiloto: entradaPiloto,
                                   Ano: entradaAno,
                                   ChefeDeEquipe: entradaChefe);

			repositorio.Atualiza(indiceSerie, atualizaSeries);
		}

     private static void VisualizarSeries()
		{
			Write("Digite o id da série: ");
			int indiceSeries = int.Parse(ReadLine());

			var series = repositorio.RetornaPorId(indiceSeries);

			WriteLine(series);
		}


    private static void ListaSeries()
    {
      WriteLine("Listar Equipes: ");
      var lista = repositorio.Lista();

      if (lista.Count ==0)
      {
        WriteLine ("Nenhuma Equipe Cadastrada.");
        return;
      }
      foreach (var series in lista)
      {
        WriteLine("#Id {0} {1}", series.RetornaId(),series.RetornaPiloto());

      }


    }

    private static void InserirSeries()
    {
      WriteLine ("Inserir nova equipe");

      foreach (int i in Enum.GetValues(typeof(Genero)))
      {
        WriteLine("{0}-{1}", i , Enum.GetName(typeof(Genero),i));
      }
    
    WriteLine ("Digite uma equipe entre as opções acima: ");
    int entradaGenero = int.Parse(ReadLine());

    WriteLine("Digite o nome do piloto: ");
    string entradaPiloto = ReadLine();
    
    WriteLine("Digite o Ano: ");
    int entradaAno = int.Parse(ReadLine());
    
    WriteLine("Digite o nome do chefe de equipe: ");
    string entradaChefe = ReadLine();
    
    Series novaSerie = new Series(id: repositorio.ProximoId(),
                                   genero: (Genero)entradaGenero,
                                   NamePiloto: entradaPiloto,
                                   Ano: entradaAno,
                                   ChefeDeEquipe: entradaChefe);

    repositorio.Insere(novaSerie);


    }


    private static string ObterOpcaoUsuario()
    {
      WriteLine();
      WriteLine("Bem vindo, cadastro F1 acessado! ");
      WriteLine (" Informe a opção desejada: ");

      WriteLine(" 1- Listar Equipes;");
      WriteLine(" 2- Inserir Nova Equipe;");
      WriteLine(" 3- Atualizar Equipe;");
      WriteLine(" 4- Excluir Equipe;");
      WriteLine(" 5- Visualizar Equipes;");
      WriteLine(" 6- Limpar opções;");
      WriteLine(" 7- Sair;");
      WriteLine();

      string OpcaoUsuario = ReadLine().ToUpper();
      WriteLine();
      return OpcaoUsuario;

    }






  }  




}