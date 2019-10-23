using System;
using Cooperchip.VTecVistoria.DomainCore.Base;
using Cooperchip.VTecVistoria.DomainCore.Extensions;
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
                NomeCliente = "Alberto de Souza",
                Data = DateTime.Now.ToBrazilianDateTime(),
                StatusEntrega = StatusEntrega.Expedicao.GetDescription(),
                StatusPagamento = StatusPagamento.Aprovado.GetDescription(),
                DataCadastro = DateTime.Now.ToLocalTime(),
                DimensaoEntrega = new Dimensao(3,4,2)
            };

            Console.Out.WriteLine(pedido);
            Console.Out.WriteLine(pedido.NomeCliente);
            Console.Out.WriteLine(pedido.Data);
            Console.Out.WriteLine(pedido.StatusPagamento);
            Console.Out.WriteLine(pedido.StatusEntrega);
            Console.Out.WriteLine(pedido.DimensaoEntrega);
            Console.Out.WriteLine(pedido.DataCadastro);
            Console.ReadKey();
        }

        class Pedido : EntityBase
        {
            public string NomeCliente { get; set; }
            public string Data { get; set; }
            public string StatusEntrega { get; set; }
            public string StatusPagamento { get; set; }
            public Dimensao DimensaoEntrega { get; set; }
        }
    }
}
