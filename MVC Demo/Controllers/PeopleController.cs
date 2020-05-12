using MVC_Demo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_Demo.Controllers
{
    public class PeopleController : Controller
    {
        // GET: People
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult ListPeople()
        {
            List<PersonModule> people = new List<PersonModule>();

            people.Add(new PersonModule { firstName = "Maurice", LastName = "Cooper", Age = 27 });
            people.Add(new PersonModule { firstName = "Emanuel", LastName = "King", Age = 37 });
            people.Add(new PersonModule { firstName = "Kwame", LastName = "Antwi", Age = 29 });
            return View(people);
        }
    }
}