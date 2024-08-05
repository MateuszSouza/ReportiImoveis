namespace ReportImoveis.Core.Domain
{
    public class Presentation
    {
        public Presentation()
        {
            
        }
        public Presentation(
            List<Imovel> imovel, 
            string titulo, 
            string cliente, 
            string corretor, 
            Avaliacao avaliacao1, 
            Avaliacao avaliacao2, 
            Avaliacao avaliacao3)
        {
            Imoveis = imovel;
            Titulo = titulo;
            Cliente = cliente;
            Corretor = corretor;
            this.avaliacao1 = avaliacao1;
            this.avaliacao2 = avaliacao2;
            this.avaliacao3 = avaliacao3;
        }

        public List<Imovel> Imoveis { get; set; }
        public string Titulo { get; set; }
        public string Cliente { get; set; }
        public string Corretor { get; set; }
        public Avaliacao avaliacao1 { get; set; }
        public Avaliacao avaliacao2 { get; set; }
        public Avaliacao avaliacao3 { get; set; }
        public decimal basicAvaliation { get; set; }

        public void CalculateBasicAvaliation()
        {
            decimal valor = 0;

            foreach (var item in Imoveis)
            {
                valor = valor + item.Valor;
            }

            basicAvaliation = valor / Imoveis.Count;
        }
    }

    public class Avaliacao()
    {
        public decimal avaliacao { get; set; }
        public int percentual { set; get; }
    }
}