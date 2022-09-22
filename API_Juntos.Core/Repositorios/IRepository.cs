using System.Collections.Generic;
using System.Threading.Tasks;

namespace API_Juntos.Core.Repositorios
{
    public interface IRepository<T>
    {
        Task Inserir(T obj);
        Task<IEnumerable<T>> ListarTodos();
        Task<T> ListarPorId(int id);
        Task Excluir(T obj);
        
    }
}
