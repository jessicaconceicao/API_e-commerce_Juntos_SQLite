using API_Juntos.Application.Models.Produtos.InserirProduto;
using API_Juntos.Application.Validations;
using API_Juntos.Core.Entidades;
using API_Juntos.Core.Repositorios;
using AutoMapper;
using System;
using System.Threading.Tasks;

namespace API_Juntos.Application.UseCases.Produtos
{
    public class InserirProdutoUseCase : IUseCaseAsync<InserirProdutoRequest, InserirProdutoResponse>
    {

        private readonly IProdutoRepository _repository;
        private readonly IMapper _mapper;

        public InserirProdutoUseCase(IProdutoRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<InserirProdutoResponse> ExecuteAsync(InserirProdutoRequest request)
        {
            var validator = new InserirProdutoRequestValidator();
            var validatorResults = validator.Validate(request);

            if (!validatorResults.IsValid)
            {
                var validatorErros = string.Empty;
                foreach (var error in validatorResults.Errors)
                    validatorErros += error.ErrorMessage + " | ";

                throw new Exception(validatorErros);
            }

            if (request == null)
            { return null; }

            var produto = _mapper.Map<Produto>(request);

            await _repository.Inserir(produto);

            var produtoResponse = new InserirProdutoResponse();
            produtoResponse.Messagem = "Produto inserido com sucesso!";
            return produtoResponse;

        }

    }
}
