namespace JogoDasPalavras.WinApp
{
    public partial class Form1 : Form
    {
        private Palavra jogoDaPalavra;
        private Random rand = new Random();
        private int PosicaoAtual = 1;
        private string LetraAtual = string.Empty;
        private List<string> ListaPalavra = new List<string>();
        private List<TextBox> TxtAtual = new List<TextBox>();
        private const string Caminho_Palavra = @"C:\Users\Dandy\source\repos\JogoDasPalavras.WinForms\JogoDasPalavras.WinApp\ListaPalavra.txt";

        public Form1()
        {
            InitializeComponent();
            ListaPalavra = PegarPalavra();
            NovoJogo();

            //ObterPalavraParcial();
        }

        private void NovoJogo()
        {

            LetraAtual = ListaPalavra[rand.Next(ListaPalavra.Count)];

            PosicaoAtual = 1;

            btnEnter.Enabled = true;
        }

        private List<string> PegarPalavra()
        {

            List<string> TodasPalavra = new List<string>();
            using (StreamReader reader = new StreamReader(Caminho_Palavra))
            {
                while (!reader.EndOfStream)
                {

                    var proximaLinha = reader.ReadLine();
                    TodasPalavra.Add(proximaLinha);
                }
            }
            return TodasPalavra;
        }

        private string ObterPalavra()
        {


            TxtAtual = new List<TextBox>();

            string auxiliarString = String.Empty;
            //1) What line are we on?
            switch (PosicaoAtual)
            {
                case 1:
                    auxiliarString = textBox1.Text
                            + textBox2.Text
                            + textBox3.Text
                            + textBox4.Text
                            + textBox5.Text;
                    TxtAtual.Add(textBox1);
                    TxtAtual.Add(textBox2);
                    TxtAtual.Add(textBox3);
                    TxtAtual.Add(textBox4);
                    TxtAtual.Add(textBox5);
                    break;
                case 2:
                    auxiliarString = textBox6.Text
                            + textBox7.Text
                            + textBox8.Text
                            + textBox9.Text
                            + textBox10.Text;
                    TxtAtual.Add(textBox6);
                    TxtAtual.Add(textBox7);
                    TxtAtual.Add(textBox8);
                    TxtAtual.Add(textBox9);
                    TxtAtual.Add(textBox10);
                    break;
                case 3:
                    auxiliarString = textBox11.Text
                            + textBox12.Text
                            + textBox13.Text
                            + textBox14.Text
                            + textBox15.Text;
                    TxtAtual.Add(textBox11);
                    TxtAtual.Add(textBox12);
                    TxtAtual.Add(textBox13);
                    TxtAtual.Add(textBox14);
                    TxtAtual.Add(textBox15);
                    break;
                case 4:
                    auxiliarString = textBox16.Text
                            + textBox17.Text
                            + textBox18.Text
                            + textBox19.Text
                            + textBox20.Text;
                    TxtAtual.Add(textBox16);
                    TxtAtual.Add(textBox17);
                    TxtAtual.Add(textBox18);
                    TxtAtual.Add(textBox19);
                    TxtAtual.Add(textBox20);
                    break;
                case 5:
                    auxiliarString = textBox21.Text
                            + textBox22.Text
                            + textBox23.Text
                            + textBox24.Text
                            + textBox25.Text;
                    TxtAtual.Add(textBox21);
                    TxtAtual.Add(textBox22);
                    TxtAtual.Add(textBox23);
                    TxtAtual.Add(textBox24);
                    TxtAtual.Add(textBox25);
                    break;

            }

            return auxiliarString;
        }

        private void BackgroundColor(int index, TextBox t)
        {

            if (!LetraAtual.Contains(t.Text, StringComparison.OrdinalIgnoreCase))
            {
                t.BackColor = Color.Gray;
            }

            else if (LetraAtual[index].ToString().ToLower() != t.Text.ToLower())
            {
                t.BackColor = Color.Yellow;
            }
            else
            {

                t.BackColor = Color.LightGreen;
            }
        }

        private void FimJogo()
        {

            MessageBox.Show("Parabens, voce ganhou");

            btnEnter.Enabled = false;
        }

        private bool ValidarPalavra(string teste)
        {

            if (LetraAtual.Equals(teste, StringComparison.OrdinalIgnoreCase))
            {
                return true;
            }

            return false;
        }


        private void btnNovoJogo_Click(object sender, EventArgs e)
        {
            NovoJogo();
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            string letraEscolhida = ObterPalavra();


            if (!ValidarPalavra(letraEscolhida))
            {

                return;
            }


            bool isCorrect = ValidarPalavra(letraEscolhida);


            for (int i = 0; i < TxtAtual.Count(); i++)
            {
                BackgroundColor(i, TxtAtual[i]);
            }


            if (isCorrect)
            {
                FimJogo();
                return;
            }


            PosicaoAtual++;
            if (PosicaoAtual > 6)
            {
                MessageBox.Show("Voce Perdeu" + LetraAtual);
                btnEnter.Enabled = false;
            }
        }





        //private void ObterPalavraParcial()
        //{
        //    lblPalavraSecreta.Text = jogoDaPalavra.PalavraParcial;
        //}




    }
}