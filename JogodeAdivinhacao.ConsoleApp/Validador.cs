namespace JogodeAdivinhacao.ConsoleApp
{
    class Validador
    {
        public static int EhUmaOpcao(int min, int max)
        {
            int opcao;
            while (!int.TryParse(Console.ReadLine(), out opcao) || opcao < min || opcao > max)
            {
                Escreva.OpcaoInválida();
            }
            return opcao;
        }
    }
}
