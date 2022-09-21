using API_Juntos.Application.Models.Pedidos.InserirPedido;
using API_Juntos.Core.Entidades;
using FluentValidation;
using System.Collections.Generic;

namespace API_Juntos.Application.Models.Pedidos.InserirPedido
{
    public class InserirPedidoRequest
    {
        //public int IdCliente { get; set; }
        //public List<ProdutosDoPedidoRequest> ProdutosDoPedido { get; set; } 
        public int IdCliente { get; set; }
        public List<ProdutosDoPedidoRequest> Produtos { get; set; }

    }
}

