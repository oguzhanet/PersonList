using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PersonList.DataAccess.Concrete.EntityFramework.Mappings;
using PersonList.Entities.Concrete;

namespace PersonList.DataAccess.Concrete.EntityFramework
{
    public class PersonContext:DbContext
    {
        public PersonContext()
        {
            Database.SetInitializer<PersonContext>(null);
        }
        public DbSet<Person> Persons { get; set; }
        //

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new PersonMap());
        }
        

    }
}
