using API_Juntos.Application.Models.Pedidos.InserirPedido;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            //RuleFor(r => r.QuantidadeProduto)
            //    .NotEmpty()
            //    .NotNull()
            //    .WithMessage("A quantidade do produto deve ser informada");
            RuleFor(r => r.IdCliente)
                .NotEmpty()
                .NotNull()
                .WithMessage("Id do cliente deve ser informado");
        }
    }

}
