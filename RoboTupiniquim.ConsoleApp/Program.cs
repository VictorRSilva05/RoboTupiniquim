namespace RoboTupiniquim.ConsoleApp;

internal class Program
{
    static void Main(string[] args)
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Robo robo1 = new Robo();
        Robo robo2 = new Robo();

        //Visualizacao.ApresentarEmpresa();

        int[] grid = Visualizacao.CriarMapa();

        robo1.DefinirPosicaoInicial(grid);
        robo1.MovimentarRobo(grid);
        robo1.MostrarPosicaoAtual();
        Visualizacao.DesenharMapa(grid,robo1.RetornarPosicao());
        
        Console.Clear();

        robo2.DefinirPosicaoInicial(grid);
        robo2.MovimentarRobo(grid);
        robo2.MostrarPosicaoAtual();
        Visualizacao.DesenharMapa(grid, robo2.RetornarPosicao());
    }
}
