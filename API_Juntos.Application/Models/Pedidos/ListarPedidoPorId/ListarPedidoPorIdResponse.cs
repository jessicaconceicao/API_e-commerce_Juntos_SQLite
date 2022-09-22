using System;
using System.Collections.Generic;

namespace API_Juntos.Application.Models.Pedidos.ListarPedidoPorId
{
    public class ListarPedidoPorIdResponse
    {
        public int IdPedido { get; set; }
        public decimal ValorPedido { get; set; }
        public DateTime DataPedido { get; set; }
        public ListarPedidoPorIdClienteResponse Cliente { get; set; }
        public List<ListarPedidoporIdProdutosDetalhadosResponse> Produtos { get; set; }

    }
}
