namespace JogodeAdivinhacao.ConsoleApp
{
    class Escreva
    {
        public static void Menu() 
        {
            Console.Clear();
            Console.WriteLine("----------------------------------------");
            Console.WriteLine("         Jogo de Adivinhação");
            Console.WriteLine("----------------------------------------");
            Console.WriteLine("1 - Iniciar um jogo");
            Console.WriteLine("2 - Como Jogar");
            Console.WriteLine("3 - Sair");
            Console.WriteLine("----------------------------------------");
            Console.Write("-> Digite uma opção: ");
        }

        public static void MenuDificuldade() 
        {
            Console.Clear();
            Console.WriteLine("----------------------------------------");
            Console.WriteLine("     Escolha um nível de dificuldade");
            Console.WriteLine("----------------------------------------");
            Console.WriteLine("1 - Fácil (8 tentativas)");
            Console.WriteLine("2 - Normal (5 tentativas)");
            Console.WriteLine("3 - Difícil (3 tentativas)");
            Console.WriteLine("4 - Sortido (será gerado um número de tentativas aleatório)");
            Console.WriteLine("----------------------------------------");
            Console.Write("Digite sua escolha: ");
        }

        public static void ComoJogar() 
        {
            Console.Clear();
            Console.WriteLine("----------------------------------------");
            Console.WriteLine("         Regras do Jogo");
            Console.WriteLine("----------------------------------------");
            Console.WriteLine("1. Você pode escolher o nível dificuldade, que influenciam o número de tentativas.");
            Console.WriteLine("2. Um número aleatório será gerado ao ínicio do jogo.");
            Console.WriteLine("3. Você tenta adivinhar este número de acordo com a dificuldade.");
            Console.WriteLine("4. A cada tentativa você receberá uma dica para chutar na próxima tentativa. ");
            Console.WriteLine("----------------------------------------");
            Console.Write("-> Enter para voltar ao menu: ");
            Console.ReadKey();
        }

        public static void Acerto() 
        {
            Console.WriteLine(" --------------------------------------");
            Console.WriteLine("    *          *          * ");
            Console.WriteLine("           *          *          * ");
            Console.WriteLine("");
            Console.WriteLine($"          !!! Parabéns !!!");
            Console.WriteLine("        Você acertou o número!       ");
            Console.WriteLine("");
            Console.WriteLine("     *             *        ");
            Console.WriteLine(" *          *          *         *");
            Console.WriteLine(" --------------------------------------");
            Console.Write("-> Enter para voltar ao menu: ");
            Console.ReadKey();
        }

        public static void Errou(int numeroSecreto)
        {
            Console.WriteLine("----------------------------------------");
            Console.WriteLine("Que pena! Você usou todas as tentativas.");
            Console.WriteLine($"O número secreto era: {numeroSecreto}.");
            Console.WriteLine("Boa Sorte na próxima!");
            Console.WriteLine("----------------------------------------");
            Console.Write("-> Enter para voltar ao menu: ");
            Console.ReadKey();
        }

        public static void NumeroMaior(int numeroDigitado) 
        {
            Console.WriteLine("----------------------------------------");
            Console.WriteLine($"Dica: o número {numeroDigitado} é maior que o número secreto.");
            Console.WriteLine("----------------------------------------");
        }

        public static void NumeroMenor(int numeroDigitado) 
        {
          
            Console.WriteLine("----------------------------------------");
            Console.WriteLine($"Dica: o número {numeroDigitado} é menor que o número secreto.");
            Console.WriteLine("----------------------------------------");
        }
        public static void Adeus() 
        {
            Console.Clear();
            Console.WriteLine("---------------------");
            Console.WriteLine(" Até a próxima!  0/ ");
            Console.WriteLine("---------------------");
        }
        public static void OpcaoInválida() 
        {
            Console.Write(" -> (X) Opção inválida! Digite novamente: ");
        }
    }
}
