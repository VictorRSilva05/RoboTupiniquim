using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoboTupiniquim.ConsoleApp
{
    public class Robo
    {
        public int PosicaoX { get; set; }
        public int PosicaoY { get; set; }
        public char Direcao { get; set; }

        public Robo()
        {
            PosicaoX = 0;
            PosicaoY = 0;
            Direcao = 'N';
        }

        public void MostrarPosicaoAtual()
        {
            Console.WriteLine($"{PosicaoX} {PosicaoY} {Direcao}");
        }

        public void DefinirPosicaoInicial()
        {
            Console.WriteLine("\nInsira a posicão inicial do robô:");
            Console.Write("FORMAT X,Y (NO COMMA, SPACED): ");
            string posicao = Console.ReadLine();
            string auxPosicaoX = posicao[0].ToString();
            string auxPosicaoY = posicao[2].ToString();

            int posicaoX = default;
            int posicaoY = default;

            while (!int.TryParse(auxPosicaoX, out posicaoX) || (!int.TryParse(auxPosicaoY, out posicaoY)))
            {
                Console.Write("Valores inválidos, tente novamente: ");
                posicao = Console.ReadLine();

                auxPosicaoX = posicao[0].ToString();
                auxPosicaoY = posicao[2].ToString();
            }
        }
    }
}
