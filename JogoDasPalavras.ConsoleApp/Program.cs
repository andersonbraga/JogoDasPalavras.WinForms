namespace JogoDasPalavras.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("TENTE ADIVINHAR E PALAVRA COM 5 LETRAS");
            GameBase jogoPalavra = new GameBase();
            jogoPalavra.JogoDasPalavras();
            
        }

       
    }
}