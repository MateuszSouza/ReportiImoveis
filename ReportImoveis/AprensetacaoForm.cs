using ReportImoveis.Core.Domain;

namespace ReportImoveis
{
    public partial class ApresentacaoForm : Form
    {
        private readonly Presentation presentation;

        public ApresentacaoForm(Presentation _presentation)
        {
            InitializeComponent();
            presentation = _presentation;
            Populate(presentation);

        }

        private void Populate(Presentation presentation)
        {
            CorretorPiture.ImageLocation = presentation.Corretor.ImageLocation;
            CorretorPiture.SizeMode = PictureBoxSizeMode.StretchImage;
            CorretorPiture.BorderStyle = BorderStyle.Fixed3D;
            NomeCorretor.Text = "Corretor: " + presentation.Corretor.Name;

        }
    }
}