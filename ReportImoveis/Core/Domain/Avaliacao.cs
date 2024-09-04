namespace ReportImoveis.Core.Domain
{
    public class Avaliacao
    {
        public float ValorAvaliacao { get; private set; }
        public float percentual { set; get; }
        public bool Mostrar {  get; set; }
        public Avaliacao()
        {
            
        }
        public void CalcularAvaliacao(float valorBase)
        {
            var PercentualEmPorcentagem = percentual / 100;
            var parte = valorBase * PercentualEmPorcentagem;
            ValorAvaliacao = parte + valorBase;
        }
    }
}