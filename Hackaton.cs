using System;
namespace findE
{
	public class Hackaton : Evento
	{
		private bool _doacao;
		private bool _equipamento;

		public Hackaton(bool doacao, bool equipamento)
		{
			_doacao = doacao;
			_equipamento = equipamento;
		}


	}
}