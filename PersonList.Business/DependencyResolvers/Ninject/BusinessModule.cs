using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ninject.Modules;
using PersonList.Business.Abstract;
using PersonList.Business.Concrete;
using PersonList.Business.ServiceAdapters;
using PersonList.DataAccess.Abstract;
using PersonList.DataAccess.Concrete.EntityFramework;
using PersonList.DataAccess.Concrete.NHibernate;

namespace PersonList.Business.DependencyResolvers.Ninject
{
    public class BusinessModule:NinjectModule
    {
        public override void Load()
        {
            Bind<IPersonService>().To<PersonManager>().InSingletonScope();
            Bind<IPersonDal>().To<EfPersonDal>().InSingletonScope();

            Bind<IKpsService>().To<KpsServiceAdapter>().InSingletonScope();
        }
    }
}
