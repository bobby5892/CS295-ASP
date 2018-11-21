using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ComplaintDepartment.Models;
using ComplaintDepartment.Models.Repositories;

namespace ComplaintDepartment.Controllers
{
    
    public class ComplaintController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Add()
        {
            return View();
        }
        public IActionResult List()
        {
            return View();
        }
        public IActionResult Search()
        {
            return View();
        }
        public IActionResult MarkComplete()
        {
            return View();
        }
        public IActionResult Comment()
        {
            return View();
        }

    }
}