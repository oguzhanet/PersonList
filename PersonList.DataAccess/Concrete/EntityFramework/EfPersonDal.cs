using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevFramework.Core.DataAccess.EntityFramework;
using PersonList.DataAccess.Abstract;
using PersonList.Entities.Concrete;

namespace PersonList.DataAccess.Concrete.EntityFramework
{
    public class EfPersonDal:EfEntityRepositoryBase<Person,PersonContext>,IPersonDal
    {

    }
}
