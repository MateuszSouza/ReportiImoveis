

using ReportImoveis.Core.Domain;

namespace ReportImoveis
{
    public partial class Criacao : Form
    {
        public Criacao()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterParent;
        }

        private void Criacao_Load(object sender, EventArgs e)
        {
        }

        private void label4_Click(object sender, EventArgs e)
        {
        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void SalvarDados_Click(object sender, EventArgs e)
        {
            try
            {
                var Imovel1 = new Imovel
                {
                    Nome = LabelNome1.Text,
                    Valor = Decimal.Parse(PrecoIm1.Text),
                    Localizacao = LoacalIm1.Text,
                };
                
                MessageBox.Show("Texto inserido" + Imovel1.ToString());
            }
            catch (Exception)
            {

                throw;
            }
            


            
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void PrecoUm_TextChanged(object sender, EventArgs e)
        {

        }
    }
}