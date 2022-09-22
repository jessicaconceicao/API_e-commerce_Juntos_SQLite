using API_Juntos.Application.Models.Pedidos.InserirPedido;
using FluentValidation;

namespace API_Juntos.Application.Validations
{

    public class InserirPedidoRequestValidator : AbstractValidator<InserirPedidoRequest>
    {
        public InserirPedidoRequestValidator()
        {
            RuleFor(r => r.Produtos)
                 .NotEmpty()
                 .NotNull()
                 .WithMessage("Produto deve ser informado");
            RuleFor(r => r.IdCliente)
                .NotEmpty()
                .NotNull()
                .WithMessage("Id do cliente deve ser informado");
        }
    }

}
