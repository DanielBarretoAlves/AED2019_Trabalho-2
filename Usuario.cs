using System;
using System.Collections.Generic;
using System.Text;

namespace findE
{
    public class Usuario
    {
			private string _nome;
			private int _idade;

			public Usuario(string _nome, int _idade)
			{
				this._nome = _nome;
				this._idade = _idade;
			}
			public Usuario()
			{

			}

			internal string Nome
			{
				get => _nome;
				set => _nome = value;
			}
			internal int Idade 
			{
				get => _idade;
				set => _idade = value;
			}
    }
}
