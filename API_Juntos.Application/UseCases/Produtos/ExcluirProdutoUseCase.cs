using API_Juntos.Application.Models.Produtos.ExcluirProduto;
using API_Juntos.Core.Repositorios;
using System.Threading.Tasks;

namespace API_Juntos.Application.UseCases.Produtos
{
    public class ExcluirProdutoUseCase : IUseCaseAsync<ExcluirProdutoRequest, ExcluirProdutoResponse>
    {
        private readonly IProdutoRepository _repository;

        public ExcluirProdutoUseCase(IProdutoRepository repository)
        {
            _repository = repository;
        }

        public async Task<ExcluirProdutoResponse> ExecuteAsync(ExcluirProdutoRequest request)
        {
            var produto = await _repository.ListarPorId(request.IdProduto);
            await _repository.Excluir(produto);
            var produtoResponse = new ExcluirProdutoResponse();
            produtoResponse.Messagem = "Produto excluído do sistema.";
            return produtoResponse;
        }
    }
}
