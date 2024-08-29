using System.Drawing;

namespace ReportImoveis.Core.DinamicDesigner
{
    public class DinamicDesinger
    {
        public Label CreateLabel(string text, int x, int y)
        {
            Label label = new Label();
            label.Location = new Point(x, y);
            label.AutoSize = true;
            label.Text = text;
            return label;
        }


        public TextBox CreateTextBox(int x, int y, Size size)
        {
            TextBox textBox = new TextBox();
            textBox.Location = new Point(x, y);
            textBox.Size = size;
            return textBox;
        }
        public PictureBox CreatePictureBox(int x, int y)
        {
            PictureBox pictureBox = new PictureBox();
            pictureBox.Location = new Point(x, y);
            pictureBox.Size = new Size(75, 75);
            pictureBox.BackColor = Color.White;
            return pictureBox;
        }
        public CriacaoInfoLine CreateConjuntoInfoLine(int NumeroDeImoveis, int Deslocamento,Size size,
            Label ImovelLabel,
            TextBox MetragemTxtBox1,
            TextBox ValorTxtBox1,
            TextBox BanheirosTxtBox,
            TextBox GaragemTxtBox,
            TextBox DormTxtBox,
            TextBox LinkImovelTxtBox,
            PictureBox ImovelPictureBox,
            EventHandler? func)
        {
            Label label = CreateLabel($"imóvel {NumeroDeImoveis + 1}", ImovelLabel.Location.X, ImovelLabel.Location.Y + Deslocamento);
            TextBox MetragemTextBox = CreateTextBox(MetragemTxtBox1.Location.X, MetragemTxtBox1.Location.Y + Deslocamento, size);
            TextBox ValorTextBox = CreateTextBox(ValorTxtBox1.Location.X, ValorTxtBox1.Location.Y + Deslocamento, size);
            TextBox BanheirosTextBox = CreateTextBox(BanheirosTxtBox.Location.X, BanheirosTxtBox.Location.Y + Deslocamento, size);
            TextBox GaragemTextBox = CreateTextBox(GaragemTxtBox.Location.X, GaragemTxtBox.Location.Y + Deslocamento, size);
            TextBox DormitoriosTextBox = CreateTextBox(DormTxtBox.Location.X, DormTxtBox.Location.Y + Deslocamento, size);
            TextBox LinkImovelTxt = CreateTextBox(LinkImovelTxtBox.Location.X, LinkImovelTxtBox.Location.Y + Deslocamento, size);
            PictureBox NewPictureBox = CreatePictureBox(ImovelPictureBox.Location.X, ImovelPictureBox.Location.Y + Deslocamento);
            NewPictureBox.Click += func;

            return new CriacaoInfoLine()
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
        }    
    }   
}