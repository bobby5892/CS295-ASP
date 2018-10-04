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
            List<LocationModel> locations = new List<LocationModel>();
            locations.Add(new LocationModel() {name="Excite",link="http://excite.com" });
            locations.Add(new LocationModel() { name = "Google", link = "http://google.com" });
            locations.Add(new LocationModel() { name = "Lane Community College", link = "http://lanecc.edu" });
            locations.Add(new LocationModel() { name = "Eugene Programming", link = "http://eugeneprogramming.com" });
            LocationViewerModel locationViewerModel = new LocationViewerModel();
            locationViewerModel.locations = locations;
            return View("Locations", locationViewerModel);
        }
        public IActionResult People()
        {
            List<PersonModel> persons = new List<PersonModel>();
            persons.Add(new PersonModel() { name="Daniel Steel",link= "https://www.biography.com/people/danielle-steel"});
            persons.Add(new PersonModel() { name = "Tim Schafer", link = " https://www.biography.com/people/tim-schafer" });

            PersonsViewerModel personsViewerModel = new PersonsViewerModel();
            personsViewerModel.persons = persons;
            return View("People", personsViewerModel);
        }
    }
}
