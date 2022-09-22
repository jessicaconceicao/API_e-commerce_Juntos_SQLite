using API_Juntos.Application.Models.Pedidos.InserirPedido;
using API_Juntos.Application.Validations;
using API_Juntos.Core.Entidades;
using API_Juntos.Core.Repositorios;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;


namespace API_Juntos.Application.UseCases.Pedidos
{
    public class InserirPedidoUseCase : IUseCaseAsync<InserirPedidoRequest, InserirPedidoResponse>
    {
        private readonly IPedidoRepository _repository;
        private readonly IProdutoRepository _produtoRepository;
        
        public InserirPedidoUseCase(IPedidoRepository repository, IProdutoRepository produtoRepository)
        {
            _repository = repository;
            _produtoRepository = produtoRepository;
        }

        public async Task<InserirPedidoResponse> ExecuteAsync(InserirPedidoRequest request)
        {
            var validator = new InserirPedidoRequestValidator();
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

            var produtosDosPedidos = new List<ProdutosDoPedido>();

            //foreach (var produtos in request.Produtos)
            //    produtosDosPedidos.Add(new ProdutosDoPedido(produtos.Quantidade, produtos.IdProduto));
            foreach (var produtos in request.Produtos)
            {
                var produtoSolicitado = await _produtoRepository.ListarPorId(produtos.IdProduto);
                decimal totalParcial = produtos.Quantidade * produtoSolicitado.Valor;
                produtosDosPedidos.Add(new ProdutosDoPedido(produtos.Quantidade, produtos.IdProduto, totalParcial));
            }

            decimal valorPedido = 0;

            //foreach (var item in produtosDosPedidos)
            //{
            //    var produtoSolicitado = await _produtoRepository.ListarPorId(item.IdProduto); 
            //    var valorTotalProduto = produtoSolicitado.Valor * item.Quantidade;  
            //    valorPedido += valorTotalProduto; 
            //}
            foreach (var item in produtosDosPedidos)
            {
                valorPedido += item.ValorTotal;
            }

            var pedido = new Pedido(DateTime.Now, produtosDosPedidos, request.IdCliente, valorPedido);

            await _repository.Inserir(pedido);

            var pedidoResponse = new InserirPedidoResponse();
            pedidoResponse.Mensagem = "Pedido inserido com sucesso!";
            return pedidoResponse;

        }

    }
}