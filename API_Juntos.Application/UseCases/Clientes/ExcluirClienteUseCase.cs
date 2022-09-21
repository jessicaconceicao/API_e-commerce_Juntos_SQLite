using API_Juntos.Application.Models.Cliente.ExcluirCliente;
using API_Juntos.Core.Repositorios;
using System.Threading.Tasks;

namespace API_Juntos.Application.UseCases.Clientes
{
    public class ExcluirClienteUseCase : IUseCaseAsync<ExcluirClienteRequest, ExcluirClienteResponse>
    {
        private readonly IClienteRepository _repository;


        public ExcluirClienteUseCase(IClienteRepository repository)
        {
            _repository = repository;
        }

        public async Task<ExcluirClienteResponse> ExecuteAsync(ExcluirClienteRequest request)
        {
            var cliente = await _repository.ListarPorId(request.IdCliente);
            await _repository.Excluir(cliente);
            var clienteResponse = new ExcluirClienteResponse();
            clienteResponse.Messagem = "Cliente excluído do sistema.";
            return clienteResponse;

        }
    }
}
