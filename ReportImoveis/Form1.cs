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

            label.Text = "Bot�o criado dinamicamente";
            label.Location = point;
            //label.Font = font;
            label.AutoSize = true;


            this.Controls.Add(label);
        }
    }
}
