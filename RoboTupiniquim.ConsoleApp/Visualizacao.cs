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
            Console.WriteLine("Initializing system...");
            Thread.Sleep(2000);
            Console.WriteLine("Welcome to GRUB!");
            Thread.Sleep(500);
            Console.Write("\nCPU Cortex-A720 Arm64x : ");
            Thread.Sleep(1000);
            Console.Write("CHECK");
            Console.Write("\nRAM 65536Mb: ");
            Thread.Sleep(1000);
            Console.Write("CHECK");
            Console.Write("\nDISK 1 CrucialT205 2048Gb: ");
            Thread.Sleep(1000);
            Console.Write("CHECK");
            Console.Write("\nDISK 2 CrucialT205 2048Gb:");
            Thread.Sleep(1000);
            Console.Write("CHECK");
            Console.WriteLine("\nChecking for any USB devices...");
            Thread.Sleep(1000);
            Console.WriteLine();
            Console.WriteLine("\nUser Id confirmed");
            Console.WriteLine("Link stabilished");
            Console.WriteLine(bootScreen);
            Console.WriteLine("A joint venture from AEB (Agência Nacional Brasileira) and AP (Academia do Programador)");
            Console.WriteLine("*for registred use only");
            Console.WriteLine("Academia do programador 2025 All rights reserved.");
            Console.WriteLine("\n\nPress any key to continue...");
            Console.ReadKey();
        }
        public static string[] CriarMapa()
        {
            Console.Clear();
            Console.WriteLine("Insert the size of the grid down below:");
            Console.Write("FORMAT X,Y (NO COMMA, SPACED): ");
            string auxPosicao = Console.ReadLine();

            string[] posicao = auxPosicao.Split(' ', '\t');

            string auxPosicaoX = posicao[0];
            string auxPosicaoY = posicao[1];

            int posicaoX = default;
            int posicaoY = default;

            while (!int.TryParse(auxPosicaoX, out posicaoX) || (!int.TryParse(auxPosicaoY, out posicaoY)))
            {
                Console.Write("Invalid values! Try again: ");
                auxPosicao = Console.ReadLine();

                posicao = auxPosicao.Split(' ', '\t');

                auxPosicaoX = posicao[0];
                auxPosicaoY = posicao[1];
            }          
            return posicao;
        }
    }
}
