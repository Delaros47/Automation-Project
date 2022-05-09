using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities.Concrete;
using FluentValidation;

namespace Business.ValidationRules.FluentValidation
{
    public class StockGroupValidator:AbstractValidator<StockGroup>
    {
        public StockGroupValidator()
        {

            RuleFor(s=>s.GroupName).NotEmpty().WithMessage("Group Name cannot be empty");
            RuleFor(s => s.GroupCode).NotEmpty().WithMessage("Group Code cannot be empty");

        }


    }
}
