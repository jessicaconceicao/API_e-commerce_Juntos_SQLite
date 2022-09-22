using API_Juntos.Application.Models.Produtos.ListarProdutoPorId;
using API_Juntos.Core.Repositorios;
using AutoMapper;
using System.Threading.Tasks;

namespace API_Juntos.Application.UseCases.Produtos
{
    public class ListarProdutoPorIdUseCase : IUseCaseAsync<int, ListarProdutoPorIdResponse>
    {
        private readonly IProdutoRepository _repository;
        private readonly IMapper _mapper;

        public ListarProdutoPorIdUseCase(IProdutoRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<ListarProdutoPorIdResponse> ExecuteAsync(int request)
        {

            var produto = await _repository.ListarPorId(request);

            ListarProdutoPorIdResponse retorno = null;

            if (produto != null)
            {
                retorno = _mapper.Map<ListarProdutoPorIdResponse>(produto);
            }

            return await Task.FromResult(retorno);

        }
    }
}
