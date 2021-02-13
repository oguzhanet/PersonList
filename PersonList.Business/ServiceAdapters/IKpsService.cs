using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PersonList.Entities.Concrete;

namespace PersonList.Business.ServiceAdapters
{
    public interface IKpsService
    {
        bool ValidatePerson(Person person);
    }
}
