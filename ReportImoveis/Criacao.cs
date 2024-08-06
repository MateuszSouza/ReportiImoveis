

using Newtonsoft.Json;
using ReportImoveis.Core.DinamicDesigner;
using ReportImoveis.Core.Domain;

namespace ReportImoveis
{
    public partial class Criacao : Form
    {
        private int NumeroDeImoveis = 0;
        private List<Imovel> ListaDeImoveis = new List<Imovel>();
        private List<CriacaoInfoLine> CriacaoInfoLinesList = new List<CriacaoInfoLine>();
        private int Deslocamento = 0;
        private Presentation Apresentacao;
        public Criacao()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterParent;
            CriacaoInfoLinesList.Add(new CriacaoInfoLine()
            {
                ValorTxtBox = ValorTxtBox1,
                BanheirosTxtBox = BanheirosTxtBox,
                GaragemTxtBox = GaragemTxtBox,
                DormTxtBox = DormTxtBox,
                Metragem = MetragemTxtBox1,
                LinkImovelTxtBox = LinkImovelTxtBox
            });
        }

        private void Criacao_Load(object sender, EventArgs e)
        {
        }

        private void IncrementoNumeroImoveis()
        {
            NumeroDeImoveis++;
        }
        private void DecrementarNumerDeImoveis()
        {
            NumeroDeImoveis--;
        }

        private void SalvarDados_Click(object sender, EventArgs e)
        {
            Apresentacao = CriarApresentacaoData();

            var serializado = JsonConvert.SerializeObject(Apresentacao);
            MessageBox.Show("Texto inserido" + serializado);
            SaveData(serializado);
        }

        private Presentation CriarApresentacaoData()
        {
            foreach (var item in CriacaoInfoLinesList)
            {
                ListaDeImoveis.Add(new Imovel()
                {
                    Metragem = item.Metragem.Text != null ? int.Parse(item.Metragem.Text) : 0,
                    Valor = item.ValorTxtBox.Text != null ? decimal.Parse(item.ValorTxtBox.Text) : 0,
                    NumeroBanheiros = item.BanheirosTxtBox.Text != null ? int.Parse(item.BanheirosTxtBox.Text) : 0,
                    Garagem = item.GaragemTxtBox.Text != null ? int.Parse(item.GaragemTxtBox.Text) : 0,
                    NumeroDormitorios = item.DormTxtBox.Text != null ? int.Parse(item.DormTxtBox.Text) : 0,
                    LinkImovel = item.LinkImovelTxtBox.Text != null ? item.LinkImovelTxtBox.Text : ""
                });
            }


            var apresentacao = new Presentation()
            {
                Imoveis = ListaDeImoveis,
                Corretor = CorretorTextBox.Text,
                Cliente = NomeClienteTextBox.Text,
                Titulo = NomeEstudo.Text
            };

            apresentacao.CalculateBasicAvaliation();

            return apresentacao;
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
            IncrementoNumeroImoveis();
            Deslocamento = NumeroDeImoveis * 80;
            var size = new Size(100, 27);

            Point LabelPoint = new Point(ImovelLabel.Location.X, ImovelLabel.Location.Y + Deslocamento);
            Label label = new Label();
            label.Location = LabelPoint;
            label.AutoSize = true;
            label.Text = "imóvel " + NumeroDeImoveis;

            TextBox MetragemTextBox = new TextBox();
            Point pointTextBox1 = new Point(MetragemTxtBox1.Location.X, MetragemTxtBox1.Location.Y + Deslocamento);
            MetragemTextBox.Location = pointTextBox1;
            MetragemTextBox.Size = size;

            TextBox ValorTextBox = new TextBox();
            Point pointTextBox2 = new Point(ValorTxtBox1.Location.X, ValorTxtBox1.Location.Y + Deslocamento);
            ValorTextBox.Location = pointTextBox2;
            ValorTextBox.Size = size;

            TextBox BanheirosTextBox = new TextBox();
            Point pointTextBox3 = new Point(BanheirosTxtBox.Location.X, BanheirosTxtBox.Location.Y + Deslocamento);
            BanheirosTextBox.Location = pointTextBox3;
            BanheirosTextBox.Size = size;

            TextBox GaragemTextBox = new TextBox();
            Point GaragemPoint = new Point(GaragemTxtBox.Location.X, GaragemTxtBox.Location.Y + Deslocamento);
            GaragemTextBox.Location = GaragemPoint;
            GaragemTextBox.Size = size;

            TextBox DormitoriosTextBox = new TextBox();
            Point DormitoriosPoint = new Point(DormTxtBox.Location.X, DormTxtBox.Location.Y + Deslocamento);
            DormitoriosTextBox.Location = DormitoriosPoint;
            DormitoriosTextBox.Size = size;

            TextBox LinkImovelTxt = new TextBox();
            Point LinkImovelTxtPoint = new Point(LinkImovelTxtBox.Location.X, LinkImovelTxtBox.Location.Y + Deslocamento);
            LinkImovelTxt.Location = LinkImovelTxtPoint;
            LinkImovelTxt.Size = size;

            PictureBox NewPictureBox = new PictureBox();
            Point PictureBoxSize = new Point(ImovelPictureBox.Location.X, ImovelPictureBox.Location.Y + Deslocamento);
            NewPictureBox.Location = PictureBoxSize;
            NewPictureBox.Size = new Size(75, 75);
            NewPictureBox.BackColor = Color.White;
            NewPictureBox.Click += PictureBox_Click;

            CriacaoInfoLine NewInfo = new CriacaoInfoLine()
            {
                Label = label,
                ValorTxtBox = MetragemTextBox,
                BanheirosTxtBox = ValorTextBox,
                GaragemTxtBox = BanheirosTextBox,
                DormTxtBox = DormitoriosTextBox,
                Metragem = MetragemTextBox,
                LinkImovelTxtBox = LinkImovelTxt,
            };

            CriacaoInfoLinesList.Add(NewInfo);

            Controls.Add(label);
            Controls.Add(MetragemTextBox);
            Controls.Add(ValorTextBox);
            Controls.Add(BanheirosTextBox);
            Controls.Add(GaragemTextBox);
            Controls.Add(DormitoriosTextBox);
            Controls.Add(LinkImovelTxt);
            Controls.Add(NewPictureBox);

        }

        private void PictureBox_Click(object sender, EventArgs e)
        {
            PictureBox SelectedPictureBox = (PictureBox)sender;
            OpenFileDialog _OpenfileDialog = new OpenFileDialog();
            _OpenfileDialog.Filter = "Images (*.BMP;*.JPG;*.GIF,*.PNG,*.TIFF)|*.BMP;*.JPG;*.GIF;*.PNG;*.TIFF";
            if (_OpenfileDialog.ShowDialog() == DialogResult.OK)
            {
                Image imageForPictureBox = Image.FromFile(_OpenfileDialog.FileName);
                SelectedPictureBox.Image = imageForPictureBox;
                SelectedPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }

        private void BtnRemover_Click(object sender, EventArgs e)
        {
            DecrementarNumerDeImoveis();
            var ultimo = CriacaoInfoLinesList.Last();
            Controls.Remove(ultimo.Label);
            Controls.Remove(ultimo.Metragem);
            Controls.Remove(ultimo.ValorTxtBox);
            Controls.Remove(ultimo.BanheirosTxtBox);
            Controls.Remove(ultimo.GaragemTxtBox);
            Controls.Remove(ultimo.DormTxtBox);
            Controls.Remove(ultimo.LinkImovelTxtBox);
            Controls.Remove(ultimo.NewPictureBox);
        }

        private void CalcularBtn_Click(object sender, EventArgs e)
        {
            if (Apresentacao == null)
            {
                Apresentacao = CriarApresentacaoData();
            }

            Apresentacao.CalculateBasicAvaliation();

            Apresentacao.Otimista = new Avaliacao()
            {
                percentual = int.Parse(OtimistaTxtBox.Text),
            };
            Apresentacao.Otimista.CalcularAvaliacao(Apresentacao.AvaliacaoBase);

            Apresentacao.Otimo = new Avaliacao()
            {
                percentual = int.Parse(OtimoNumUpDown.Text),
            };
            Apresentacao.Otimo.CalcularAvaliacao(Apresentacao.AvaliacaoBase);

            Apresentacao.Mercado = new Avaliacao()
            {
                percentual = int.Parse(MercadoNumUpDown.Text),
            };
            Apresentacao.Mercado.CalcularAvaliacao(Apresentacao.AvaliacaoBase);

        }

        private void MercadoNumUpDown_ValueChanged(object sender, EventArgs e)
        {
            NumericUpDown numericUpDown = (NumericUpDown)sender;

            numericUpDown.Value = numericUpDown.Value + 5;
        }
    }
}