using ReportImoveis.Core.DinamicDesigner;
using Microsoft.VisualBasic;
using ReportImoveis.Repository;

namespace ReportImoveis
{
    public partial class ReportImoveisFront : Form
    {
        private CriacaoInfoLine CriacaoInfoLine = new CriacaoInfoLine();
        private IDataControl DataControl;
        public ReportImoveisFront(IDataControl _dataControl)
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            DataControl = _dataControl;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void BtnNew(object sender, EventArgs e)
        {
            Criacao criacao = new Criacao(DataControl);
            criacao.ShowDialog();
        }

        private void Apresentar_OnClick(object sender, EventArgs e)
        {
            var apresentacao = DataControl.Carregar();
            if (apresentacao is not null)
            {
                ApresentacaoForm aprensetacaoForm = new ApresentacaoForm(apresentacao);
                aprensetacaoForm.WindowState = FormWindowState.Maximized;
                aprensetacaoForm.ShowDialog();
            }
            else
            {
                MessageBox.Show("Arquivo vazio", "?", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}