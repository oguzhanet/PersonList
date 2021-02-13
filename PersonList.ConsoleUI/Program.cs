using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PersonList.Business.Abstract;
using PersonList.Business.DependencyResolvers.Ninject;
using PersonList.Entities.Concrete;

namespace PersonList.ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            IPersonService personService = InstanceFactory.GetInstance<IPersonService>();
            //personService.Update(new Person
            //{
            //    Id = 7002,
            //    Address = "Seyitnizam ",
            //    DateOfBirth = new DateTime(1998, 8, 11),
            //    FirstName = "Oğuzhan",
            //    LastName = "Çengiz",
            //    TcNo = "22949419538",
            //    Email = "ozancengiz@gmail.com"

            //});

            foreach (var person in personService.GetAll())
            {
                Console.WriteLine(person.FirstName);
            }
            

            Console.ReadLine();
        }
    }
}
