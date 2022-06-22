using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.ValidationRules.FluentValidation
{
    public class EmployeeValidator : AbstractValidator<Employee>
    {

        public EmployeeValidator()
        {
            RuleFor(e => e.FirstName).NotEmpty();
            RuleFor(e => e.FirstName).MinimumLength(2);
            RuleFor(e => e.LastName).NotEmpty();
            RuleFor(e => e.LastName).MinimumLength(2);
            RuleFor(e => e.Title).NotEmpty();
            RuleFor(e => e.TitleOfCourtesy).NotEmpty();
        }

    }
}
