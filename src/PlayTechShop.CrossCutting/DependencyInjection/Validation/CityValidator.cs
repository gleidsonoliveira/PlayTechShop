using FluentValidation;
using PlayTechShop.Domain.Entities;

namespace PlayTechShop.CrossCutting.DependencyInjection.Validation;
public class CityValidator : AbstractValidator<City>
{
    public CityValidator()
    {
        RuleFor(x => x.Name)
            .NotEmpty().WithMessage("O nome da cidade é obrigatório.")
            .MaximumLength(100).WithMessage("O campo cidade aceita no máximo 100 caracteres.")
            .MinimumLength(3).WithMessage("O campo cidade aceita no mínimo 3 caracteres.");
    }
}
