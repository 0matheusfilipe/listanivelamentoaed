using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaNivelamentoAED
{
    internal class Teste
    {
        static void Main(string[] args)
        {
            Time time = new Time("Time Exemplo");

            Jogador jogador1 = new Jogador(1, "Jogador 1", "Goleiro");
            Jogador jogador2 = new Jogador(2, "Jogador 2", "Zagueiro");

            time.AdicionarTitular(jogador2);
            time.AdicionarTitular(jogador1);

            Console.ReadKey();
        }
    }
}
