﻿

using Newtonsoft.Json;
using ReportImoveis.Core.DinamicDesigner;
using ReportImoveis.Core.Domain;
using System.Windows.Forms;

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
                LinkImovelTxtBox = LinkImovelTxtBox,
                NewPictureBox = ImovelPictureBox
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
            if (Apresentacao is null)
            {
                Apresentacao = CriarApresentacaoData();
            }

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
                    Metragem = !int.TryParse(item.Metragem.Text, out var metragem) ? metragem : 0,
                    Valor = !decimal.TryParse(item.ValorTxtBox.Text, out var valor) ? valor : 0,
                    NumeroBanheiros = !int.TryParse(item.BanheirosTxtBox.Text, out var numBathromm) ? numBathromm : 0,
                    Garagem = !int.TryParse(item.GaragemTxtBox.Text, out var garagem) ? garagem : 0,
                    NumeroDormitorios = !int.TryParse(item.DormTxtBox.Text, out var numDorm) ? numDorm : 0,
                    LinkImovel = !string.IsNullOrEmpty(item.LinkImovelTxtBox.Text) ? item.LinkImovelTxtBox.Text : "",
                    ImagemImovelPath = item.NewPictureBox.ImageLocation
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

        private void SaveData(string data)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Title = "Save";
            saveFileDialog.Filter = "";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                File.WriteAllText(saveFileDialog.FileName, data);
            }
        }

        private void AddImovel_Click(object sender, EventArgs e)
        {
            IncrementoNumeroImoveis();
            Deslocamento = NumeroDeImoveis * 80;
            var size = new Size(100, 27);

            Label label = CreateLabel("imóvel " + NumeroDeImoveis, ImovelLabel.Location.X, ImovelLabel.Location.Y + Deslocamento);
            TextBox MetragemTextBox = CreateTextBox(MetragemTxtBox1.Location.X, MetragemTxtBox1.Location.Y + Deslocamento, size);
            TextBox ValorTextBox = CreateTextBox(ValorTxtBox1.Location.X, ValorTxtBox1.Location.Y + Deslocamento, size);
            TextBox BanheirosTextBox = CreateTextBox(BanheirosTxtBox.Location.X, BanheirosTxtBox.Location.Y + Deslocamento, size);
            TextBox GaragemTextBox = CreateTextBox(GaragemTxtBox.Location.X, GaragemTxtBox.Location.Y + Deslocamento, size);
            TextBox DormitoriosTextBox = CreateTextBox(DormTxtBox.Location.X, DormTxtBox.Location.Y + Deslocamento, size);
            TextBox LinkImovelTxt = CreateTextBox(LinkImovelTxtBox.Location.X, LinkImovelTxtBox.Location.Y + Deslocamento, size);
            PictureBox NewPictureBox = CreatePictureBox(ImovelPictureBox.Location.X, ImovelPictureBox.Location.Y + Deslocamento);

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

        private Label CreateLabel(string text, int x, int y)
        {
            Label label = new Label();
            label.Location = new Point(x, y);
            label.AutoSize = true;
            label.Text = text;
            return label;
        }

        private TextBox CreateTextBox(int x, int y, Size size)
        {
            TextBox textBox = new TextBox();
            textBox.Location = new Point(x, y);
            textBox.Size = size;
            return textBox;
        }

        private PictureBox CreatePictureBox(int x, int y)
        {
            PictureBox pictureBox = new PictureBox();
            pictureBox.Location = new Point(x, y);
            pictureBox.Size = new Size(75, 75);
            pictureBox.BackColor = Color.White;
            pictureBox.Click += PictureBox_Click;
            return pictureBox;
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
            if (Apresentacao is null)
            {
                Apresentacao = CriarApresentacaoData();
            }

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
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Title = "Open";

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string data = File.ReadAllText(openFileDialog1.FileName);
                Apresentacao = JsonConvert.DeserializeObject<Presentation>(data);
                PopulateForm(Apresentacao);
            }
        }

        private void PopulateForm(Presentation apresentacao)
        {
            // Limpa os controles criados dinamicamente, preservando o item na posição 0
            ClearForm();

            CorretorTextBox.Text = apresentacao.Corretor;
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

                Label label = CreateLabel("imóvel " + NumeroDeImoveis, ImovelLabel.Location.X, ImovelLabel.Location.Y + Deslocamento);
                TextBox MetragemTextBox = CreateTextBox(MetragemTxtBox1.Location.X, MetragemTxtBox1.Location.Y + Deslocamento, size);
                TextBox ValorTextBox = CreateTextBox(ValorTxtBox1.Location.X, ValorTxtBox1.Location.Y + Deslocamento, size);
                TextBox BanheirosTextBox = CreateTextBox(BanheirosTxtBox.Location.X, BanheirosTxtBox.Location.Y + Deslocamento, size);
                TextBox GaragemTextBox = CreateTextBox(GaragemTxtBox.Location.X, GaragemTxtBox.Location.Y + Deslocamento, size);
                TextBox DormitoriosTextBox = CreateTextBox(DormTxtBox.Location.X, DormTxtBox.Location.Y + Deslocamento, size);
                TextBox LinkImovelTxt = CreateTextBox(LinkImovelTxtBox.Location.X, LinkImovelTxtBox.Location.Y + Deslocamento, size);
                PictureBox NewPictureBox = CreatePictureBox(ImovelPictureBox.Location.X, ImovelPictureBox.Location.Y + Deslocamento);

                // Preenche os controles com os dados do imóvel
                MetragemTextBox.Text = apresentacao.Imoveis[i].Metragem.ToString();
                ValorTextBox.Text = apresentacao.Imoveis[i].Valor.ToString();
                BanheirosTextBox.Text = apresentacao.Imoveis[i].NumeroBanheiros.ToString();
                GaragemTextBox.Text = apresentacao.Imoveis[i].Garagem.ToString();
                DormitoriosTextBox.Text = apresentacao.Imoveis[i].NumeroDormitorios.ToString();
                LinkImovelTxt.Text = apresentacao.Imoveis[i].LinkImovel;
                NewPictureBox.ImageLocation = apresentacao.Imoveis[i].ImagemImovelPath;

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
            ListaDeImoveis.Clear();
            NumeroDeImoveis = 0;
            Deslocamento = 0;
        }
    }
}