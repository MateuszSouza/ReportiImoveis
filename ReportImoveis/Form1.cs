using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Windows.Forms;
using System.Drawing;
using Newtonsoft.Json;
using ReportImoveis.Core.Domain;

namespace ReportImoveis
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void BtnNew(object sender, EventArgs e)
        {
            Criacao criacao = new Criacao();
            criacao.ShowDialog();

        }

        private void BtnMudar(object sender, EventArgs e)
        {
            var point = this.Location.ToString();
            label1.Text = "OK";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Label label = new Label();
            Point point = new Point(200, 200);
            //Font font = new Font("Consolas", 18);

            label.Text = "Botão criado dinamicamente";
            label.Location = point;
            //label.Font = font;
            label.AutoSize = true;


            Controls.Add(label);
        }

        private void button4SavarTest_Click(object sender, EventArgs e)
        {


            using (var FolderBrowserDialog = new FolderBrowserDialog())
            {
                DialogResult result = FolderBrowserDialog.ShowDialog();

                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(FolderBrowserDialog.SelectedPath))
                {
                    var DirectoryPath = Path.Combine(FolderBrowserDialog.SelectedPath, NomeArquivo.Text);

                    Directory.CreateDirectory(DirectoryPath);

                    var finalPath = Path.Combine(DirectoryPath, NomeArquivo.Text + ".txt");
                    var ImagePath = Path.Combine(DirectoryPath, NomeArquivo.Text + ".jpg");
                    MessageBox.Show("CompletePAth: " + finalPath);
                    var dadosTest = new teste()
                    {
                        dados = ConteudoTxtBox.Text,
                        imagemPath = pictureBoxTeste.ImageLocation,
                    };
                    var dados = JsonConvert.SerializeObject(dadosTest);
                    File.WriteAllText(finalPath, dados);
                    File.WriteAllBytes(ImagePath, pictureBoxTeste.Image);

                }
            }
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

        private class teste()
        {
            public string dados { get; set; }
            public string imagemPath { get; set; }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Title = "Open";

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string data = File.ReadAllText(openFileDialog1.FileName);
                var datas = JsonConvert.DeserializeObject<teste>(data);
                
            }
        }
    }
}
