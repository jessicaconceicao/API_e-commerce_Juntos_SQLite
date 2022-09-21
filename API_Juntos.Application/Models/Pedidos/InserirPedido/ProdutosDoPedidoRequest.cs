using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace API_Juntos.Application.Models.Pedidos.InserirPedido
{
    public class ProdutosDoPedidoRequest
    {
        public int IdProduto { get; set; }
        public int Quantidade { get; set; }
    }
}
