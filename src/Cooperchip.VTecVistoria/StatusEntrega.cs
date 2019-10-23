using System.ComponentModel;

namespace Cooperchip.VTecVistoria.ConsoleApps
{
    public enum StatusEntrega
    {
        [Description("Processando na Expedição")] Expedicao = 1,
        [Description("Pronto para Entrega")] ProntoEntrega,
        [Description("Em Trânsito")] EmTransito,
        [Description("Entregue")] Entregue,
        [Description("Aguardando Retirada")] AguardandoCliente,
        [Description("Retornando à Origem")] Retornando,
        [Description("Entrega Estraviada")] Extravido
    }
}