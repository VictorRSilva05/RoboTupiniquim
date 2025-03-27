using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoboTupiniquim.ConsoleApp
{
    public static class Visualizacao
    {
        public static void ApresentarEmpresa()
        {

            string bootScreen = @"

 _____           _       _             _           
|_   _|         (_)     (_)           (_)          
  | |_   _ _ __  _ _ __  _  __ _ _   _ _ _ __ ___  
  | | | | | '_ \| | '_ \| |/ _` | | | | | '_ ` _ \ 
  | | |_| | |_) | | | | | | (_| | |_| | | | | | | |
  \_/\__,_| .__/|_|_| |_|_|\__, |\__,_|_|_| |_| |_|
          | |                 | |                  
          |_|                 |_|                  

";
            Console.WriteLine(bootScreen);
            Console.WriteLine("A joint venture from AEB and AP");
            Console.WriteLine("Pressione qualquer tecla para continuar: ");
            Console.ReadKey();
        }
        public static string[] CriarMapa()
        {
            Console.Clear();
            Console.WriteLine("Insira o tamanho do grid:");
            Console.Write("FORMAT X,Y (NO COMMA, SPACED): ");
            string auxPosicao = Console.ReadLine();

            string[] posicao = auxPosicao.Split(' ', '\t');

            string auxPosicaoX = posicao[0];
            string auxPosicaoY = posicao[1];

            int posicaoX = default;
            int posicaoY = default;

            while (!int.TryParse(auxPosicaoX, out posicaoX) || (!int.TryParse(auxPosicaoY, out posicaoY)))
            {
                Console.Write("Valores inválidos, tente novamente: ");
                auxPosicao = Console.ReadLine();

                posicao = auxPosicao.Split(' ', '\t');

                auxPosicaoX = posicao[0];
                auxPosicaoY = posicao[1];
            }
            
            return posicao;
        }

    }
}
