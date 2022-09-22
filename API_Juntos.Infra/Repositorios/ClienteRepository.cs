using API_Juntos.Core.Entidades;
using API_Juntos.Core.Repositorios;
using API_Juntos.Infra.Database;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API_Juntos.Infra.Repositorios
{
    public class ClienteRepository : IClienteRepository
    {
        private readonly ApplicationContext _context;

        public ClienteRepository(ApplicationContext context)
        {
            _context = context;
        }

        public async Task Excluir(Cliente obj)
        {
            _context.Remove(obj);
            await _context.SaveChangesAsync();
        }

        public async Task Inserir(Cliente obj)
        {
            _context.Add(obj);
            await _context.SaveChangesAsync();
        }

        public async Task<Cliente> ListarPorId(int id)
        {
            return await _context
                .Clientes
                .Where(x => x.IdCliente == id)
                .AsNoTracking()
                .FirstOrDefaultAsync();
        }

        public async Task<IEnumerable<Cliente>> ListarTodos() 
        {
            return await _context
                .Clientes
                .AsNoTracking()
                .ToListAsync();
        }
        
        public async Task<IEnumerable<Pedido>> ListarTodosOsPedidos(int id)
        {
            return await  _context
                 .Pedidos.Where(x => x.IdCliente == id)
                 .Include(i => i.ProdutosDoPedido)
                    .ThenInclude(i => i.Produto)
                 .AsNoTracking()
                 .ToListAsync(); 

            
        }
    }
}
