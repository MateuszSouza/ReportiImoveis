namespace ReportImoveis.Core.Domain
{
    public class Imovel
    {
        public decimal Valor { get; set; }
        public int Metragem { get; set; }
        public int NumeroBanheiros { get; set; }
        public int Garagem { get; set; }
        public int NumeroDormitorios { get; set; }
        public string LinkImovel { get; set;}
        public Image ImagemImovel { get; set; }
    }
}