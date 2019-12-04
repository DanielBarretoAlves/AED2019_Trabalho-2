using System;
using System.Collections.Generic;
using System.Text;

namespace findE
{
    class Evento
    {
        private string _titulo;
        private int _minIdade;
        private double _valor;

        public Evento(string titulo, int minIdade, double valor)
        {
            _titulo = titulo;
            _minIdade = minIdade;
            _valor = valor;
        }

        public string Titulo
        {
            get => _titulo;
            set => _titulo = value;
        }

        public int MinIdade
        {
            get => _minIdade;
            set => _minIdade = value;
        }

        public double Valor
        {
            get => _valor;
            set => _valor = value;
        }




    }
}
