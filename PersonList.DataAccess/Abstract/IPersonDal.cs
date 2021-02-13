using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevFramework.Core.DataAccess;
using PersonList.Entities.Concrete;

namespace PersonList.DataAccess.Abstract
{
    public interface IPersonDal:IEntityRepository<Person>
    {

    }
}
