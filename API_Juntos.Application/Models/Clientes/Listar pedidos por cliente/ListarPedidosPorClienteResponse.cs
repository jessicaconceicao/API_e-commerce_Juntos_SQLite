using API_Juntos.Application.Models.Pedidos.ListarPedidoPorId;
using System;
using System.Collections.Generic;

namespace API_Juntos.Application.Models.Clientes.Listar_pedidos_por_cliente
{
    public class ListarPedidosPorClienteResponse
    {
        public int IdPedido { get; set; }
        public decimal ValorPedido { get; set; }
        public DateTime DataPedido { get; set; }
        public ListarPedidoPorIdClienteResponse Cliente { get; set; }
        public List<ListarPedidoporIdProdutosDetalhadosResponse> Produtos { get; set; }
    }
}
