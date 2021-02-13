using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevFramework.Core.Entities;

namespace PersonList.Entities.Concrete
{
    public class Person:IEntity
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public string TcNo { get; set; }
        public string Email { get; set; }
        public DateTime DateOfBirth { get; set; }
    }
}
