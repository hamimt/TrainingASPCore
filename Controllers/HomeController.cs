using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace SampleASPCore.Controllers
{
     //[Route("Company/[controller]/[action]")]
    //[Route("Home")]
    public class HomeController : Controller
    {
        //[Route("Index")]
        public IActionResult Index()
        {
            return View();
        }

        //[Route("About")]
        public IActionResult About(string name, string address)
        {
            return Content($"Your name is {name} and you lived at {address}");
        }

        //[Route("Framework")]
        public IActionResult GetFrameworkNames()
        {
            string[] frameworkNameArr = new string[] {"Angular", "React", "Vue"};

            return new JsonResult(frameworkNameArr);
        }

        //[Route("Triangle")]
        public IActionResult CalculateTriangle(double alas, double tinggi)
        {
            var result = 0.5 * alas * tinggi;
            ViewBag.Alas = alas;
            ViewBag.Tinggi = tinggi;
            //ViewData["result"] = result;
            ViewBag.Result = result;
            return View("Triangle");
        }
    }
}