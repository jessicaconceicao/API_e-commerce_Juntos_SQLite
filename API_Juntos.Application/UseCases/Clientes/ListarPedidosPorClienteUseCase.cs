using API_Juntos.Application.Models.Clientes.Listar_pedidos_por_cliente;
using API_Juntos.Core.Repositorios;
using AutoMapper;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace API_Juntos.Application.UseCases.Clientes
{
    public class ListarPedidosPorClienteUseCase : IUseCaseAsync<int, List<ListarPedidosPorClienteResponse>>
    {
        private readonly IClienteRepository _clienteRepository;
        private readonly IMapper _mapper;

        public ListarPedidosPorClienteUseCase(IClienteRepository clienteRepository, IMapper mapper)
        {
            _clienteRepository = clienteRepository;
            _mapper = mapper;
        }

        public async Task<List<ListarPedidosPorClienteResponse>> ExecuteAsync(int request)
        {
            var pedidos = await _clienteRepository.ListarTodosOsPedidos(request);
            var retorno = _mapper.Map<List<ListarPedidosPorClienteResponse>>(pedidos);
            return retorno;
        }

    }
}
