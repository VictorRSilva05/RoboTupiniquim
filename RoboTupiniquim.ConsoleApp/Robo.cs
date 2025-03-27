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
            Console.WriteLine();
            Console.WriteLine($"{PosicaoX} {PosicaoY} {Direcao}");
            Console.WriteLine();
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }

        public void DefinirPosicaoInicial(string[] grid)
        {
            string auxGridX = grid[0];
            string auxGridY = grid[1];

            int gridX = Convert.ToInt32(auxGridX);
            int gridY = Convert.ToInt32(auxGridY);

            Console.WriteLine("\nInsira a posicão inicial do robô:");
            Console.Write("FORMAT 'X, Y, (Direction)' NO COMMA, SPACED: ");
            string posicao = Console.ReadLine();
            string auxPosicaoX = posicao[0].ToString();
            string auxPosicaoY = posicao[1].ToString();
            char auxDirecao = posicao[4];

            int posicaoX = default;
            int posicaoY = default;
            string direcao = auxDirecao.ToString().ToUpper();

            while (!int.TryParse(auxPosicaoX, out posicaoX) || (!int.TryParse(auxPosicaoY, out posicaoY)))
            {
                Console.Write("Valores inválidos, tente novamente: ");
                posicao = Console.ReadLine();

                auxPosicaoX = posicao[0].ToString();
                auxPosicaoY = posicao[2].ToString();
            }

            PosicaoX = posicaoX;
            PosicaoY = posicaoY;
            Direcao = Convert.ToChar(direcao);
        }

        public void MovimentarRobo()
        {
            Console.Clear();
            Console.Write("CURRENT POSITION");
            MostrarPosicaoAtual();
            Console.WriteLine("\nCONTROLS");
            Console.WriteLine();
            Console.WriteLine("E - Virar 90º para esquerda");
            Console.WriteLine("D - Virar 90º para direita");
            Console.WriteLine("M - Move uma posição na direção que está olhando");

            Console.Write("Insira a string de comando: ");
            string comandos = Console.ReadLine().ToUpper();

            foreach (var comando in comandos)
            {
                switch (comando)
                {
                    case 'E':
                        if (Direcao == 'N')
                            Direcao = 'O';
                        else if (Direcao == 'O')
                            Direcao = 'S';
                        else if (Direcao == 'S')
                            Direcao = 'L';
                        else if (Direcao == 'L')
                            Direcao = 'N';
                        break;
                    case 'D':
                        if (Direcao == 'N')
                            Direcao = 'L';
                        else if (Direcao == 'L')
                            Direcao = 'S';
                        else if (Direcao == 'S')
                            Direcao = 'O';
                        else if (Direcao == 'O')
                            Direcao = 'N';
                            break;
                    case 'M':
                        if (Direcao == 'N')
                            PosicaoY++;
                        else if (Direcao == 'S')
                            PosicaoY--;
                        else if (Direcao == 'L')
                            PosicaoX++;
                        else if(Direcao == 'O')
                            PosicaoX--;
                            break;
                    default:
                        break;
                }
            }
        }
    }
}