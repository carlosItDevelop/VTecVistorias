using System;
using Cooperchip.VTecVistoria.DomainCore.Base;
using Cooperchip.VTecVistoria.DomainCore.ValueObjects;
using Microsoft.VisualBasic;

namespace Cooperchip.VTecVistoria.ConsoleApps
{
    class Program
    {
        static void Main(string[] args)
        {
            var pedido = new Pedido
            {
                
            };
        }

        class Pedido : EntityBase
        {
            public string NomeCliente { get; set; }
            public DateAndTime Data { get; set; }
            public StatusEntrega StatusEntrega { get; set; }
            public StatusPagamento StatusPagamento { get; set; }
            public Dimensao DimensaoEntrega { get; set; }
        }
    }
}
