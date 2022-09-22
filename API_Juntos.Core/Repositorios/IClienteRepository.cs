using API_Juntos.Core.Entidades;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace API_Juntos.Core.Repositorios
{
    public interface IClienteRepository : IRepository<Cliente>
    {
        Task<IEnumerable<Pedido>> ListarTodosOsPedidos(int id);
    }
}
