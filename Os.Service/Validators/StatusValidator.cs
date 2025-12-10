using FluentValidation;
using Os.Domain.Entities;

namespace Os.Service.Validators
{
    public class StatusValidator : AbstractValidator<Status>
    {
        public StatusValidator()
        {
            RuleFor(x => x.Name)
                .NotEmpty().WithMessage("O nome é obrigatório.")
                .MaximumLength(45).WithMessage("O nome deve ter no máximo 45 caracteres.");

            RuleFor(x => x.Description)
                .NotEmpty().WithMessage("A descrição é obrigatória.")
                .MaximumLength(45).WithMessage("A descrição deve ter no máximo 45 caracteres.");

            RuleFor(x => x.StartDate)
                .NotEmpty().WithMessage("A data de início é obrigatória.");

            RuleFor(x => x.FinishDate)
                .NotEmpty().WithMessage("A data de término é obrigatória.");

            RuleFor(x => x)
                .Must(x => x.FinishDate >= x.StartDate)
                .WithMessage("A data de término deve ser maior ou igual à data de início.");
        }
    }
}
