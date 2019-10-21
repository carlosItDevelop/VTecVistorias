namespace Cooperchip.VTecVistoria.DomainCore.ValueObjects
{
    public class Dimensao
    {
        public Dimensao(double altura, double largura, double comprimento)
        {
            Altura = altura;
            Largura = largura;
            Comprimento = comprimento;
        }
        public double Altura { get; private set; }
        public double Largura { get; private set; }
        public double Comprimento { get; private set; }

        // Para o EF
        protected Dimensao() { }
    }
}