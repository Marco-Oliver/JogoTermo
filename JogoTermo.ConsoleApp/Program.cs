using System;
using System.Security.Cryptography;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {

            while (true)
            {
                ExecutarCabecalho();

                string palavraSecreta = EscolherPalavraAleatoria();

                string palavraDigitada = PalavraDigitadaUsuario();

                int tentativasUsadas = ValidacaoLetras(palavraDigitada, palavraSecreta);
                const int maximoTentativas = 5;

                while (tentativasUsadas < maximoTentativas)
                {

                    if (palavraDigitada.Length != 5)
                        continue;

                    if (palavraDigitada == palavraSecreta)
                        break;
                         tentativasUsadas++;

                }

                if (!OpcaoDesejaContinuar() == true)
                    break;

            }
        }

        static void ExecutarCabecalho()
        {
            Console.Clear();
            Console.WriteLine("----------------------------------");
            Console.Write("JOGO  ");
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.Write(" T ");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write(" E ");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write(" R ");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write(" M ");
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.Write(" O ");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("  5 LETRAS!");
            Console.WriteLine("----------------------------------");

        }

      public static string EscolherPalavraAleatoria()
        {
            string[] palavras =
                {
                "CARTA","PEDRA","VERDE","NUVEM","JOGAR","TEMPO","FESTA",
                "LIVRO","JOVEM","DANCA","PRAIA","CARRO","FOLHA","SONHO",
                "MUNDO","NOITE","TARDE","CAMPO","VIDRO","FERRO","CAIXA",
                "PONTO","RISOS","CLARO","BRAVO", "VASCO"
            };

            int palavraSorteada = RandomNumberGenerator.GetInt32(palavras.Length);
            return palavras[palavraSorteada];
        }

      public static string PalavraDigitadaUsuario()
        {
            Console.WriteLine($"                   ");
            Console.WriteLine("--------------------------------");
            Console.WriteLine("\nDigite a palavra: ");
            string? palavraDigitada = Console.ReadLine();

            if (palavraDigitada.Length != 5)
            {
                Console.WriteLine("Digite uma palavra com 5 letras!");
            }
            return palavraDigitada;
        }

        public static int ValidacaoLetras(string palavraDigitada, string palavraSecreta)
        {
            const int maximoTentativas = 5;
            int tentativasUsadas = 0;


            Console.WriteLine($"\nTentativa: {tentativasUsadas + 1}");


            for (int caractere = 0; caractere < 5; caractere++)
            {
                if (palavraDigitada[caractere] == palavraSecreta[caractere])
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write($"{palavraDigitada[caractere]}");
                }
                else if (palavraSecreta.Contains(palavraDigitada[caractere]))
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.Write($"{palavraDigitada[caractere]}");
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write($"{palavraDigitada[caractere]}");
                }


                Console.ForegroundColor = ConsoleColor.White;


            }


            if (palavraDigitada == palavraSecreta)
            {
                ExecutarCabecalho();
                Console.WriteLine("\nVoce acertou a palavra secreta!");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("PARABENS!");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("---------------------------------------");
                Console.WriteLine($"\nA palavra secreta era: ");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"{palavraSecreta}");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("---------------------------------------");
            }


            tentativasUsadas++;

            if (tentativasUsadas == maximoTentativas)
            {
                ExecutarCabecalho();
                Console.WriteLine("\nVoce atingiu o limite de tentativas!");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("PERDEU!");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("---------------------------------------");
                Console.WriteLine($"\nA palavra secreta era: ");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"{palavraSecreta}");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("---------------------------------------");
            }

            return tentativasUsadas;

        }

        static bool OpcaoDesejaContinuar()
        {
            Console.WriteLine("\nDeseja continuar jogando? (s/n?)");
            string opcaoContinuar = Console.ReadLine();

            if (opcaoContinuar?.ToUpper() != "S")
                return false;

            return true;
        }


    }
}