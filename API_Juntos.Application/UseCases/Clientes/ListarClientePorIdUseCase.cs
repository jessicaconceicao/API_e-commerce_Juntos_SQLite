using API_Juntos.Application.Models.Cliente.ListarClientePorId;
using API_Juntos.Core.Repositorios;
using AutoMapper;
using System.Threading.Tasks;

namespace API_Juntos.Application.UseCases.Clientes
{
    public class ListarClientePorIdUseCase : IUseCaseAsync<int, ListarClientePorIdResponse>
    {
        private readonly IClienteRepository _repository;
        private readonly IMapper _mapper;

        public ListarClientePorIdUseCase(IClienteRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<ListarClientePorIdResponse> ExecuteAsync(int request)
        {
            var cliente = await _repository.ListarPorId(request);

            ListarClientePorIdResponse retorno = null;

            if (cliente != null)
            {
                retorno = _mapper.Map<ListarClientePorIdResponse>(cliente);
            }

            return await Task.FromResult(retorno);
        }
    }
}
