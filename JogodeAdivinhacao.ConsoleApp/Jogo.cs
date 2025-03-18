namespace JogodeAdivinhacao.ConsoleApp
{
    class Jogo
    {
        public static int EscolhaDificulade () 
        {
            Random dificuldadeSortido = new Random();

            Escreva.MenuDificuldade();
            int opcaoDificuldade = Validador.EhUmaOpcao(1, 4);          
            int totaldeTentativas = 0;

            switch (opcaoDificuldade)
            {
                case 1: totaldeTentativas = 8; break;

                case 2: totaldeTentativas = 5; break;

                case 3: totaldeTentativas = 3; break;

                case 4: totaldeTentativas = dificuldadeSortido.Next(1, 15); break;

            }
            return totaldeTentativas;
        }
        public static void Adivinhar()
        {
            Random geradorDeNumeros = new Random();
            int totaldeTentativas = EscolhaDificulade();
            int numeroSecreto = geradorDeNumeros.Next(1, 21);
         
            for (int tentativa = 1; tentativa <= totaldeTentativas; tentativa++)
            {
                Console.Clear();
                Console.WriteLine("----------------------------------------");
                Console.WriteLine($"         Tentativa {tentativa} de {totaldeTentativas}");
                Console.WriteLine("----------------------------------------");

                Console.Write("-> Digite um número entre 1 e 20: ");
                int numeroDigitado = Validador.EhUmaOpcao(1, 20);

                if (numeroDigitado == numeroSecreto)
                {
                    Escreva.Acerto();                   
                    break;
                }

                else if (tentativa == totaldeTentativas)
                {
                    Escreva.Errou(numeroSecreto);
                    break;
                }

                else if (numeroDigitado > numeroSecreto)
                {
                    Escreva.NumeroMaior(numeroDigitado);
                }

                else if (numeroDigitado < numeroSecreto)
                {
                    Escreva.NumeroMenor(numeroDigitado);
                }
                Console.Write("-> Enter para tentar de novo:");
                Console.ReadKey();
            }
        }
    }
}
