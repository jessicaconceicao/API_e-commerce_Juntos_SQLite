//using API_Juntos.Application.Models.Pedidos.AtualizarPedido;
using API_Juntos.Application.Models.Pedidos.ExcluirPedidos;
using API_Juntos.Application.Models.Pedidos.InserirPedido;
using API_Juntos.Application.Models.Pedidos.ListarPedidoPorId;
using API_Juntos.Application.Models.Pedidos.ListarPedidos;
using API_Juntos.Application.UseCases;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace API_e_commerce_Juntos.Controllers
{
    [ApiController]
    [Route("api/pedidos")]
    public class PedidoController : ControllerBase
    {
        private readonly IUseCaseAsync<InserirPedidoRequest, InserirPedidoResponse> _useCaseInserir;
        //private readonly IUseCaseAsync<AtualizarPedidoRequest, AtualizarPedidoResponse> _useCaseAtualizar;
        private readonly IUseCaseAsync<ExcluirPedidoRequest, ExcluirPedidoResponse> _useCaseExcluir;
        private readonly IUseCaseAsync<int, ListarPedidoPorIdResponse> _useCaseListarPorId;
        private readonly IUseCaseAsync<ListarPedidosRequest, List<ListarPedidosResponse>> _useCaseListarPedidos;
        public PedidoController(IUseCaseAsync<InserirPedidoRequest, InserirPedidoResponse> useCaseInserir,
             //IUseCaseAsync<AtualizarPedidoRequest, AtualizarPedidoResponse> useCaseAtualizar,
            IUseCaseAsync<ExcluirPedidoRequest, ExcluirPedidoResponse> useCaseExcluir,
            IUseCaseAsync<int, ListarPedidoPorIdResponse> useCaseListarPorId,
            IUseCaseAsync<ListarPedidosRequest, List<ListarPedidosResponse>> useCaseListarPedidos)
        {
            _useCaseInserir = useCaseInserir;
            //_useCaseAtualizar = useCaseAtualizar;
            _useCaseExcluir = useCaseExcluir;
            _useCaseListarPorId = useCaseListarPorId;
            _useCaseListarPedidos = useCaseListarPedidos;
        }

        [HttpPost]
        public async Task<ActionResult<InserirPedidoResponse>> Post([FromBody] InserirPedidoRequest request)
        {
            return await _useCaseInserir.ExecuteAsync(request);

            //var inserir = await _useCaseInserir.ExecuteAsync(request);
            //return Ok(inserir);

        }
        /* SE FOR DELETAR, APAGAR DA ID (IMPLEMENTAÇÃO CONTROLLER  E STARTUP)
        [HttpPut("atualizacao_pedido/ {id:int}")]
        public async Task<ActionResult<AtualizarPedidoResponse>> Put([FromRoute] int id)
        {
            return await _useCaseAtualizar.ExecuteAsync(new AtualizarPedidoRequest { Id = id });
        }*/

        [HttpDelete("{id:int}")]
        public async Task<ActionResult<ExcluirPedidoResponse>> Delete([FromRoute] int id)
        {
            return await _useCaseExcluir.ExecuteAsync(new ExcluirPedidoRequest { IdPedido = id });
        }

        [HttpGet]
        public async Task<ActionResult<ListarPedidoPorIdResponse>> Get([FromQuery] int id)
        {
            var response = await _useCaseListarPorId.ExecuteAsync(id);

            if (response == null)
                return new NotFoundObjectResult("Pedido não encontrado");

            return new OkObjectResult(response);
        }

        [HttpGet("listar_todos")]
        public async Task<ActionResult<List<ListarPedidosResponse>>> Get([FromQuery] ListarPedidosRequest request)
        {
            return await _useCaseListarPedidos.ExecuteAsync(request);
        }

    }
}
