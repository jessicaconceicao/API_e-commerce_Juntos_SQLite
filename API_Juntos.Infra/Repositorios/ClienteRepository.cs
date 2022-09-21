using API_Juntos.Core.Entidades;
using API_Juntos.Core.Repositorios;
using API_Juntos.Infra.Database;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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

        public async Task Atualizar(Cliente obj)
        {
            _context.Update(obj);
            _context.SaveChanges();
        }

        public async Task Excluir(Cliente obj)
        {
            _context.Remove(obj);
            _context.SaveChanges();
        }

        public async Task Inserir(Cliente obj)
        {
            _context.Add(obj);
            _context.SaveChanges();
        }

        public async Task<Cliente> ListarPorId(int id)
        {
            return await _context
                .Clientes
                .Where(x => x.IdCliente == id)
                .AsNoTracking()
                .FirstOrDefaultAsync();
        }

        /*  public async Task<Usuario> ListarPorIdParaAtualizar(int id)
          {
              throw new NotImplementedException();
          }*/

        public async Task<IEnumerable<Cliente>> ListarTodos() //pertinente trazer os pedidos na busca??????
        {
            return await _context
                .Clientes
                .AsNoTracking()
                .ToListAsync();

        }
    }
}
