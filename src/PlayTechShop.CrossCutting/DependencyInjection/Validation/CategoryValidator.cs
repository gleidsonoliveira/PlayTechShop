﻿using FluentValidation;
using PlayTechShop.Domain.Entities;

namespace PlayTechShop.CrossCutting.DependencyInjection.Validation;
public class CategoryValidator : AbstractValidator<Category>
{
    public CategoryValidator()
    {
        RuleFor(x => x.Description)
           .NotEmpty().WithMessage("A descrição é obrigatória.")
           .MaximumLength(100).WithMessage("O campo descrição aceita no máximo 100 caracteres.")
           .MinimumLength(3).WithMessage("O campo descrição aceita no mínimo 3 caracteres.");
    }
}
