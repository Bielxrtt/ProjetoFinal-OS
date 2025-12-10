using FluentValidation;
using Os.Domain.Entities;

namespace Os.Service.Validators
{
    public class ServiceOrderValidator : AbstractValidator<ServiceOrder>
    {
        public ServiceOrderValidator()
        {
            // PREÇO
            RuleFor(c => c.Price)
                .GreaterThanOrEqualTo(0)
                .WithMessage("O preço deve ser maior ou igual a zero.");

            // OBSERVAÇÃO
            RuleFor(c => c.Note)
                .MaximumLength(500)
                .WithMessage("A observação não pode ultrapassar 500 caracteres.");

            // STATUS
            RuleFor(c => c.IdStatus)
                .GreaterThan(0)
                .WithMessage("O status da OS é obrigatório.");

            // USUÁRIO RESPONSÁVEL
            RuleFor(c => c.UserId)
                .GreaterThan(0)
                .WithMessage("O usuário responsável é obrigatório.");

            // CLIENTE
            RuleFor(c => c.IdClient)
                .GreaterThan(0)
                .WithMessage("O cliente é obrigatório.");

            // DISPOSITIVO
            RuleFor(c => c.IdDevice)
                .GreaterThan(0)
                .WithMessage("O dispositivo é obrigatório.");

            // SERVIÇOS (N:N)
            RuleFor(c => c.Services)
                .NotNull()
                .WithMessage("A lista de serviços não pode ser nula.")
                .Must(list => list != null && list.Any())
                .WithMessage("É necessário informar ao menos um serviço.");

            // PRODUTOS (N:N) — Não obrigatórios, mas a lista não pode ser nula
            RuleFor(c => c.Products)
                .NotNull()
                .WithMessage("A lista de produtos não pode ser nula.");
        }
    }
}
