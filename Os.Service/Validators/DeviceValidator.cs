using FluentValidation;
using Os.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Os.Service.Validators
{
    public class DeviceValidator : AbstractValidator<Device>
    {
        public DeviceValidator() 
        {

            RuleFor(c => c.TypeBrand).IsInEnum().WithMessage("Tipo de marca é obrigatório");
            RuleFor(c => c.Model).NotEmpty().WithMessage("Modelo é orbigatório");
            RuleFor(c => c.IMEI).NotEmpty().WithMessage("IMEI obrigatório");
        }


    }
}
