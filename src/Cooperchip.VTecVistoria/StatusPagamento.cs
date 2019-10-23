using System.ComponentModel;

namespace Cooperchip.VTecVistoria.ConsoleApps
{
    public enum StatusPagamento
    {
        [Description("Em Análise")] EmAnalise = 1,
        [Description("Aprovado")] Aprovado,
        [Description("Recusado")] Recusado,
        [Description("Cancelado pelo Cliente")] CanceladoCliente,
        [Description("Cancelado pela Operadora")] CanceladoOperadora,
        [Description("Cancelado pela Loja")] CanceladoLoja,
        [Description("Estornado")] Estornado
    }
}