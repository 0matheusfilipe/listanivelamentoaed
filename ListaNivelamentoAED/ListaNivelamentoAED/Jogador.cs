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
        public int Numero { get; set; }
        public string Nome { get; set; }
        public string Posicao { get; set; }

        public Jogador(int numero, string nome, string posicao)
        {
            Numero = numero;
            Nome = nome;
            Posicao = posicao;
        }

    }
}


