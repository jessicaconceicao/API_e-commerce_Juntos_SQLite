using API_Juntos.Application.Models.Pedidos.ListarPedidoPorId;
using API_Juntos.Core.Entidades;
using System;
using System.Collections.Generic;

namespace API_Juntos.Application.Models.Pedidos.ListarPedidos
{
    public class ListarPedidosResponse
    {
        public int IdPedido { get; set; }
        public decimal ValorPedido { get; set; }
        public DateTime DataPedido { get; set; }
        public ListarPedidoPorIdClienteResponse Cliente { get; set; }
        public List<ListarPedidoporIdProdutosDetalhadosResponse> Produtos { get; set; }
    }
}
