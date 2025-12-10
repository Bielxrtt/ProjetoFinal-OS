using FluentValidation;
using Os.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Os.Service.Validators
{
    public class UserSystemValidator : AbstractValidator<UserSystem>
    {
        public UserSystemValidator() 
        {
            RuleFor(c => c.Password).NotEmpty().WithMessage("Nome do cliente é obrigatório");
            RuleFor(c => c.AcessLevel).NotEmpty().WithMessage("Telefone do cliente é orbigatório");
        }

    }
}
