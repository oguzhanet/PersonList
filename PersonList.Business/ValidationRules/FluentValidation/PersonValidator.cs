using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentValidation;
using PersonList.Entities.Concrete;

namespace PersonList.Business.ValidationRules.FluentValidation
{
    public class PersonValidator:AbstractValidator<Person>
    {
        public PersonValidator()
        {
            RuleFor(m => m.Address).NotEmpty();
            RuleFor(m => m.FirstName).NotEmpty();
            RuleFor(m => m.LastName).NotEmpty();
            RuleFor(m => m.DateOfBirth).NotEmpty();
            RuleFor(m => m.Email).NotEmpty();
            RuleFor(m => m.TcNo).NotEmpty();
            RuleFor(m => m.DateOfBirth).LessThan(DateTime.Now);
            RuleFor(m => m.Email).EmailAddress();
            RuleFor(m => m.TcNo).Length(11);
        }
    }
}
