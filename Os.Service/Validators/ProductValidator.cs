using FluentValidation;
using Os.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Os.Service.Validators
{
    public class ProductValidator : AbstractValidator<Product>
    {
        public ProductValidator()
        {

            RuleFor(c => c.Quantity).NotEmpty().WithMessage("Quantidade é obrigatório");
            
        }


    }
}
