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

            string tamanhoGrid = Visualizacao.CriarMapa();

            robo1.DefinirPosicaoInicial();
        }
    }
}
