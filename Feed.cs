 using System;
using System.Collections.Generic;
using System.IO;
namespace findE
{
	public class Feed
	{

		public static List <Festa> listFesta = new List<Festa>();
		public static List <Hackaton> listHack = new List<Hackaton>();


		public static void criarFesta()
		{
			Console.WriteLine("Informe o Titulo da Sua Festa");
			string titulo = Console.ReadLine();

			Console.WriteLine("Idade minima para entrar");
			int min = int.Parse(Console.ReadLine());

			Console.WriteLine("Informe o Valor do Ingresso");
			double val = double.Parse(Console.ReadLine());

			Console.WriteLine("Sua Festa será Open Bar?");
			Console.WriteLine("1 - Sim");
			Console.WriteLine("2 - Não");
			int respOpen = int.Parse(Console.ReadLine());
			try
			{
				if(respOpen > 2)
				{
					throw new Exception();
				}
			}
			catch(Exception ex1)
			{
				 Console.WriteLine("Resposta Invalida!");
				 Console.WriteLine("Resposta NÃO Selecionada");
				 respOpen = 2;
			}
			
			Console.WriteLine("Sua Festa Terá Uma Banda?");
			Console.WriteLine("1 - Sim");
			Console.WriteLine("2 - Não");
			int respBand = int.Parse(Console.ReadLine());

			try
			{
				if(respBand > 2)
				{
					throw new Exception();
				}
			}
			catch(Exception ex2)
			{
				Console.WriteLine("Resposta Invalida!");
				 Console.WriteLine("Resposta NÃO Selecionada");
				 respBand = 2;
			}
			Console.WriteLine("Sua Festa tera pista de dança");
			Console.WriteLine("1 - Sim");
			Console.WriteLine("2 - Não");
			int resPista = int.Parse(Console.ReadLine());

			try
			{
				if(resPista > 2)
				{
					throw new Exception();
				}
			}
			catch(Exception ex3)
			{
				Console.WriteLine("Resposta Invalida!");
				Console.WriteLine("Resposta NÃO Selecionada");
				resPista = 2;
			}
			// TODO : Criar Festa E Add Na Lista
			bool openBar, band, pista;
			if(respOpen == 1)
			{
				openBar = true;
			}else { 
				openBar = false;
				};

			if(respBand == 1)
			{
				band = true;
			}else{
				band = false;
			}
			if(resPista == 1)
			{
				pista = true;
			}else{
				pista = false;
			}

			listFesta.Add(new Festa(openBar, band, pista));
			//TODO : Add Atributos externos
			int cFest = listFesta.Count -1;
			listFesta[cFest].Titulo = titulo;
			listFesta[cFest].MinIdade = min;
			listFesta[cFest].Valor = val;
			
			//TODO: Add Titulo em um txt

			StreamWriter pen;
			string path = "nameFestas.txt";
			pen = File.AppendText(path);
			pen.WriteLine(listFesta[cFest].Titulo);
			pen.Close();
			// Console.WriteLine(listFesta[cFest].Titulo);

		
		


			

			
		}

		public static void criarHack()
		{
			bool doac, equip;
			Console.WriteLine("Informe o Titulo do Seu Evento");
			string tit = Console.ReadLine();
			Console.WriteLine("Informe a Idade Minima Para Participar do Seu Evento");
			int min = int.Parse(Console.ReadLine());
			Console.WriteLine("Informe o Valor Para Participar do seu Evento");
			double val = double.Parse(Console.ReadLine());


			// TODO: Tratar as exesções para criar o construtor

			// 	_doacao = doacao;
			// _equipamento = equipamento;

			Console.WriteLine("Para Participar do Seu Evento, Será necessario alguma doação?");
			Console.WriteLine("1- Sim");
			Console.WriteLine("2 - Não");
			int cDoa = int.Parse(Console.ReadLine());
			try
			{
				if(cDoa > 2)
				{
					throw new Exception();
				}
			}
			catch(Exception ex1)
			{
				Console.WriteLine("Comando Invalido");
				Console.WriteLine("Resposta NÃO Selecionada");
				cDoa = 2;
			}

			Console.WriteLine("Para participar do evento o participante precisará levar o proprio equipamento?");
			int cEq = int.Parse(Console.ReadLine());

			try
			{
				if(cEq > 2)
				{
					throw new Exception();
				}
			}
			catch(Exception ex2)
			{
				Console.WriteLine("Comando Invalido");
				Console.WriteLine("Resposta NÃO Selecionada");
				cEq = 2;				
			}

			// TODO :  Add um Construtor

			if(cDoa == 1)
			{
				doac = true;

			}else{
				doac = false;
			}

			if(cEq == 1)
			{
				equip = true;
			}else{
				equip = false;
			}

			listHack.Add(new Hackaton(doac, equip));





		}

		public static void listarFestas()
		{
			for(int i = 0 ; i < listFesta.Count; i++)
			{
				Console.WriteLine(listFesta[i].Titulo);
			}
			Console.WriteLine("Precione ENTER Para Sair");
			Console.ReadKey();
		}

		public static void listarHacks()
		{
			for(int i = 0 ; i < listHack.Count; i++)
			{
				Console.WriteLine(listHack[i].Titulo);
			}
			Console.WriteLine("Precione ENTER Para Sair");
			Console.ReadKey();
		}


















		
	}
}

