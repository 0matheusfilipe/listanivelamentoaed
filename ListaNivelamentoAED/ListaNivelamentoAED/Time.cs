using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaNivelamentoAED
{
    internal class Time
    {
        public string Nome { get; set; }
        public Jogador[] Titulares { get; set; }
        public int QuantTitulares { get; set; }
        public Jogador[] Reservas { get; set; }
        public int QuantReservas { get; set; }

        public Time(string nome)
        {
            Nome = nome;
            Titulares = new Jogador[11];
            Reservas = new Jogador[12];
            QuantTitulares = 0;
            QuantReservas = 0;
        }

        public bool AdicionarTitular(Jogador jogador)
        {
            if(QuantTitulares < 12)
            {
                Titulares[QuantTitulares] = jogador;
                QuantTitulares++;
                Console.WriteLine($"Jogador {jogador.Nome} adicionado aos titulares.");
                return true;
            }
            else
            {
                Console.WriteLine($"Não é possível adicionar jogadores porque já existem 11 titulares.");
                return false;
            }

        }

        public bool AdicionarReserva(Jogador jogador)
        {
            if (QuantReservas < 13)
            {
                Reservas[QuantReservas] = jogador;
                QuantReservas++;
                Console.WriteLine($"Jogador {jogador.Nome} adicionado aos reservas.");
                return true;
            }
            else
            {
                Console.WriteLine($"Não foi possível jogadores na reserva.");
                return false;
            }
        }

        public bool SubstituirTitular(string nome, Jogador novoJogador)
        {
            if(Titulares)
        }

    }
}
