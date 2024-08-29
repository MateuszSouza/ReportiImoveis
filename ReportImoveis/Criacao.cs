using Microsoft.VisualBasic;
using Newtonsoft.Json;
using ReportImoveis.Core.DinamicDesigner;
using ReportImoveis.Core.Domain;
using ReportImoveis.Repository;
using System.Security.Cryptography.Xml;
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
        private Size size = new Size(100, 27);


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

        private int IncrementoNumeroImoveis()
        {
            NumeroDeImoveis++;
            return NumeroDeImoveis * 80;
        }

        private void SalvarDados_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(NomeEstudo.Text))
            {
                MessageBox.Show("Por favor, insira um nome para a apresentação", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            CriarApresentacao();

            dataControl.SaveData(Apresentacao);
        }

        private void AddImovel_Click(object sender, EventArgs e)
        {
            Deslocamento = IncrementoNumeroImoveis();

            CriacaoInfoLine newInfo = DinamicDesinger.CreateConjuntoInfoLine(NumeroDeImoveis,Deslocamento, size,
            ImovelLabel,
            MetragemTxtBox1,
            ValorTxtBox1,
            BanheirosTxtBox,
            GaragemTxtBox,
            DormTxtBox,
            LinkImovelTxtBox,
            ImovelPictureBox,
            PictureBox_Click);

            CriacaoInfoLinesList.Add(newInfo);

            Controls.Add(newInfo.Label);
            Controls.Add(newInfo.Metragem);
            Controls.Add(newInfo.ValorTxtBox);
            Controls.Add(newInfo.BanheirosTxtBox);
            Controls.Add(newInfo.GaragemTxtBox);
            Controls.Add(newInfo.DormTxtBox);
            Controls.Add(newInfo.LinkImovelTxtBox);
            Controls.Add(newInfo.NewPictureBox);
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
                MessageBox.Show("Não pode remover o imóvel um.", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            var Number = Interaction.InputBox("Escolha pelo numero qual imovel deseja retirar", "Remoção", "2", -1, -1);
            if (int.TryParse(Number, out int NumeroSelecionado) && NumeroSelecionado < CriacaoInfoLinesList.Count)
            {
                if (NumeroSelecionado == 1)
                {
                    RemoverPrimeiro();
                }
                else
                {
                    RemoverOutros(NumeroSelecionado);
                }
            }
            else
            {
                MessageBox.Show("Numero de imóvel selecionado inávido", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void RemoverPrimeiro()
        {
            var second = CriacaoInfoLinesList[1];
            RemoverItem(second);
            CriacaoInfoLinesList.Remove(second); ;
            CriacaoInfoLinesList.First().Metragem.Text = second.Metragem.Text;
            CriacaoInfoLinesList.First().ValorTxtBox.Text = second.ValorTxtBox.Text;
            CriacaoInfoLinesList.First().BanheirosTxtBox.Text = second.BanheirosTxtBox.Text;
            CriacaoInfoLinesList.First().GaragemTxtBox.Text = second.GaragemTxtBox.Text;
            CriacaoInfoLinesList.First().DormTxtBox.Text = second.DormTxtBox.Text;
            CriacaoInfoLinesList.First().LinkImovelTxtBox.Text = second.LinkImovelTxtBox.Text;
            CriacaoInfoLinesList.First().NewPictureBox.ImageLocation = second.NewPictureBox.ImageLocation;
            CriacaoInfoLinesList.First().NewPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;

            CriarApresentacao();

            PopulateForm(Apresentacao);
        }
        private void CriarApresentacao()
        {
            Apresentacao = new Presentation(
                CriacaoInfoLinesList,
                new Corretor()
                {
                    Name = CorretorTextBox.Text,
                    ImageLocation = CorretorPicBox.ImageLocation
                },
                NomeClienteTextBox.Text,
                NomeEstudo.Text);
        }
        private void RemoverOutros(int selecionado)
        {
            var linhaSelecionada = CriacaoInfoLinesList[selecionado - 1];
            CriacaoInfoLinesList.Remove(linhaSelecionada);
            RemoverItem(linhaSelecionada);
            CriarApresentacao();
            PopulateForm(Apresentacao);
        }

        private void RemoverItem(CriacaoInfoLine item)
        {
            Controls.Remove(item.Label);
            Controls.Remove(item.Metragem);
            Controls.Remove(item.ValorTxtBox);
            Controls.Remove(item.BanheirosTxtBox);
            Controls.Remove(item.GaragemTxtBox);
            Controls.Remove(item.DormTxtBox);
            Controls.Remove(item.LinkImovelTxtBox);
            Controls.Remove(item.NewPictureBox);
        }

        private void CalcularBtn_Click(object sender, EventArgs e)
        {
            CriarApresentacao();

            Apresentacao.CalculateBasicAvaliation();

            Apresentacao.Otimista = new Avaliacao()
            {
                percentual = OtimistaNumUpDown.Value,
                Mostrar = checkBoxOtimista.Checked,
            };
            Apresentacao.Otimista.CalcularAvaliacao(Apresentacao.AvaliacaoBase);
            OtimistaTxtBox.Text = Apresentacao.Otimista.ValorAvaliacao.ToString();

            Apresentacao.Otimo = new Avaliacao()
            {
                percentual = OtimoNumUpDown.Value,
                Mostrar=checkBoxOtimo.Checked,
            };
            Apresentacao.Otimo.CalcularAvaliacao(Apresentacao.AvaliacaoBase);
            OtimoTxtBox.Text = Apresentacao.Otimo.ValorAvaliacao.ToString();

            Apresentacao.Mercado = new Avaliacao()
            {
                percentual = MercadoNumUpDown.Value,
                Mostrar = checkBoxMercado.Checked
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
                Deslocamento = IncrementoNumeroImoveis();

                CriacaoInfoLine newInfo = DinamicDesinger.CreateConjuntoInfoLine(NumeroDeImoveis, Deslocamento, size,
                ImovelLabel,
                MetragemTxtBox1,
                ValorTxtBox1,
                BanheirosTxtBox,
                GaragemTxtBox,
                DormTxtBox,
                LinkImovelTxtBox,
                ImovelPictureBox,
                PictureBox_Click);

                // Preenche os controles com os dados do imóvel
                newInfo.Metragem.Text = apresentacao.Imoveis[i].Metragem.ToString();
                newInfo.ValorTxtBox.Text = apresentacao.Imoveis[i].Valor.ToString();
                newInfo.BanheirosTxtBox.Text = apresentacao.Imoveis[i].NumeroBanheiros.ToString();
                newInfo.GaragemTxtBox.Text = apresentacao.Imoveis[i].Garagem.ToString();
                newInfo.DormTxtBox.Text = apresentacao.Imoveis[i].NumeroDormitorios.ToString();
                newInfo.LinkImovelTxtBox.Text = apresentacao.Imoveis[i].LinkImovel;
                newInfo.NewPictureBox.ImageLocation = apresentacao.Imoveis[i].ImagemImovelPath;
                newInfo.NewPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
                CriacaoInfoLinesList.Add(newInfo);

                Controls.Add(newInfo.Label);
                Controls.Add(newInfo.Metragem);
                Controls.Add(newInfo.ValorTxtBox);
                Controls.Add(newInfo.BanheirosTxtBox);
                Controls.Add(newInfo.GaragemTxtBox);
                Controls.Add(newInfo.DormTxtBox);
                Controls.Add(newInfo.LinkImovelTxtBox);
                Controls.Add(newInfo.NewPictureBox);
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
                RemoverItem(CriacaoInfoLinesList[i]);
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