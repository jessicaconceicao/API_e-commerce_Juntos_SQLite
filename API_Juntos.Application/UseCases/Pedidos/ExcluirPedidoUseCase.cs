using API_Juntos.Application.Models.Pedidos.ExcluirPedidos;
using API_Juntos.Core.Repositorios;
using System.Threading.Tasks;

namespace API_Juntos.Application.UseCases.Pedidos
{
    public class ExcluirPedidoUseCase : IUseCaseAsync<ExcluirPedidoRequest, ExcluirPedidoResponse>
    {
        private readonly IPedidoRepository _repository;
        public ExcluirPedidoUseCase(IPedidoRepository repository)
        {
            _repository = repository;
        }

        public async Task<ExcluirPedidoResponse> ExecuteAsync(ExcluirPedidoRequest request)
        {
            var pedido = await _repository.ListarPorId(request.IdPedido);
            await _repository.Excluir(pedido);
            var pedidoResponse = new ExcluirPedidoResponse();
            pedidoResponse.Messagem = "Pedido excluído do sistema.";
            return pedidoResponse;
        }
    }
}
