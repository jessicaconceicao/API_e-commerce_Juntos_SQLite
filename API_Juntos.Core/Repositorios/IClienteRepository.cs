using API_Juntos.Core.Entidades;
using System.Threading.Tasks;

namespace API_Juntos.Core.Repositorios
{
    public interface IClienteRepository : IRepository<Cliente>
    {
        Task Atualizar(Cliente obj);
    }
}
