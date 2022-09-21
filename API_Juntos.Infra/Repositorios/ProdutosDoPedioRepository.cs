using API_Juntos.Core.Entidades;
using API_Juntos.Core.Repositorios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace API_Juntos.Infra.Repositorios
{
    public class ProdutosDoPedidoRepository : IProdutosDoPedidoRepository
    {
        public Task Excluir(ProdutosDoPedido obj)
        {
            throw new NotImplementedException();
        }

        public Task Inserir(ProdutosDoPedido obj)
        {
            throw new NotImplementedException();
        }

        public Task<ProdutosDoPedido> ListarPorId(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<ProdutosDoPedido>> ListarTodos()
        {
            throw new NotImplementedException();
        }
    }
}
