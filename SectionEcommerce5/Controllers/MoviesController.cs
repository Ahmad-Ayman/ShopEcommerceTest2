using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace SectionEcommerce5.Controllers
{
    public class MoviesController : Controller
    {
        // GET: /<controller>/
        public IActionResult Index()
        {
            ViewData["Name"] = "Ahmed Ayman adsadasdasdsa";

            return View();
        }
        public IActionResult Welcome99()
        {
            return View();
        }

        public IActionResult Welcome2()
        {
            return View();
        }
    }
}
