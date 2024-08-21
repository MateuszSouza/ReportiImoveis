using ReportImoveis.Core.DinamicDesigner;

namespace ReportImoveis.Core.Domain
{
    public class Presentation
    {
         
        public List<Imovel> Imoveis = new List<Imovel>();
        public string Titulo { get; set; }
        public string Cliente { get; set; }
        public Corretor Corretor { get; set; }
        public Avaliacao ?Otimista { get; set; }
        public Avaliacao ?Mercado { get; set; }
        public Avaliacao ?Otimo { get; set; }
        public decimal AvaliacaoBase { get; set; }
        public Presentation()
        {
            
        }
        public Presentation(List<CriacaoInfoLine> LinesList, Corretor _Corretor, string _Cliente, string _Titulo) 
        {
            foreach (var item in LinesList)
            {
                Imoveis.Add(new Imovel()
                {
                    Metragem = int.TryParse(item.Metragem.Text, out var metragem) ? metragem : 0,
                    Valor = decimal.TryParse(item.ValorTxtBox.Text, out var valor) ? valor : 0,
                    NumeroBanheiros = int.TryParse(item.BanheirosTxtBox.Text, out var numBathromm) ? numBathromm : 0,
                    Garagem = int.TryParse(item.GaragemTxtBox.Text, out var garagem) ? garagem : 0,
                    NumeroDormitorios = int.TryParse(item.DormTxtBox.Text, out var numDorm) ? numDorm : 0,
                    LinkImovel = !string.IsNullOrEmpty(item.LinkImovelTxtBox.Text) ? item.LinkImovelTxtBox.Text : "",
                    ImagemImovelPath = item.NewPictureBox.ImageLocation
                });
            }

                Corretor = _Corretor;
                Cliente = _Cliente;
                Titulo = _Titulo;

            CalculateBasicAvaliation();
        }

        public void CalculateBasicAvaliation()
        {
            decimal valor = 0;

            foreach (var item in Imoveis)
            {
                valor = valor + item.Valor;
            }

            AvaliacaoBase = valor / Imoveis.Count;
        }
    }
    }