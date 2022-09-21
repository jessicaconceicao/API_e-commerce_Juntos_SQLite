using API_Juntos.Application.Models.Pedidos.ListarPedidoPorId;
using API_Juntos.Core.Repositorios;
using AutoMapper;
using System.Threading.Tasks;

namespace API_Juntos.Application.UseCases.Pedidos
{
    //public class ListarPedidoPorIdUseCase : IUseCaseAsync<int, ListarPedidoPorIdResponse>
    //{
    //    private readonly IPedidoRepository _PedidoRepository;
    //    private readonly IProdutosDoPedidoRepository _ProdutosDoPedidorepository;
    //            private readonly IMapper _mapper;

    //    public ListarPedidoPorIdUseCase(IPedidoRepository repository, IMapper mapper)
    //    {
    //        _repository = repository;
    //        _mapper = mapper;
    //    }

    //    public async Task<ListarPedidoPorIdResponse> ExecuteAsync(int request)
    //    {
    //        var pedido = await _repository.ListarPorId(request);

    //        var retorno = (ListarPedidoPorIdResponse)null;

    //        if (pedido != null)
    //        {
    //            retorno = _mapper.Map<ListarPedidoPorIdResponse>(pedido);
    //        }

    //        return await Task.FromResult(retorno);
    //    }
    //}
    public class ListarPedidoPorIdUseCase : IUseCaseAsync<int, ListarPedidoPorIdResponse>
    {
        private readonly IPedidoRepository _repository;
        private readonly IMapper _mapper;

        public ListarPedidoPorIdUseCase(IPedidoRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<ListarPedidoPorIdResponse> ExecuteAsync(int request)
        {
            if (request == null)
                return null;

            var pedido = await _repository.ListarPorId(request);

            ListarPedidoPorIdResponse retorno = null;

            if (pedido != null)
            {
                retorno = _mapper.Map<ListarPedidoPorIdResponse>(pedido);
            }

            return await Task.FromResult(retorno);
        }
    }
}
