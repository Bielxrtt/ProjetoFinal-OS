using FluentValidation;
using Os.Domain.Entities;

namespace Os.Service.Validators
{
    public class ServiceOrderValidator : AbstractValidator<ServiceOrder>
    {
        public ServiceOrderValidator()
        {



            RuleFor(c => c.Price)
                .GreaterThanOrEqualTo(0)
                .WithMessage("O preço deve ser maior ou igual a zero.");

           
            RuleFor(c => c.Note)
                .MaximumLength(500)
                .WithMessage("A observação não pode ultrapassar 500 caracteres.");

            RuleFor(c => c.IdStatus)
                .GreaterThan(0)
                .WithMessage("O status da OS é obrigatório.");

            
            RuleFor(c => c.UserId)
                .GreaterThan(0)
                .WithMessage("O usuário responsável é obrigatório.");

           
            RuleFor(c => c.IdClient)
                .GreaterThan(0)
                .WithMessage("O cliente é obrigatório.");

           
            RuleFor(c => c.IdDevice)
                .GreaterThan(0)
                .WithMessage("O dispositivo é obrigatório.");

            RuleFor(c => c.Services)
                .NotNull()
                .WithMessage("A lista de serviços não pode ser nula.")
                .Must(list => list != null && list.Any())
                .WithMessage("É necessário informar ao menos um serviço.");

            RuleFor(c => c.Products)
                .NotNull()
                .WithMessage("A lista de produtos não pode ser nula.");
        }
    }
}
