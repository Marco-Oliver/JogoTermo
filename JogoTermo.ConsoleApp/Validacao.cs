namespace Program
{
   static class Validacao
    {
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

    }
}