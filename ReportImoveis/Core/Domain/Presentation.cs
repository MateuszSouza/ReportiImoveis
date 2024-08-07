namespace ReportImoveis.Core.Domain
{
    public class Presentation
    {
         
        public List<Imovel> Imoveis { get; set; }
        public string Titulo { get; set; }
        public string Cliente { get; set; }
        public string Corretor { get; set; }
        public Avaliacao Otimista { get; set; }
        public Avaliacao Mercado { get; set; }
        public Avaliacao Otimo { get; set; }
        public decimal AvaliacaoBase { get; set; }

        public Presentation(){}

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

    public class Avaliacao()
    {
        public decimal ValorAvaliacao { get; private set; }
        public decimal percentual { set; get; }

        public void CalcularAvaliacao(decimal valorBase)
        {
            var PercentualEmPorcentagem = percentual / 100;
            var parte = valorBase * PercentualEmPorcentagem;
            ValorAvaliacao = parte + valorBase;
            
        }
    }
}