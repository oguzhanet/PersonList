using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PersonList.Business.Abstract;
using PersonList.DataAccess.Concrete.EntityFramework;
using PersonList.Entities.Concrete;
using PersonList.MvcWebUI.Models;

namespace PersonList.MvcWebUI.Controllers
{
    public class PersonController : Controller
    {
        private IPersonService _personService;

        public PersonController(IPersonService personService)
        {
            _personService = personService;
        }

        public ActionResult Add()
        {
            return View(new PersonAddViewModel());
        }

        [HttpPost]
        public ActionResult Add(Person person)
        {
            _personService.Add(person);
            return View(new PersonAddViewModel());
        }
    }
}