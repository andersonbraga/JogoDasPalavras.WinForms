

namespace JogoDasPalavrasTeste.WinForms
{
    public partial class Form1 : Form
    {
        static Palavras palavras = new Palavras();
        public static string palavraAdivinhar = palavras.ObterPalavraSecreta();

        public Form1()
        {
            InitializeComponent();
            palavras = new Palavras();
              
        }

       

        private void btnGuess_Click_1(object sender, EventArgs e)
        {
            
            lblSecretWord.Text = palavraAdivinhar;

            string palavraEscolhida = txtGuess.Text;

            if (palavraEscolhida.Length == 5)
            {
                if (palavraEscolhida == palavraAdivinhar)
                {
                    lblSecretWord.BackColor = Color.Green;
                    lblSecretWord.ForeColor = Color.White;
                    lblSecretWord.Text = "Você acertou " + palavraAdivinhar;
                }
                else
                {
                    string displayWord = "";
                    for (int i = 0; i < palavraAdivinhar.Length; i++)
                    {
                        if (palavraAdivinhar[i] == palavraEscolhida[i])
                        {
                            displayWord += palavraEscolhida[i];
                            lblSecretWord.BackColor = Color.Green;
                        }
                        else
                        {
                            if (palavraAdivinhar.Contains(palavraEscolhida[i]))
                            {
                                displayWord += "-";
                            }
                            else
                            {
                                displayWord += palavraEscolhida[i];
                            }
                        }
                    }
                    lblSecretWord.Text = displayWord;
                    lblSecretWord.BackColor = Color.Red;
                    lblSecretWord.ForeColor = Color.White;
                }
            }
            else
            {
                lblSecretWord.Text = "Você errou, tente de novo";
                lblSecretWord.BackColor = Color.Yellow;
                lblSecretWord.ForeColor = Color.Black;
            }
           
        }
    }
}