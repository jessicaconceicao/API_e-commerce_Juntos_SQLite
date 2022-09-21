using API_Juntos.Core.Entidades;
using API_Juntos.Core.Repositorios;
using API_Juntos.Infra.Database;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API_Juntos.Infra.Repositorios
{
    public class ProdutoRepository : IProdutoRepository
    {
        private readonly ApplicationContext _context;

        public ProdutoRepository(ApplicationContext context)
        {
            _context = context;
        }

        /* public async Task Atualizar(Produto obj)
         {
             throw new NotImplementedException();
         }*/

        public async Task Excluir(Produto obj)
        {
            _context.Remove(obj);
            _context.SaveChanges();
        }

        public async Task Inserir(Produto obj)
        {
            _context.Add(obj);
            _context.SaveChanges();
        }

        public async Task<Produto> ListarPorId(int id)
        {
            return await _context
                .Produtos
                .Where(x => x.IdProduto == id)
                .AsNoTracking()
                .FirstOrDefaultAsync();

        }

        public async Task<IEnumerable<Produto>> ListarTodos()
        {
            return await _context
                .Produtos
                .AsNoTracking()
                .ToListAsync();
        }
    }
}
