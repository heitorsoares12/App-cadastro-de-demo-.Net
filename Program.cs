using System;

namespace DIO.Series
{
    class Program
    {
        static DemoRepositorio repositorio = new DemoRepositorio();
        static void Main(string[] args)
        {
            string opcaoUsuario = ObterOpcaoUsuario();

			while (opcaoUsuario.ToUpper() != "X")
			{
				switch (opcaoUsuario)
				{
					case "1":
						ListarDemo();
						break;
					case "2":
						InserirDemo();
						break;
					case "3":
						AtualizarDemo();
						break;
					case "4":
						ExcluirDemo();
						break;
					case "5":
						VisualizarDemo();
						break;
					case "C":
						Console.Clear();
						break;

					default:
						throw new ArgumentOutOfRangeException();
				}

				opcaoUsuario = ObterOpcaoUsuario();
			}

			Console.WriteLine("Obrigado por campartilhar sua Demos conosco.");
			Console.ReadLine();
        }

        private static void ExcluirDemo()
		{
			Console.Write("Digite o id da Demo: ");
			int indiceDemo = int.Parse(Console.ReadLine());

			repositorio.Exclui(indiceDemo);
		}

        private static void VisualizarDemo()
		{
			Console.Write("Digite o id da Demo: ");
			int indiceDemo = int.Parse(Console.ReadLine());

			var demo = repositorio.RetornaPorId(indiceDemo);

			Console.WriteLine(demo);
		}

        private static void AtualizarDemo()
		{
			Console.Write("Digite o id da Demo: ");
			int indiceDemo = int.Parse(Console.ReadLine());

			
			foreach (int i in Enum.GetValues(typeof(Mapa)))
			{
				Console.WriteLine("{0}-{1}", i, Enum.GetName(typeof(Mapa), i));
			}
			Console.Write("Digite o Mapa entre as opções acima: ");
			int entradaMapa = int.Parse(Console.ReadLine());

			Console.Write("Digite o Player da Demo: ");
			string entradaPlayer = Console.ReadLine();

			Console.Write("Digite o Título da Demo: ");
			string entradaTitulo = Console.ReadLine();

			Console.Write("Digite o Ano que a Demo foi gravada: ");
			int entradaAno = int.Parse(Console.ReadLine());

			Console.Write("Digite a Descrição da Demo: ");
			string entradaDescricao = Console.ReadLine();

			Demo atualizaDemo = new Demo(id: indiceDemo,
										mapa: (Mapa)entradaMapa,
										player: entradaPlayer,
										titulo: entradaTitulo,
										ano: entradaAno,
										descricao: entradaDescricao);

			repositorio.Atualiza(indiceDemo, atualizaDemo);
		}
        private static void ListarDemo()
		{
			Console.WriteLine("Listar Demo");

			var lista = repositorio.Lista();

			if (lista.Count == 0)
			{
				Console.WriteLine("Nenhuma demo cadastrada.");
				return;
			}

			foreach (var demo in lista)
			{
                var excluido = demo.retornaExcluido();
                
				Console.WriteLine("#ID {0}: - {1} {2}", demo.retornaId(), demo.retornaTitulo(), (excluido ? "*Excluído*" : ""));
			}
		}

        private static void InserirDemo()
		{
			Console.WriteLine("Inserir nova Demo");

			
			foreach (int i in Enum.GetValues(typeof(Mapa)))
			{
				Console.WriteLine("{0}-{1}", i, Enum.GetName(typeof(Mapa), i));
			}
			Console.Write("Digite o Mapa entre as opções acima: ");
			int entradaMapa = int.Parse(Console.ReadLine());

			Console.Write("Digite o Player da demo: ");
			string entradaPlayer = Console.ReadLine();

			Console.Write("Digite o Título da demo: ");
			string entradaTitulo = Console.ReadLine();

			Console.Write("Digite o Ano em que a demo foi gravada: ");
			int entradaAno = int.Parse(Console.ReadLine());

			Console.Write("Digite a Descrição da demo: ");
			string entradaDescricao = Console.ReadLine();

			Demo novaDemo = new Demo(id: repositorio.ProximoId(),
										mapa: (Mapa)entradaMapa,
										player: entradaPlayer,
										titulo: entradaTitulo,
										ano: entradaAno,
										descricao: entradaDescricao);

			repositorio.Insere(novaDemo);
		}

        private static string ObterOpcaoUsuario()
		{
			Console.WriteLine();
			Console.WriteLine("HS-Demos a seu dispor!!!");
			Console.WriteLine("Informe a opção desejada:");

			Console.WriteLine("1- Listar demos");
			Console.WriteLine("2- Inserir nova demo");
			Console.WriteLine("3- Atualizar demo");
			Console.WriteLine("4- Excluir demo");
			Console.WriteLine("5- Visualizar demo");
			Console.WriteLine("C- Limpar Tela");
			Console.WriteLine("X- Sair");
			Console.WriteLine();

			string opcaoUsuario = Console.ReadLine().ToUpper();
			Console.WriteLine();
			return opcaoUsuario;
		}
    }
}
