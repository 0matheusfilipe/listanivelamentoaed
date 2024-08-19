using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaNivelamentoAED
{
    internal class Jogador
    {
        private int _numero;
        private string _nome;
        private string _posicao;

        public int Numero { get { return _numero; } set { _numero = value; } }
        public string Nome { get { return _nome; } set { _nome = value; } }
        public string Posicao { get { return _posicao; } set { _posicao = value; } }

        public Jogador(int numero, string nome, string posicao)
        {
            this._numero = numero;
            this._nome = nome;
            this._posicao = posicao;
        }

    }
}


