using FluentValidation;
using Os.Domain.Entities;

namespace Os.Service.Validators
{
    public class ServicesValidator : AbstractValidator<Services>
    {
        public ServicesValidator()
        {
            RuleFor(c => c.TypeService)
                .NotEmpty()
                .WithMessage("O nome do serviço é obrigatório.");

            RuleFor(c => c.Price)
                .GreaterThanOrEqualTo(0)
                .WithMessage("O preço não pode ser negativo.");
        }
    }
}