using FluentValidation;
using Os.Domain.Entities;

namespace Os.Service.Validators
{
    public class ClientValidator : AbstractValidator<Client>
    {

        public ClientValidator() 
        {
            RuleFor(c => c.Name).NotEmpty().WithMessage("Nome do cliente é obrigatório");
            RuleFor(c => c.Phone).NotEmpty().WithMessage("Telefone do cliente é orbigatório");
            RuleFor(c => c.Email).EmailAddress().WithMessage("E-mail é obrigatório");
            RuleFor(c => c.Adress).NotEmpty().WithMessage("Endereço residencial obrigatório");
            RuleFor(c => c.Register_Date).NotEmpty().WithMessage("Data de registro é obrigatório");

        }

    }
}