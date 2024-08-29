using ReportImoveis.Core.DinamicDesigner;
using Microsoft.VisualBasic;

namespace ReportImoveis
{
    public partial class ReportImoveisFront : Form
    {
        private CriacaoInfoLine CriacaoInfoLine = new CriacaoInfoLine();

        public ReportImoveisFront()
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

        private void Apresentar_OnClick(object sender, EventArgs e)
        {
            AprensetacaoForm aprensetacaoForm = new AprensetacaoForm();
            aprensetacaoForm.WindowState = FormWindowState.Maximized;
            aprensetacaoForm.ShowDialog();
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

        private void button1_Click(object sender, EventArgs e)
        {
            var Password = Interaction.InputBox("Message", "Title", "information in textbox", -1, -1);
            MessageBox.Show("meu teste " + Password, "?", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }
    }
}