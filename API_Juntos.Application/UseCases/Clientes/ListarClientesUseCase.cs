using API_Juntos.Application.Models.Cliente.ListarClientes;
using API_Juntos.Core.Repositorios;
using AutoMapper;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace API_Juntos.Application.UseCases.Clientes
{
    public class ListarClientesUseCase : IUseCaseAsync<ListarClientesRequest, List<ListarClientesResponse>>
    {
        private readonly IClienteRepository _repository;
        private readonly IMapper _mapper;

        public ListarClientesUseCase(IClienteRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<List<ListarClientesResponse>> ExecuteAsync(ListarClientesRequest request)
        {
            var clientes = await _repository.ListarTodos();
            var retorno = _mapper.Map<List<ListarClientesResponse>>(clientes);
            return retorno;
        }
    }
}
