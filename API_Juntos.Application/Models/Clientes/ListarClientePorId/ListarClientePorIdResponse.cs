namespace API_Juntos.Application.Models.Cliente.ListarClientePorId
{
    public class ListarClientePorIdResponse
    {
        public int IdCliente { get; set; }
        public string CPF { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Telefone { get; set; }
        public string Endereco { get; set; }
    }
}
