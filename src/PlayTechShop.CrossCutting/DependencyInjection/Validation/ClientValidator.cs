using FluentValidation;
using PlayTechShop.Domain.Entities;

namespace PlayTechShop.CrossCutting.DependencyInjection.Validation;
public class ClientValidator : AbstractValidator<Client>
{
    public ClientValidator()
    {
        RuleFor(x => x.Name)
           .NotEmpty().WithMessage("O nome do cliente é obrigatório.")
           .MaximumLength(100).WithMessage("O campo nome aceita no máximo 100 caracteres.")
           .MinimumLength(3).WithMessage("O campo nome aceita no mínimo 3 caracteres.");

        RuleFor(x => x.Email)
          .NotEmpty().WithMessage("O nome do cliente é obrigatório.")
          .MaximumLength(100).WithMessage("O campo nome aceita no máximo 100 caracteres.")
          .MinimumLength(3).WithMessage("O campo nome aceita no mínimo 3 caracteres.");

        RuleFor(x => x.Cpf)
            .NotEmpty().WithMessage("O CPF do cliente é obrigatório.")
            .MaximumLength(14).WithMessage("O campo CPF aceita no máximo 14 caracteres.")
            .MinimumLength(14).WithMessage("O campo CPF aceita no mínimo 14 caracteres.");
    }
}
