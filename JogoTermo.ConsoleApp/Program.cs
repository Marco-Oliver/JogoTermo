using System;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {

            while (true)
            {
                ExecutarCabecalho();

                string palavraSecreta = PalavraAleatoria.EscolherPalavraAleatoria();

                string palavraDigitada = PalavraDigitadaUsuario();

                int tentativasUsadas = Validacao.ValidacaoLetras(palavraDigitada, palavraSecreta);
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