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
    }   
}