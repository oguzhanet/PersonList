using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PersonList.Entities.Concrete;

namespace PersonList.DataAccess.Concrete.EntityFramework.Mappings
{
    public class PersonMap:EntityTypeConfiguration<Person>
    {
        public PersonMap()
        {
            ToTable(@"Persons", @"dbo");
            HasKey(x => x.Id);

            Property(x => x.Address).HasColumnName("Address");
            Property(x => x.DateOfBirth).HasColumnName("DateOfBirth");
            Property(x => x.Email).HasColumnName("Email");
            Property(x => x.FirstName).HasColumnName("FirstName");
            Property(x => x.LastName).HasColumnName("LastName");
            Property(x => x.TcNo).HasColumnName("TcNo");
        }
    }
}
