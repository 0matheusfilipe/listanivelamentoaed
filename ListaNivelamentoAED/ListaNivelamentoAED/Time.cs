using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaNivelamentoAED
{
    internal class Time
    {
        private string _nome;
        private Jogador[] _titulares;
        private int _quantTitulares;
        private Jogador[] _reservas;
        private int _quantReservas;

        public string Nome { get { return _nome; } set { _nome = value; } }

        public Time()
        {
            _titulares = new Jogador[11];
            _reservas = new Jogador[12];
            _quantReservas = 0;
            _quantTitulares = 0;
        }

    }
}
