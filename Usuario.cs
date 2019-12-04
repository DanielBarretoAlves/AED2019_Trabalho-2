using System;
using System.Collections.Generic;
using System.Text;

namespace findE
{
    class Usuario
    {
        private string _nome;
        private int _idade;

        public string Nome
        {
            get => _nome;
            set => _nome = value;
        }

        public int Idade
        {
            get => _idade;
            set => _idade = value;
        }

    }
}
