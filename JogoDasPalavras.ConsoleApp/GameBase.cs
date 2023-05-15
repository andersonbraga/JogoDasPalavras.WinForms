namespace JogoDasPalavras.ConsoleApp
{
    public class GameBase
    {
        Palavras palavras = new Palavras();
        public void JogoDasPalavras()
        {
            string palavraAdivinhar = palavras.ObterPalavraSecreta();


            string palavraEscolhida = null;

            palavraEscolhida = Console.ReadLine();

            if (palavraEscolhida.Length == 5)
            {
                if (palavraEscolhida == palavraAdivinhar)
                {
                    Console.BackgroundColor = ConsoleColor.Green;
                    Console.WriteLine(palavraAdivinhar);
                    Console.ResetColor();
                    Console.WriteLine("Voce acertou " + palavraAdivinhar);
                }
                else
                {
                    for (int i = 0; i < palavraAdivinhar.Length; i++)
                     {
                        if (palavraAdivinhar[i] == palavraEscolhida[i])
                        {
                            Console.BackgroundColor = ConsoleColor.Green;
                            Console.Write(palavraEscolhida[i]);
                        }
                        else
                        {
                            if (palavraAdivinhar.Contains(palavraEscolhida[i]))
                            {
                                Console.BackgroundColor = ConsoleColor.Yellow;
                                Console.Write(palavraEscolhida[i]);
                            }
                            else
                            {
                                Console.BackgroundColor = ConsoleColor.Red;
                                Console.Write(palavraEscolhida[i]);
                            }
                        }
                        if (i == palavraAdivinhar.Length - 1)
                        {
                            Console.WriteLine("");
                        }
                    }
                    Console.ResetColor();
                    JogoDasPalavras();
                }
            }
            else
            {
                Console.WriteLine("Vc errou, tente de novo");
                JogoDasPalavras();
            }

        }
    }
}