using API_Juntos.Application.Models.Cliente.ExcluirCliente;
using API_Juntos.Application.Models.Cliente.InserirCliente;
using API_Juntos.Application.Models.Cliente.ListarClientePorId;
using API_Juntos.Application.Models.Cliente.ListarClientes;
using API_Juntos.Application.Models.Clientes.Listar_pedidos_por_cliente;
using API_Juntos.Application.UseCases;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace API_e_commerce_Juntos.Controllers
{
    [ApiController]
    [Route("api/clientes")]
    public class ClienteController : ControllerBase
    {
        public readonly IUseCaseAsync<InserirClienteRequest, InserirClienteResponse> _useCaseInserir;
        private readonly IUseCaseAsync<ExcluirClienteRequest, ExcluirClienteResponse> _useCaseExcluir;
        private readonly IUseCaseAsync<int, ListarClientePorIdResponse> _useCaseListarPorId;
        private readonly IUseCaseAsync<ListarClientesRequest, List<ListarClientesResponse>> _useCaseListarUsuarios;
        private readonly IUseCaseAsync<int, List<ListarPedidosPorClienteResponse>> _useCaseListarPedidosPorCliente;

        public ClienteController(IUseCaseAsync<InserirClienteRequest, InserirClienteResponse> useCaseInserir,
            IUseCaseAsync<ExcluirClienteRequest, ExcluirClienteResponse> useCaseExcluir,
            IUseCaseAsync<int, ListarClientePorIdResponse> useCaseListarPorId,
            IUseCaseAsync<ListarClientesRequest, List<ListarClientesResponse>> useCaseListarUsuarios,
            IUseCaseAsync<int, List<ListarPedidosPorClienteResponse>> useCaseListarPedidosPorCliente)
        {
            _useCaseInserir = useCaseInserir;
            _useCaseExcluir = useCaseExcluir;
            _useCaseListarPorId = useCaseListarPorId;
            _useCaseListarUsuarios = useCaseListarUsuarios;
            _useCaseListarPedidosPorCliente = useCaseListarPedidosPorCliente;

        }

        [HttpPost]
        public async Task<ActionResult<InserirClienteResponse>> Post([FromBody] InserirClienteRequest request)
        {
            return await _useCaseInserir.ExecuteAsync(request);

        }
       

        [HttpDelete("{id:int}")]
        public async Task<ActionResult<ExcluirClienteResponse>> Delete([FromRoute] int id)
        {
            return await _useCaseExcluir.ExecuteAsync(new ExcluirClienteRequest() { IdCliente = id });
        }

        [HttpGet("{id:int}")]
        public async Task<ActionResult<ListarClientePorIdResponse>> Get(int id)
        {
            var response = await _useCaseListarPorId.ExecuteAsync(id);
            if (response == null)
                return new NotFoundObjectResult("Cliente não encontrado");

            return new OkObjectResult(response);

        }

        [HttpGet("listar_todos")]
        public async Task<ActionResult<List<ListarClientesResponse>>> Get([FromQuery] ListarClientesRequest request)
        {
            return await _useCaseListarUsuarios.ExecuteAsync(request);
        }
        
        [HttpGet("listar_pedidos_cliente")]
        
        public async Task<ActionResult<List<ListarPedidosPorClienteResponse>>> GetCliente(int cliente)
        {
            return await _useCaseListarPedidosPorCliente.ExecuteAsync(cliente);
        }
        
    }
}
