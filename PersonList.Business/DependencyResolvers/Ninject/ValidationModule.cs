using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentValidation;
using Ninject.Modules;
using PersonList.Business.ValidationRules.FluentValidation;
using PersonList.Entities.Concrete;

namespace PersonList.Business.DependencyResolvers.Ninject
{
    public class ValidationModule:NinjectModule
    {
        public override void Load()
        {
            Bind<IValidator<Person>>().To<PersonValidator>().InSingletonScope();
        }
    }
}
