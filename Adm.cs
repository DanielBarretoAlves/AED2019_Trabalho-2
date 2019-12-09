using System;
using System.Collections.Generic;
namespace findE
{
	public class Adm : Usuario
	{
		private string _senha;
		public Adm(string _senha)
		{
			this._senha = _senha;
		}
	}
}