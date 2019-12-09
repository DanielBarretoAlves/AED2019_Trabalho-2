using System;
using System.Collections.Generic;
using System.Text;

namespace findE
{
    class Controlador
    {

      public static List <Usuario> listUser = new List<Usuario>();

			public static List <Adm> listAdm = new List<Adm>();
			// public static List 


			// TODO: Criar novo usuario.
			public static void criarUsuario()
			{
				Console.WriteLine("Informe o Seu Nome");
				string nome = Console.ReadLine();
				Console.WriteLine("Informe Sua Idade");
				int idade = int.Parse(Console.ReadLine());

				listUser.Add(new Usuario(nome, idade));

			}

			// TODO: Criar Adm
			public static void criarAdm()
			{
				Console.WriteLine("Infome seu Nome");
				string Nome = Console.ReadLine();

				Console.WriteLine("Infome Sua Idade");
				int idade = int.Parse(Console.ReadLine());
				
				Console.WriteLine("Informe Sua Senha");
				string senha = Console.ReadLine();

				listAdm.Add(new Adm(senha));

			}
			
			//TODO: Select User

			public static int selectUser()
			{
				Console.WriteLine("Selecione Um Usuario");
				int selUser = 0;
				for(int i = 0; i < listUser.Count; i++)
				{
					Console.WriteLine(i + "- " + listUser[i].Nome);
				}
				selUser = int.Parse(Console.ReadLine());

				return selUser;
			}

			//TODO: Select Adm

			public static int selectADM()
			{
				Console.WriteLine("Selecione Um Usuario");
				int selADM = 0;
				for(int i = 0; i < listAdm.Count; i++)
				{
					Console.WriteLine(i + "- " + listAdm[i].Nome);
				}
				selADM = int.Parse(Console.ReadLine());

				return selADM;
			}


			public static void menu()
			{
				bool key = false;
				while(key != true)
				{
					Console.WriteLine("Bem Vindo ao FindE");
					Console.WriteLine("1 - Entre como Usuario");
					Console.WriteLine("2 - Entre como Administrador");
					Console.WriteLine("3 - Crie Um Usuario");
					Console.WriteLine("4 - Crie Um Administrador");
					Console.WriteLine("5 - Sair");
					int cMenu1 = int.Parse(Console.ReadLine());

					try
					{
						if(cMenu1 > 5)
						{
							throw new Exception();
						}
					}
					catch(Exception ex1)
					{
						Console.WriteLine("Opção Invalida");
						Console.WriteLine("Opção 4 Selecionada");
						cMenu1 = 4;
					}

					switch(cMenu1)
					{
						case 1:
						menUser(selectUser());
						break;

						case 2:
						menADM(selectADM());
						break;

						case 3:
						criarUsuario();
						break;

						case 4:
						criarAdm();
						break;
						case 5:
						Console.WriteLine("Hasta La Vista..");
						key = true;
						break;


						

				}
				Console.Clear();
				


				}
			
				

			}

			public static void menADM(int adm)
			{
				Console.WriteLine("Selecione uma Opção");
				Console.WriteLine("1 - Criar uma Festa");
				Console.WriteLine("2 - Visualizar Festas");
				Console.WriteLine("3 - Criar um Hackaton");
				Console.WriteLine("4 - Visualizar os Hackatons Disponiveis");
				Console.WriteLine("5 - Visualizar todos Usuarios");
				int escAdm = int.Parse(Console.ReadLine());
				switch(escAdm)
				{
					case 1:
					Feed.criarFesta();
					break;
					case 2:
					Feed.listarFestas();
					break;

					case 3:
					Feed.criarHack();
					break;

					case 4:
					Feed.listarHacks();
					break;

					case 5:
					listarUsuarios();
					break;
				}
				
			}


			public static void listarUsuarios()
		{
			for(int i = 0 ; i < listUser.Count; i++)
			{
				Console.WriteLine(listUser[i].Nome);
			}
			Console.WriteLine("Precione ENTER Para Sair");
			Console.ReadKey();
		}







			public static void menUser(int user)
			{
				Console.WriteLine("Selecione uma Opção");
				Console.WriteLine("1 - Criar uma Festa");
				Console.WriteLine("2 - Visualizar Festas");
				Console.WriteLine("3 - Criar um Hackaton");
				Console.WriteLine("4 - Visualizar os Hackatons Disponiveis");
				int escUser = int.Parse(Console.ReadLine());
				switch(escUser)
				{
					case 1:
					Feed.criarFesta();
					break;
					case 2:
					Feed.listarFestas();
					break;

					case 3:
					Feed.criarHack();
					break;

					case 4:
					Feed.listarHacks();
					break;
				}
			}

			

			
			







    }
}
