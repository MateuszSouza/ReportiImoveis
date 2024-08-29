namespace ReportImoveis.Core.Domain
{
    public class Avaliacao
    {
        public decimal ValorAvaliacao { get; private set; }
        public decimal percentual { set; get; }
        public bool Mostrar {  get; set; }

        public void CalcularAvaliacao(decimal valorBase)
        {
            var PercentualEmPorcentagem = percentual / 100;
            var parte = valorBase * PercentualEmPorcentagem;
            ValorAvaliacao = parte + valorBase;
        }
    }
}