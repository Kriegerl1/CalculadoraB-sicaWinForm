namespace CalculadoraBasica.WinApp
{
    public partial class CalculadoraForm : Form
    {
        public CalculadoraForm()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double primeiroNumero = Convert.ToDouble(txtPrimeiroNumero.Text);
            double segundoNumero = Convert.ToDouble(txtSegundoNumero.Text);
            string descricaoOperacao = "";
            double resposta = 0;

            if (rdbAdicao.Checked)
            {
                resposta = primeiroNumero + segundoNumero;
                descricaoOperacao = primeiroNumero + "+" + segundoNumero + "=" + resposta ;
            }
            if (rdbSubtracao.Checked)
            {
                resposta = primeiroNumero - segundoNumero;
                descricaoOperacao = primeiroNumero + "-" + segundoNumero + "=" + resposta;

            }
            if (rdbMultiplicacao.Checked)
            {
                resposta = primeiroNumero * segundoNumero;
                descricaoOperacao = primeiroNumero + "x" + segundoNumero + "=" + resposta;

            }
            if (rdbDivisao.Checked)
            {
                if (segundoNumero > 0)
                {
                    resposta = primeiroNumero / segundoNumero;
                    descricaoOperacao = primeiroNumero + "/" + segundoNumero + "=" + resposta;

                }
                else
                {
                    MessageBox.Show(
                        $"O Primeiro Número não pode ser dividido por 0.",
                            "Resultado",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error
                        );
                }
            }

            lblResposta.Text = resposta.ToString();
            listHistorico.Items.Add(descricaoOperacao);
        }
    }
}
