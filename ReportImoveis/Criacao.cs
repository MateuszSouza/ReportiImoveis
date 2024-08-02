

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
            StartPosition = FormStartPosition.CenterParent;
            NumeroDeImoveis = 1;
            CriacaoInfoLinesList.Add(new CriacaoInfoLine()
            {
                ValorTxtBox = ValorTxtBox1,
                BanheirosTxtBox = BanheirosTxtBox,
                GaragemTxtBox = GaragemTxtBox,
                DormTxtBox = DormTxtBox,
                Metragem = MetragemTxtBox1
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
                    Metragem = int.Parse(item.Metragem.Text),
                    Valor = decimal.Parse(item.BanheirosTxtBox.Text),
                    NumeroBanheiros = int.Parse(item.BanheirosTxtBox.Text),
                    Garagem = int.Parse(GaragemTxtBox.Text),
                    NumeroDormitorios = int.Parse(DormTxtBox.Text)
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

            

            Point LabelPoint = new Point(ImovelLabel.Location.X, ImovelLabel.Location.Y + Deslocamento);
            Label label = new Label();
            label.Location = LabelPoint;
            label.AutoSize = true;
            label.Text = "imóvel " + NumeroDeImoveis;

            TextBox MetragemTextBox = new TextBox();
            Point pointTextBox1 = new Point(MetragemTxtBox1.Location.X, MetragemTxtBox1.Location.Y + Deslocamento);
            MetragemTextBox.Location = pointTextBox1;
            MetragemTextBox.Size = new Size(170, 27);

            TextBox ValorTextBox = new TextBox();
            Point pointTextBox2 = new Point(385, 162 + Deslocamento);
            ValorTextBox.Location = pointTextBox2;
            ValorTextBox.Size = new Size(170, 27);

            TextBox BanheirosTextBox = new TextBox();
            Point pointTextBox3 = new Point(588, 162 + Deslocamento);
            BanheirosTextBox.Location = pointTextBox3;
            BanheirosTextBox.Size = new Size(170, 27);

            TextBox GaragemTextBox = new TextBox();
            Point GaragemPoint = new Point(588, 162 + Deslocamento);
            GaragemTextBox.Location = GaragemPoint;
            GaragemTextBox.Size = new Size(170, 27);

            TextBox DormitoriosTextBox = new TextBox();
            Point DormitoriosPoint = new Point(588, 162 + Deslocamento);
            DormitoriosTextBox.Location = DormitoriosPoint;
            DormitoriosTextBox.Size = new Size(170, 27);

            CriacaoInfoLine NewInfo = new CriacaoInfoLine()
            {
                Label = label,
                ValorTxtBox = MetragemTextBox,
                BanheirosTxtBox = ValorTextBox,
                GaragemTxtBox = BanheirosTextBox,
            };

            CriacaoInfoLinesList.Add(NewInfo);

            Controls.Add(label);
            Controls.Add(MetragemTextBox);
            Controls.Add(ValorTextBox);
            Controls.Add(BanheirosTextBox);

        }

        private void PrecoUm_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}