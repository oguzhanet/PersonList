using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevFramework.Core.DataAccess.NHihabernate;
using PersonList.DataAccess.Abstract;
using PersonList.Entities.Concrete;

namespace PersonList.DataAccess.Concrete.NHibernate
{
    public class NhProductDal:NhEntityRepositoryBase<Person>,IPersonDal
    {
        public NhProductDal(NHibernateHelper nHibernateHelper) : base(nHibernateHelper)
        {
        }
    }
}
