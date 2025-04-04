﻿namespace RoboTupiniquim.ConsoleApp;

public class Robo
{
    public int PosicaoX { get; set; }
    public int PosicaoY { get; set; }
    public char Direcao { get; set; }
    public bool OutOfBounds { get; set; }

    public Robo()
    {
        PosicaoX = 0;
        PosicaoY = 0;
        Direcao = 'N';
        OutOfBounds = false;
    }

    public void MostrarPosicaoAtual()
    {
        Console.WriteLine();
        Console.WriteLine($"{PosicaoX} {PosicaoY} {Direcao}");
        Console.WriteLine();
        Console.WriteLine("Press any key to continue...");
        Console.ReadKey();
    }

    public int[] RetornarPosicao()
    {
        int[] posicao = { PosicaoX, PosicaoY };
        return posicao;
    }

    public void DefinirPosicaoInicial(int[] grid)
    {
        int gridX = grid[0];
        int gridY = grid[1];

        Console.WriteLine("\nInsert the robot initial position down below:");
        Console.Write("FORMAT 'X, Y, (Direction)' NO COMMA, SPACED: ");
        string auxPosicao = Console.ReadLine();

        string[] posicao = auxPosicao.Split(' ', '\t');

        string auxPosicaoX = posicao[0];
        string auxPosicaoY = posicao[1];

        string direcao = posicao[2].ToString().ToUpper();

        int posicaoX = default;
        int posicaoY = default;

        while (!int.TryParse(auxPosicaoX, out posicaoX) || (!int.TryParse(auxPosicaoY, out posicaoY)) ||
            (direcao != "N") && (direcao != "S") && (direcao != "L") && (direcao != "O"))
        {
            Console.Write("Invalid values! Try again: ");
            auxPosicao = Console.ReadLine();
            posicao = auxPosicao.Split(' ', '\t');

            auxPosicaoX = posicao[0];
            auxPosicaoY = posicao[1];
            direcao = posicao[2].ToString().ToUpper();
        }

        PosicaoX = posicaoX;
        PosicaoY = posicaoY;
        Direcao = Convert.ToChar(direcao);
    }

    public void MovimentarRobo(int[] grid)
    {
        int gridX = grid[0];
        int gridY = grid[1];

        Console.Clear();
        Console.Write("CURRENT POSITION");
        MostrarPosicaoAtual();
        Console.WriteLine("\nCONTROLS");
        Console.WriteLine();
        Console.WriteLine("E - Turn 90º to the left");
        Console.WriteLine("D - Turn 90º to the right");
        Console.WriteLine("M - Move one direction to the current position it's facing to");

        Console.Write("Insert the command string: ");
        string comandos = Console.ReadLine().ToUpper();

        foreach (var comando in comandos)
        {
            if (PosicaoX < 0 || PosicaoY < 0 || PosicaoX > gridX || PosicaoY > gridY)
            {
                Console.WriteLine("The robot is out of bounds!");
                OutOfBounds = true;
                return;
            }
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
                    else if (Direcao == 'O')
                        PosicaoX--;
                    break;
                default:
                    break;
            }
        }
    }
    public bool PosicaOcupada(Robo robo)
    {
        if(PosicaoX == robo.PosicaoX && PosicaoY == robo.PosicaoY)
            return true;
        else
            return false;
    }
}