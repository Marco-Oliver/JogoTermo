using System.Security.Cryptography;

namespace Program
{
    static class PalavraAleatoria
    {
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
    }
}