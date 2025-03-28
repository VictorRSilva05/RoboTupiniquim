namespace RoboTupiniquim.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Robo robo1 = new Robo();
            Robo robo2 = new Robo();

            Visualizacao.ApresentarEmpresa();

            string[] grid = Visualizacao.CriarMapa();


            robo1.DefinirPosicaoInicial(grid);

            robo1.MovimentarRobo();
            robo1.MostrarPosicaoAtual();

            Console.Clear();

            robo2.DefinirPosicaoInicial(grid);
            robo2.MovimentarRobo();
            robo2.MostrarPosicaoAtual();
        }
    }
}
