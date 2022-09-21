namespace API_Juntos.Application.Models.Cliente.ListarClientes
{
    public class ListarClientesResponse
    {
        public int IdCliente { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Telefone { get; set; }
        public string Endereco { get; set; }
    }
}
