using FluentValidation;
using Os.Domain.Entities;

namespace Os.Service.Mapping
{
    

    public class UserSystemValidator : AbstractValidator<UserSystem>
    {
        public UserSystemValidator()
        {
            RuleFor(u => u.Password)
                .NotEmpty().WithMessage("A senha é obrigatória.")
                .MaximumLength(255).WithMessage("A senha deve ter no máximo 255 caracteres.");

            RuleFor(u => u.AcessLevel)
                .NotEmpty().WithMessage("O nível de acesso é obrigatório.");
                
        }
    }
}
