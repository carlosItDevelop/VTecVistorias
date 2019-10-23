namespace Cooperchip.VTecVistoria.DomainCore.ValueObjects
{
    public class Dimensao
    {
        public Dimensao(decimal altura, decimal largura, decimal profundidade)
        {
            Altura = altura;
            Largura = largura;
            Profundidade = profundidade;
        }
        public decimal Altura { get; private set; }
        public decimal Largura { get; private set; }
        public decimal Profundidade { get; private set; }

        // Para o EF
        protected Dimensao() { }

        public string ToStrFormating()
        {
            return $"LxAxP: {Largura} x {Altura} x {Profundidade}";
        }

        public override string ToString()
        {
            return ToStrFormating();
        }

        public decimal Volume()
        {
            return Largura * Altura * Profundidade;
        }

        public decimal Area()
        {
            return Largura * Profundidade;
        }
    }
}