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
                .WithMessage("O tipo de serviço é obrigatório.");

            RuleFor(c => c.UserId)
                .GreaterThan(0)
                .WithMessage("O usuário responsável é obrigatório.");

            RuleFor(c => c.Start_Date)
                .NotEmpty()
                .WithMessage("A data de início é obrigatória.");

            RuleFor(c => c.Finish_Date)
                .NotEmpty()
                .WithMessage("A data de término é obrigatória.");

            RuleFor(c => c)
                .Must(c => c.Finish_Date >= c.Start_Date)
                .WithMessage("A data de término deve ser maior ou igual à data de início.");
        }
    }
}
