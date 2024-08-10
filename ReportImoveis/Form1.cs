using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Windows.Forms;
using System.Drawing;
using Newtonsoft.Json;
using ReportImoveis.Core.Domain;
using ReportImoveis.Core.DinamicDesigner;

namespace ReportImoveis
{
    public partial class Form1 : Form
    {
        private CriacaoInfoLine CriacaoInfoLine = new CriacaoInfoLine();
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


            using (var folderBrowserDialog = new FolderBrowserDialog())
            {
                //folderBrowserDialog.fil
                DialogResult result = folderBrowserDialog.ShowDialog();

                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(folderBrowserDialog.SelectedPath))
                {
                    var DirectoryPath = Path.Combine(folderBrowserDialog.SelectedPath, NomeArquivo.Text);

                    Directory.CreateDirectory(DirectoryPath);

                    var finalPath  = Path.Combine(DirectoryPath, NomeArquivo.Text + ".txt");
                    var ImageName  = Path.GetFileNameWithoutExtension(CriacaoInfoLine.NewPictureBox.ImageLocation);
                    var ImagemPath = Path.Combine(DirectoryPath, ImageName + ".jpg");

                    MessageBox.Show("CompletePAth: " + ImagemPath);

                    var dadosTest = new teste()
                    {
                        dados = ConteudoTxtBox.Text,
                        imagemPath = ImagemPath,
                    };

                    var dados = JsonConvert.SerializeObject(dadosTest);
                    pictureBoxTeste.Image.Save(ImagemPath);
                 
                    File.WriteAllText(finalPath, dados);


                }
            }
        }

        private void PictureBox_Click(object sender, EventArgs e)
        {
            OpenFileDialog _OpenfileDialog = new OpenFileDialog();
            _OpenfileDialog.Filter = "Images (*.BMP;*.JPG;*.GIF,*.PNG,*.TIFF)|*.BMP;*.JPG;*.GIF;*.PNG;*.TIFF";
            if (_OpenfileDialog.ShowDialog() == DialogResult.OK)
            {
                Image imageForPictureBox = Image.FromFile(_OpenfileDialog.FileName);
                
                pictureBoxTeste.SizeMode = PictureBoxSizeMode.StretchImage;
                pictureBoxTeste.ImageLocation = _OpenfileDialog.FileName;
            }
            CriacaoInfoLine.NewPictureBox = pictureBoxTeste;
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
                pictureBoxTeste.ImageLocation = datas.imagemPath;
                pictureBoxTeste.Image = Image.FromFile(datas.imagemPath);
                pictureBoxTeste.SizeMode = PictureBoxSizeMode.StretchImage;
                NomeArquivo.Text = openFileDialog1.FileName;
                ConteudoTxtBox.Text = datas.dados;
            }
        }
    }
}
