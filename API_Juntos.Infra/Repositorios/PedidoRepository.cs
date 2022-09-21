using API_Juntos.Core.Entidades;
using API_Juntos.Core.Repositorios;
using API_Juntos.Infra.Database;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace API_Juntos.Infra.Repositorios
{
    public class PedidoRepository : IPedidoRepository
    {
        private readonly ApplicationContext _context;

        public PedidoRepository(ApplicationContext context)
        {
            _context = context;
        }


        /*public async Task Atualizar(Pedido obj)
        {
            throw new NotImplementedException();
        }*/
        public async Task Excluir(Pedido obj)
        {
            _context.Pedidos.Remove(obj);
            await _context.SaveChangesAsync();
        }

        public async Task Inserir(Pedido obj)
        {
            _context.Pedidos.Add(obj);
            await _context.SaveChangesAsync();
        }

        public async Task<Pedido> ListarPorId(int id)
        {
            var result = _context
                 .Pedidos
                 .Include(i => i.ProdutosDoPedido)
                     .ThenInclude(i => i.Produto)
                 .Include(i => i.Cliente)
                 .AsQueryable();

            if (id != 0)
            {
                result = result.Where(w => w.IdPedido == id);
                return await result
                 .AsNoTracking()
                 .FirstOrDefaultAsync();
            }
            else
                return null;
        }

        public async Task<IEnumerable<Pedido>> ListarTodos()
        {
            return await _context
                .Pedidos
                .Include(x => x.ProdutosDoPedido)
                    .ThenInclude(x => x.Produto)
                .Include(i => i.Cliente)
                .AsNoTracking()
                .ToListAsync();
        }


    }
}
