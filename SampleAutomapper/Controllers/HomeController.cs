using SampleAutomapper.App_Start;
using SampleAutomapper.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SampleAutomapper.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            List<Employee> employees = new List<Employee>();

            for (int i = 0; i < 10; i++)
            {
                Employee emp = new Employee
                {
                    Firstname = FakeData.NameData.GetFirstName(),
                    Lastname = FakeData.NameData.GetSurname(),
                    Adress = FakeData.PlaceData.GetAddress(),
                    Email = FakeData.NameData.GetFullName() + "@gmail.com",
                    Salary = (decimal)FakeData.NumberData.GetDouble()
                };
                employees.Add(emp);
            }


            List<Person> people = new List<Person>();

            //var config = new MapperConfiguration(i =>i.CreateMap<Employee,Person>() );
            //IMapper mapper = config.CreateMapper();
            //MappingProfile mapper = new MappingProfile();
            //var dest = mapper._mapper.Map<List<Person>>(employees);

            var mapper = MappingProfile._mapper;

            var res = mapper.Map<List<Person>>(employees);

            //var dest = mapper._mapper.Map<List<Person>>(employees);

            return View(res);
            
        }
    }
}