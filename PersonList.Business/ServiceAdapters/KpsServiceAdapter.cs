using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PersonList.Business.KpsServiceReference;
using PersonList.Entities.Concrete;

namespace PersonList.Business.ServiceAdapters
{
    public class KpsServiceAdapter : IKpsService
    {
        public bool ValidatePerson(Person person)
        {
            KpsServiceReference.KPSPublicSoapClient client = new KPSPublicSoapClient();
            return client.TCKimlikNoDogrula(Convert.ToInt64(person.TcNo),
                person.FirstName.ToUpper(), person.LastName.ToUpper(),
                person.DateOfBirth.Year);
        }
    }
}
