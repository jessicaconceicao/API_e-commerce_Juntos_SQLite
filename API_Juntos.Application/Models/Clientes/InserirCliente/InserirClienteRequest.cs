using API_Juntos.Application.Models.Cliente.InserirCliente;
using FluentValidation;

namespace API_Juntos.Application.Models.Cliente.InserirCliente
{
    public class InserirClienteRequest
    {
        public string Nome { get; set; }
        public string CPF { get; set; }
        public string Email { get; set; }
        public string Telefone { get; set; }
        public string Endereco { get; set; }
    }
}

