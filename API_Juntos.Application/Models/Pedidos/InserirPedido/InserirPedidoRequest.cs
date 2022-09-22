using System.Collections.Generic;

namespace API_Juntos.Application.Models.Pedidos.InserirPedido
{
    public class InserirPedidoRequest
    {
        public int IdCliente { get; set; }
        public List<ProdutosDoPedidoRequest> Produtos { get; set; }

    }
}

