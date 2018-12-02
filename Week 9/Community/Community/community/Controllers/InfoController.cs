using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using community.Models;
using System.Web;
using community.Repositories;
// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace community.Controllers
{
    public class InfoController : Controller
    {
        // GET: /<controller>/
        public ILocationRepository locationRepo;
        public IPersonRepository personRepository;
        public InfoController(ILocationRepository locationRepository,IPersonRepository personRepository)
        {
            this.locationRepo = locationRepository;
            this.personRepository = personRepository;

        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Locations()
        {
           
           
            // Wk3 sort requirement
            locationRepo.Locations.Sort((loc1, loc2) => loc1.Name.CompareTo(loc2.Name));
            LocationViewModel locationViewModel = new LocationViewModel();
            locationViewModel.Locations = locationRepo.Locations;
            return View("Locations", locationViewModel);
        }
        public IActionResult People()
        {
           
         
            // Wk3 sort requirement
            personRepository.Persons.Sort((pers1, pers2) => pers1.Name.CompareTo(pers2.Name));

            PersonsViewModel personsViewModel = new PersonsViewModel();
            personsViewModel.Persons = personRepository.Persons;
            return View("People", personsViewModel);
        }
        [HttpGet]
        public IActionResult AddPerson()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddPerson([Bind("ID","Name","Link")] Person person)
        {
            if (ModelState.IsValid)
            {
                personRepository.AddUser(person);
                
                return RedirectToAction("People");
            }
            return View(person);

        }
    }
}
