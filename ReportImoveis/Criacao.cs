

using Newtonsoft.Json;
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
            foreach (var item in CriacaoInfoLinesList)
            {
                ListaDeImoveis.Add(new Imovel()
                {
                    Nome = item.TextBox1.Text,
                    Valor = Decimal.Parse(item.TextBox2.Text),
                    Localizacao = item.TextBox3.Text,
                });
            }

            var serializado = JsonConvert.SerializeObject(ListaDeImoveis);
            MessageBox.Show("Texto inserido" + serializado);
            SaveData(serializado);
        }

        private void SaveData(String data)
        {
            // Displays a SaveFileDialog so the user can save the Image
            // assigned to Button2.
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Title = "Save";
            
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                File.WriteAllText(saveFileDialog1.FileName, data);
            }
            // If the file name is not an empty string open it for saving.

        }

        private void AddImovel_Click(object sender, EventArgs e)
        {
            NumeroDeImoveis++;
            var Deslocamento = NumeroDeImoveis * 30;

            Point LabelPoint = new Point(45, 135 + Deslocamento);
            Label label = new Label();
            label.Location = LabelPoint;
            label.AutoSize = true;
            label.Text = "imóvel " + NumeroDeImoveis;

            TextBox textBox1 = new TextBox();
            Point pointTextBox1 = new Point(180, 135 + Deslocamento);
            textBox1.Location = pointTextBox1;
            textBox1.Size = new Size(170, 27);

            TextBox textBox2 = new TextBox();
            Point pointTextBox2 = new Point(385, 135 + Deslocamento);
            textBox2.Location = pointTextBox2;
            textBox2.Size = new Size(170, 27);

            TextBox textBox3 = new TextBox();
            Point pointTextBox3 = new Point(588, 135 + Deslocamento);
            textBox3.Location = pointTextBox3;
            textBox3.Size = new Size(170, 27);

            CriacaoInfoLine NewInfo = new CriacaoInfoLine()
            {
                //Label = label,
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