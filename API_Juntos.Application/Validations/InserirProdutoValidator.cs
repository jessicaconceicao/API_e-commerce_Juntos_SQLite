using API_Juntos.Application.Models.Produtos.InserirProduto;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace API_Juntos.Application.Validations
{
    public class InserirProdutoRequestValidator : AbstractValidator<InserirProdutoRequest>
    {
        public InserirProdutoRequestValidator()
        {
            RuleFor(r => r.Nome)
                  .NotEmpty()
                  .NotNull()
                  .WithMessage("Nome deve ser informado.");
            RuleFor(r => r.Lote)
                .NotEmpty()
                .NotNull()
                .WithMessage("Lote deve ser informado.");
            RuleFor(r => r.Validade)
                .NotEmpty()
                .NotNull()
                .WithMessage("Validade deve ser informada.");
            RuleFor(r => r.QuantidadeEmbalagem)
                .NotEmpty()
                .NotNull()
                .WithMessage("Quantidade da embalagem deve ser informada");
            RuleFor(r => r.Valor)
                .GreaterThan(0)
                .WithMessage("Valor deve ser maior do que zero");
            RuleFor(r => r.QuantidadeEstoque)
                .GreaterThan(0)
                .WithMessage("Quantidade estoque deve ser maior do que zero");

        }
    }
}
