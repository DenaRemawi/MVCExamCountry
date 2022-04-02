using exam.Data;
using exam.Service;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace exam.Controllers
{
    public class countryController : Controller
    {
        ICountryService countryService;
        public countryController(ICountryService icountryService)
        {
            countryService = icountryService;
        }
        public IActionResult Index()
        {
            return View("Countires");
        }

        public IActionResult Savecountry(Country count)
        {
            countryService.insert(count);
            return View("Countires",count);
        }

        public IActionResult Indexx()
        {
            List<Country> countries = countryService.loadcoun();
            return View("Countires",countries);
        }

     
        public IActionResult Search()
        {

            string name = Request.Form["txtserch"];
            List<Country> lco = countryService.loadcoun();
            return View("Countries",lco);
          

        }


    }
}
