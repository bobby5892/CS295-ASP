using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using community.Models;
using System.Web;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace community.Controllers
{
    public class InfoController : Controller
    {
        // GET: /<controller>/
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Locations()
        {
            List<Location> locations = new List<Location>();
            locations.Add(new Location() {Name="Excite",Link="http://excite.com" });
            locations.Add(new Location() { Name = "Google", Link = "http://google.com" });
            locations.Add(new Location() { Name = "Lane Community College", Link = "http://lanecc.edu" });
            locations.Add(new Location() { Name = "Eugene Programming", Link = "http://eugeneprogramming.com" });
            // Wk3 sort requirement
            locations.Sort((loc1, loc2) => loc1.Name.CompareTo(loc2.Name));
            LocationViewModel locationViewModel = new LocationViewModel();
            locationViewModel.Locations = locations;
            return View("Locations", locationViewModel);
        }
        public IActionResult People()
        {
            List<Person> persons = new List<Person>();
            persons.Add(new Person() { Name="Daniel Steel",Link= "https://www.biography.com/people/danielle-steel"});
            persons.Add(new Person() { Name = "Tim Schafer", Link = " https://www.biography.com/people/tim-schafer" });
            // Wk3 sort requirement
            persons.Sort((pers1, pers2) => pers1.Name.CompareTo(pers2.Name));

            PersonsViewModel personsViewModel = new PersonsViewModel();
            personsViewModel.Persons = persons;
            return View("People", personsViewModel);
        }
    }
}
