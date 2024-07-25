using System;

namespace JogoPedraPapelTesoura
{
    class Program
    {
        static int vitoriasJogador = 0;
        static int vitoriasComputador = 0;
        static int empates = 0;

        static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Jogo de Pedra, Papel e Tesoura");
                Console.WriteLine("Escolha uma opção:");
                Console.WriteLine("1. Pedra");
                Console.WriteLine("2. Papel");
                Console.WriteLine("3. Tesoura");
                Console.WriteLine("4. Sair");
                Console.Write("Escolha: ");

                string escolhaUsuario = Console.ReadLine();
                if (escolhaUsuario == "4")
                {
                    break;
                }

                if (escolhaUsuario != "1" && escolhaUsuario != "2" && escolhaUsuario != "3")
                {
                    Console.WriteLine("Escolha inválida. Pressione qualquer tecla para tentar novamente.");
                    Console.ReadKey();
                    continue;
                }

                Random random = new Random();
                int escolhaComputador = random.Next(1, 4);

                switch (escolhaComputador)
                {
                    case 1:
                        Console.WriteLine("Computador escolheu: Pedra");
                        break;
                    case 2:
                        Console.WriteLine("Computador escolheu: Papel");
                        break;
                    case 3:
                        Console.WriteLine("Computador escolheu: Tesoura");
                        break;
                }

                string resultado = ObterResultado(escolhaUsuario, escolhaComputador.ToString());
                Console.WriteLine(resultado);
                Console.WriteLine($"Vitórias do Jogador: {vitoriasJogador}");
                Console.WriteLine($"Vitórias do Computador: {vitoriasComputador}");
                Console.WriteLine($"Empates: {empates}");
                Console.WriteLine("Pressione qualquer tecla para jogar novamente...");
                Console.ReadKey();
            }
        }

        static string ObterResultado(string escolhaUsuario, string escolhaComputador)
        {
            if (escolhaUsuario == escolhaComputador)
            {
                empates++;
                return "Empate!";
            }

            if ((escolhaUsuario == "1" && escolhaComputador == "3") ||
                (escolhaUsuario == "2" && escolhaComputador == "1") ||
                (escolhaUsuario == "3" && escolhaComputador == "2"))
            {
                vitoriasJogador++;
                return "Você ganhou!";
            }

            vitoriasComputador++;
            return "Você perdeu!";
        }
    }
}