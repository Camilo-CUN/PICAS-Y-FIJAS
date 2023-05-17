namespace PICAS_Y_FIJAS
{

    public partial class Form1 : Form
    {
        int picas = 0;
        int fijas = 0;
        int numeroAleatorio = 0;
        public Form1()
        {

            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void BTNGENERAR_Click(object sender, EventArgs e)
        {
            Random randm = new Random();

            numeroAleatorio = randm.Next(1000, 10000);
            NUMEROALBL.Text = numeroAleatorio.ToString();

        }

        private void TXTNUMERO_TextChanged(object sender, EventArgs e)
        {

        }

        private void BTNVALIDAR_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < TXTNUMERO.Text.Length; i++)
            {
                char c = TXTNUMERO.Text[i];

                if (numeroAleatorio.ToString().Contains(c))
                {
                    int posicion = numeroAleatorio.ToString().IndexOf(c);
                    if (posicion != i)
                    {
                        picas++;
                        LBLPICAS.Text = "PICAS:" + picas.ToString();
                    }
                }

            }

            for (int i = 0; i < TXTNUMERO.Text.Length; i++)
            {
                if (TXTNUMERO.Text[i] == numeroAleatorio.ToString()[i])
                {
                    fijas++;
                    LBLFIJAS.Text = "FIJAS:" + fijas.ToString();
                }
            }

            if(TXTNUMERO.Text == numeroAleatorio.ToString())
            {
                TXTNUMERO.Text = "GANASTE";
            }else
            {
                TXTNUMERO.Text = "Sigue Intentando";
            }

        }

        private void BTNREINICIAR_Click(object sender, EventArgs e)
        {
            LBLFIJAS.Text = "FIJAS:";
            LBLPICAS.Text = "PICAS:";
            NUMEROALBL.Text = "NUMERO ALEATORIO:";
            numeroAleatorio = 0; 
        }
    }
}