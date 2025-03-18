namespace JogodeAdivinhacao.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Escreva.Menu();
                int menuOption = Validador.EhUmaOpcao(1, 3);
                switch (menuOption) 
                {
                    case 1: Jogo.Adivinhar(); break;
                    case 2: Escreva.ComoJogar(); break;
                    case 3: Escreva.Adeus(); return ;
                }
            }               
        }
    }
}
