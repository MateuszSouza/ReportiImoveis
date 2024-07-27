

using ReportImoveis.Core.DinamicDesigner;
using ReportImoveis.Core.Domain;

namespace ReportImoveis
{
    public partial class Criacao : Form
    {
        private int NumeroDeImoveis { set; get; }
        private List<Imovel> ListaDeImoveis = new List<Imovel>();
        private List<CriacaoInfoLine> CriacaoInfoLinesList = new List<CriacaoInfoLine>();
        public Criacao()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterParent;
            NumeroDeImoveis = 1;
            CriacaoInfoLinesList.Add(new CriacaoInfoLine()
            {
                Label = label4,
                TextBox1 = TextBoxNome1,
                TextBox2 = PrecoIm1,
                TextBox3 = LoacalIm1
            });
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
                    Nome = TextBoxNome1.Text,
                    Valor = Decimal.Parse(PrecoIm1.Text),
                    Localizacao = LoacalIm1.Text,
                };

                MessageBox.Show("Texto inserido" + Imovel1.ToString());
            }
            catch (Exception)
            {
                MessageBox.Show("Valor inválido inserido");
            }
        }

        private void AddImovel_Click(object sender, EventArgs e)
        {
            NumeroDeImoveis++;
            var Deslocamento = NumeroDeImoveis * 30;

            Point LabelPoint = new Point(40, 135 + Deslocamento);
            Label label = new Label();
            label.Location = LabelPoint;
            label.Visible = true;

            TextBox textBox1 = new TextBox();
            Point pointTextBox1 = new Point(190, 135 + Deslocamento);
            textBox1.Location = pointTextBox1;

            TextBox textBox2 = new TextBox();
            Point pointTextBox2 = new Point(394, 135 + Deslocamento);
            textBox2.Location = pointTextBox2;

            TextBox textBox3 = new TextBox();
            Point pointTextBox3 = new Point(597, 135 + Deslocamento);
            textBox3.Location = pointTextBox3;

            CriacaoInfoLine NewInfo = new CriacaoInfoLine()
            {
                Label = label,
                TextBox1 = textBox1,
                TextBox2 = textBox2,
                TextBox3 = textBox3,
            };

            CriacaoInfoLinesList.Add(NewInfo);

            Controls.Add(label);
            Controls.Add(textBox1);
            Controls.Add(textBox2);
            Controls.Add(textBox3);

        }

        private void PrecoUm_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}