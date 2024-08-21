using Newtonsoft.Json;
using ReportImoveis.Core.DinamicDesigner;
using ReportImoveis.Core.Domain;
using ReportImoveis.Repository;
using System.Windows.Forms;

namespace ReportImoveis
{
    public partial class Criacao : Form
    {
        private int NumeroDeImoveis = 0;
        private List<CriacaoInfoLine> CriacaoInfoLinesList = new List<CriacaoInfoLine>();
        private int Deslocamento = 0;
        private Presentation Apresentacao;
        private DataControl dataControl;
        private DinamicDesinger DinamicDesinger = new DinamicDesinger();

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
                LinkImovelTxtBox = LinkImovelTxtBox,
                NewPictureBox = ImovelPictureBox
            });
            dataControl = new DataControl();
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
            if (string.IsNullOrEmpty(NomeEstudo.Text))
            {
                MessageBox.Show("Por favor, insira um nome para a apresentação", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Apresentacao = new Presentation(
                CriacaoInfoLinesList,
                new Corretor()
                {
                    Name = CorretorTextBox.Text,
                    ImageLocation = CorretorPicBox.ImageLocation
                },
                NomeClienteTextBox.Text,
                NomeEstudo.Text);

            dataControl.SaveData(Apresentacao);
        }

        private void AddImovel_Click(object sender, EventArgs e)
        {
            IncrementoNumeroImoveis();
            Deslocamento = NumeroDeImoveis * 80;
            var size = new Size(100, 27);

            Label label = DinamicDesinger.CreateLabel($"imóvel {NumeroDeImoveis + 1}", ImovelLabel.Location.X, ImovelLabel.Location.Y + Deslocamento);
            TextBox MetragemTextBox = DinamicDesinger.CreateTextBox(MetragemTxtBox1.Location.X, MetragemTxtBox1.Location.Y + Deslocamento, size);
            TextBox ValorTextBox = DinamicDesinger.CreateTextBox(ValorTxtBox1.Location.X, ValorTxtBox1.Location.Y + Deslocamento, size);
            TextBox BanheirosTextBox = DinamicDesinger.CreateTextBox(BanheirosTxtBox.Location.X, BanheirosTxtBox.Location.Y + Deslocamento, size);
            TextBox GaragemTextBox = DinamicDesinger.CreateTextBox(GaragemTxtBox.Location.X, GaragemTxtBox.Location.Y + Deslocamento, size);
            TextBox DormitoriosTextBox = DinamicDesinger.CreateTextBox(DormTxtBox.Location.X, DormTxtBox.Location.Y + Deslocamento, size);
            TextBox LinkImovelTxt = DinamicDesinger.CreateTextBox(LinkImovelTxtBox.Location.X, LinkImovelTxtBox.Location.Y + Deslocamento, size);
            PictureBox NewPictureBox = DinamicDesinger.CreatePictureBox(ImovelPictureBox.Location.X, ImovelPictureBox.Location.Y + Deslocamento);
            NewPictureBox.Click += PictureBox_Click;

            CriacaoInfoLine NewInfo = new CriacaoInfoLine()
            {
                Label = label,
                ValorTxtBox = ValorTextBox,
                BanheirosTxtBox = BanheirosTextBox,
                GaragemTxtBox = GaragemTextBox,
                DormTxtBox = DormitoriosTextBox,
                Metragem = MetragemTextBox,
                LinkImovelTxtBox = LinkImovelTxt,
                NewPictureBox = NewPictureBox,
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
                SelectedPictureBox.ImageLocation = _OpenfileDialog.FileName;
            }
        }

        private void BtnRemover_Click(object sender, EventArgs e)
        {
            if (CriacaoInfoLinesList.Count <= 1)
            {
                return;
            }
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

            CriacaoInfoLinesList.Remove(ultimo);
        }

        private void CalcularBtn_Click(object sender, EventArgs e)
        {

            Apresentacao = new Presentation(CriacaoInfoLinesList,
                new Corretor()
                {
                    Name = CorretorTextBox.Text,
                    ImageLocation = CorretorPicBox.ImageLocation,
                },
                NomeClienteTextBox.Text,
                NomeEstudo.Text);


            Apresentacao.CalculateBasicAvaliation();

            Apresentacao.Otimista = new Avaliacao()
            {
                percentual = OtimistaNumUpDown.Value,
            };
            Apresentacao.Otimista.CalcularAvaliacao(Apresentacao.AvaliacaoBase);
            OtimistaTxtBox.Text = Apresentacao.Otimista.ValorAvaliacao.ToString();

            Apresentacao.Otimo = new Avaliacao()
            {
                percentual = OtimoNumUpDown.Value
            };
            Apresentacao.Otimo.CalcularAvaliacao(Apresentacao.AvaliacaoBase);
            OtimoTxtBox.Text = Apresentacao.Otimo.ValorAvaliacao.ToString();

            Apresentacao.Mercado = new Avaliacao()
            {
                percentual = MercadoNumUpDown.Value
            };
            Apresentacao.Mercado.CalcularAvaliacao(Apresentacao.AvaliacaoBase);
            MercadoTxtBox.Text = Apresentacao.Mercado.ValorAvaliacao.ToString();
        }

        private void CarregarBtn_Click(object sender, EventArgs e)
        {
            var apresentacao = dataControl.Carregar();
            if (apresentacao is not null)
            {
                PopulateForm(apresentacao);
            }
            else
            {
                MessageBox.Show("Arquivo vazio", "?", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void PopulateForm(Presentation apresentacao)
        {
            // Limpa os controles criados dinamicamente, preservando o item na posição 0
            ClearForm();

            CorretorTextBox.Text = apresentacao.Corretor.Name;
            NomeClienteTextBox.Text = apresentacao.Cliente;
            NomeEstudo.Text = apresentacao.Titulo;

            // Atualiza o item na posição 0 com os dados do primeiro imóvel
            if (CriacaoInfoLinesList.Count > 0 && apresentacao.Imoveis.Count > 0)
            {
                AtualizarItem(CriacaoInfoLinesList[0], apresentacao.Imoveis[0]);
            }

            for (int i = 1; i < apresentacao.Imoveis.Count; i++)
            {
                IncrementoNumeroImoveis();
                Deslocamento = NumeroDeImoveis * 80;
                var size = new Size(100, 27);

                Label label = DinamicDesinger.CreateLabel("imóvel " + NumeroDeImoveis, ImovelLabel.Location.X, ImovelLabel.Location.Y + Deslocamento);
                TextBox MetragemTextBox = DinamicDesinger.CreateTextBox(MetragemTxtBox1.Location.X, MetragemTxtBox1.Location.Y + Deslocamento, size);
                TextBox ValorTextBox = DinamicDesinger.CreateTextBox(ValorTxtBox1.Location.X, ValorTxtBox1.Location.Y + Deslocamento, size);
                TextBox BanheirosTextBox = DinamicDesinger.CreateTextBox(BanheirosTxtBox.Location.X, BanheirosTxtBox.Location.Y + Deslocamento, size);
                TextBox GaragemTextBox = DinamicDesinger.CreateTextBox(GaragemTxtBox.Location.X, GaragemTxtBox.Location.Y + Deslocamento, size);
                TextBox DormitoriosTextBox = DinamicDesinger.CreateTextBox(DormTxtBox.Location.X, DormTxtBox.Location.Y + Deslocamento, size);
                TextBox LinkImovelTxt = DinamicDesinger.CreateTextBox(LinkImovelTxtBox.Location.X, LinkImovelTxtBox.Location.Y + Deslocamento, size);
                PictureBox NewPictureBox = DinamicDesinger.CreatePictureBox(ImovelPictureBox.Location.X, ImovelPictureBox.Location.Y + Deslocamento);
                NewPictureBox.Click += PictureBox_Click;

                // Preenche os controles com os dados do imóvel
                MetragemTextBox.Text = apresentacao.Imoveis[i].Metragem.ToString();
                ValorTextBox.Text = apresentacao.Imoveis[i].Valor.ToString();
                BanheirosTextBox.Text = apresentacao.Imoveis[i].NumeroBanheiros.ToString();
                GaragemTextBox.Text = apresentacao.Imoveis[i].Garagem.ToString();
                DormitoriosTextBox.Text = apresentacao.Imoveis[i].NumeroDormitorios.ToString();
                LinkImovelTxt.Text = apresentacao.Imoveis[i].LinkImovel;
                NewPictureBox.ImageLocation = apresentacao.Imoveis[i].ImagemImovelPath;
                NewPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;


                CriacaoInfoLine newInfo = new CriacaoInfoLine()
                {
                    Label = label,
                    ValorTxtBox = ValorTextBox,
                    BanheirosTxtBox = BanheirosTextBox,
                    GaragemTxtBox = GaragemTextBox,
                    DormTxtBox = DormitoriosTextBox,
                    Metragem = MetragemTextBox,
                    LinkImovelTxtBox = LinkImovelTxt,
                    NewPictureBox = NewPictureBox,
                };

                CriacaoInfoLinesList.Add(newInfo);

                Controls.Add(label);
                Controls.Add(MetragemTextBox);
                Controls.Add(ValorTextBox);
                Controls.Add(BanheirosTextBox);
                Controls.Add(GaragemTextBox);
                Controls.Add(DormitoriosTextBox);
                Controls.Add(LinkImovelTxt);
                Controls.Add(NewPictureBox);
            }
            CorretorPicBox.ImageLocation = apresentacao.Corretor.ImageLocation;
            CorretorPicBox.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void AtualizarItem(CriacaoInfoLine item, Imovel imovel)
        {
            item.Metragem.Text = imovel.Metragem.ToString();
            item.ValorTxtBox.Text = imovel.Valor.ToString();
            item.BanheirosTxtBox.Text = imovel.NumeroBanheiros.ToString();
            item.GaragemTxtBox.Text = imovel.Garagem.ToString();
            item.DormTxtBox.Text = imovel.NumeroDormitorios.ToString();
            item.LinkImovelTxtBox.Text = imovel.LinkImovel;
            item.NewPictureBox.ImageLocation = imovel.ImagemImovelPath;
            item.NewPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void ClearForm()
        {
            // Remove todos os controles criados dinamicamente, preservando o item na posição 0
            for (int i = CriacaoInfoLinesList.Count - 1; i > 0; i--)
            {
                Controls.Remove(CriacaoInfoLinesList[i].Label);
                Controls.Remove(CriacaoInfoLinesList[i].Metragem);
                Controls.Remove(CriacaoInfoLinesList[i].ValorTxtBox);
                Controls.Remove(CriacaoInfoLinesList[i].BanheirosTxtBox);
                Controls.Remove(CriacaoInfoLinesList[i].GaragemTxtBox);
                Controls.Remove(CriacaoInfoLinesList[i].DormTxtBox);
                Controls.Remove(CriacaoInfoLinesList[i].LinkImovelTxtBox);
                Controls.Remove(CriacaoInfoLinesList[i].NewPictureBox);
                CriacaoInfoLinesList.RemoveAt(i);
            }
            NumeroDeImoveis = 0;
            Deslocamento = 0;
        }

        private void OtimoNumUpDown_ValueChanged(object sender, EventArgs e)
        {
            CalcularBtn_Click(sender, e);
        }

        private void MercadoNumUpDown_ValueChanged(object sender, EventArgs e)
        {
            CalcularBtn_Click(sender, e);
        }

        private void OtimistaNumUpDown_ValueChanged(object sender, EventArgs e)
        {
            CalcularBtn_Click(sender, e);
        }
    }
}