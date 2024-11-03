using FluentValidation;
using PlayTechShop.Domain.Entities;

namespace PlayTechShop.CrossCutting.DependencyInjection.Validation;
public class StateValidator : AbstractValidator<State>
{
    public StateValidator()
    {
        RuleFor(x => x.Name).NotEmpty().WithMessage("O nome do estado é obrigatório.").MaximumLength(100).WithMessage("O campo estado aceita no máximo 100 caracteres.");
    }
}
