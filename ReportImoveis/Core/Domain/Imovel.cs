namespace ReportImoveis.Core.Domain
{
    public class Imovel
    {
        public Decimal Valor { get; set; }
        public String Nome { get; set; }
        public String Localizacao { get; init; }
        public String ToText()
        {
            return Nome + " " + Localizacao + " " + Valor.ToString();
        }
    }
}