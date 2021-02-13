using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using DevFramework.Core.Aspects.Postsharp.ValidationAspects;
using PersonList.Business.Abstract;
using PersonList.Business.ServiceAdapters;
using PersonList.Business.ValidationRules.FluentValidation;
using PersonList.DataAccess.Abstract;
using PersonList.Entities.Concrete;

namespace PersonList.Business.Concrete
{
    public class PersonManager:IPersonService
    {
        private IPersonDal _personDal;
        private IKpsService _kpsService;

        public PersonManager(IPersonDal personDal, IKpsService kpsService)
        {
            _personDal = personDal;
            _kpsService = kpsService;
        }


        public List<Person> GetAll()
        {
            return _personDal.GetList();
        }

        [FluentValidationAspect(typeof(PersonValidator))]
        public void Add(Person person)
        {
            CheckIfMemberExists(person);
            CheckIfUserValidFromKps(person);

            _personDal.Add(person);
        }

        private void CheckIfUserValidFromKps(Person person)
        {
            if (_kpsService.ValidatePerson(person) == false)
            {
                throw new Exception("Kullanıcı bilgileri geçerli değildir.");
            }
        }

        private void CheckIfMemberExists(Person person)
        {
            if (_personDal.Get(m => m.TcNo == person.TcNo) != null)
            {
                throw new Exception("Bu kullanıcı daha Önce kayıt olmuştur.");
            }
        }


        public void Update(Person person)
        {
            _personDal.Update(person);
        }

        public void Delete(Person person)
        {
            _personDal.Delete(person);
        }
    }
}
