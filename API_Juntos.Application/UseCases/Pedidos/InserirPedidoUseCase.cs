using API_Juntos.Application.Models.Cliente.InserirCliente;
using API_Juntos.Application.Models.Pedidos.InserirPedido;
using API_Juntos.Application.Validations;
using API_Juntos.Core.Entidades;
using API_Juntos.Core.Repositorios;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


/*
//namespace API_Juntos.Application.UseCases.Pedidos
//{
//    public class InserirPedidoUseCase : IUseCaseAsync<InserirPedidoRequest, InserirPedidoResponse>
//    {
//        private readonly IPedidoRepository _pedidoRepository;
//        private readonly IProdutosDoPedidoRepository _produtosDoPedidoRepository;
//        private readonly IProdutoRepository _produtoRepository;
//        private readonly IMapper _mapper;

//        public InserirPedidoUseCase(IPedidoRepository pedidoRepository,
//            IProdutosDoPedidoRepository produtosDoPedidoRepository,
//            IProdutoRepository produtoRepository,
//            IMapper mapper)
//        {
//            _pedidoRepository = pedidoRepository;
//            _produtosDoPedidoRepository = produtosDoPedidoRepository;
//            _produtoRepository = produtoRepository;
//            _mapper = mapper;
//        }

//        public async Task<InserirPedidoResponse> ExecuteAsync(InserirPedidoRequest request)
//        {
//            if (request == null)
//            { return null; }

//            List<Produto> produtoList = new List<Produto>();
//            decimal ValorPedido = 0;

//            foreach(var item in request.ProdutosSolicitados)
//            {
//                var produtoSolicitado = await  _produtoRepository.ListarPorId(item.IdProduto); //pega o id do request e passa para buscar produto por id
//                var valorTotalProduto = produtoSolicitado.Valor * item.Quantidade; //pq n tá acessando o valor do produto encontrado pelo id??? //acessa o valor do produto encontrado e multiplica pela qnt vinda do request 
//                ValorPedido += valorTotalProduto; //acrescenta o valor obtido ao total do pedido
//                produtoList.Add(produtoSolicitado); //adiciona o produto encontrado à lista de produtos criada
//            }



//            //cria objeto do tipo ProdutosDoPedido
//            ProdutosDoPedido  produtoDoPedido = new ProdutosDoPedido
//            {
//                //Quantidade = request.ProdutosSolicitados.,
//                ValorTotal = ValorPedido,
//                Produtos = produtoList

//            };

//            //mapeia???? var produtodoPedido = _mapper.Map<ProdutosDoPedido>(tem dados vindos so request e outros locais. como ficaria?);
//            _produtosDoPedidoRepository.Inserir(produtoDoPedido); //espera entidade

//            var pedido = new
//            {
//                ValorPedido = ValorPedido,
//                DataPedido = DateTime.Now,
//                IdCliente = request.IdCliente
//                //o id deveria ser gerado pelo banco
//            };
//            _pedidoRepository.Inserir(pedido);




//            var pedidoResponse = new InserirPedidoResponse();
//            pedidoResponse.Messagem = "Pedido inserido com sucesso!";
//            return pedidoResponse;


//        }
//    }
//}



namespace API_Juntos.Application.UseCases.Pedidos
{
    public class InserirPedidoUseCase : IUseCaseAsync<InserirPedidoRequest, InserirPedidoResponse>
    {
        private readonly IPedidoRepository _repository;
        private readonly IMapper _mapper;

        public InserirPedidoUseCase(IPedidoRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
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

            foreach (var produtos in request.Produtos)
                produtosDosPedidos.Add(new ProdutosDoPedido(produtos.IdProduto, produtos.Quantidade));

           // var pedido = new Pedido(DateTime.Now, request.IdCliente, pedidoProdutos);

            //foreach (var qtd in request.QuantidadeProduto)
            //    foreach (var produtoId in request.IdProduto)
            //        produtosDosPedidos.Add(new ProdutosDoPedido(qtd,produtoId));

            //erro: System.InvalidOperationException: No suitable constructor was found for entity type 'Pedido'.
            //The following constructors had parameters that could not be bound to properties of the entity type:
            //cannot bind 'produtosDoPedido' in 'Pedido(DateTime dataPedido, List<ProdutosDoPedido> produtosDoPedido, int idCliente)'.

            var pedido = new Pedido(DateTime.Now, produtosDosPedidos, request.IdCliente);

            await _repository.Inserir(pedido);

            //var pedido = _mapper.Map<Pedido>(request);

            //pedido.ValorPedido = pedido.ProdutosDoPedido.Sum(s => s.ValorTotal * s.Quantidade);

            //await _repository.Inserir(pedido); 


            var pedidoResponse = new InserirPedidoResponse();
            pedidoResponse.Mensagem = "Pedido inserido com sucesso!";
            return pedidoResponse;

        }

    }
}
*/
namespace API_Juntos.Application.UseCases.Pedidos
{
    public class InserirPedidoUseCase : IUseCaseAsync<InserirPedidoRequest, InserirPedidoResponse>
    {
        private readonly IPedidoRepository _repository;
        private readonly IProdutoRepository _produtoRepository;
        private readonly IMapper _mapper;

        public InserirPedidoUseCase(IPedidoRepository repository, IProdutoRepository produtoRepository, IMapper mapper)
        {
            _repository = repository;
            _produtoRepository = produtoRepository;
            _mapper = mapper;
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

            foreach (var produtos in request.Produtos)
                produtosDosPedidos.Add(new ProdutosDoPedido(produtos.Quantidade, produtos.IdProduto));

            decimal valorPedido = 0;

            foreach (var item in produtosDosPedidos)
            {
                var produtoSolicitado = await _produtoRepository.ListarPorId(item.IdProduto); //pega o id do request e passa para buscar produto por id
                var valorTotalProduto = produtoSolicitado.Valor * item.Quantidade; //acessa o valor do produto encontrado e multiplica pela qnt vinda do request 
                valorPedido += valorTotalProduto; //acrescenta o valor obtido ao total do pedido
            }

            var pedido = new Pedido(DateTime.Now, produtosDosPedidos, request.IdCliente, valorPedido);

            await _repository.Inserir(pedido);




            var pedidoResponse = new InserirPedidoResponse();
            pedidoResponse.Mensagem = "Pedido inserido com sucesso!";
            return pedidoResponse;

        }

    }
}